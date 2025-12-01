// Services/AppointmentService.cs
using MongoDB.Bson;
using MongoDB.Driver;
using System;

public class AppointmentService
{
    private readonly IMongoCollection<BsonDocument> _appointments;
    private readonly IMongoCollection<BsonDocument> _doctors;
    private readonly IMongoCollection<BsonDocument> _patients;
    private readonly IMongoCollection<BsonDocument> _payments;

    public AppointmentService()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var db = client.GetDatabase("ClinicalBookingSystem");

        _appointments = db.GetCollection<BsonDocument>("appointments");
        _doctors = db.GetCollection<BsonDocument>("doctors");
        _patients = db.GetCollection<BsonDocument>("patients");
        _payments = db.GetCollection<BsonDocument>("payments");
    }

    /// <summary>
    /// Book appointment: create appointment doc, update doctor's slot, update patient, optionally create payment
    /// </summary>
    public bool BookAppointment(string patientIdStr, string doctorIdStr, string clinicIdStr,
                                string date, string time,
                                double fee, string paymentMethod,
                                out ObjectId appointmentId, out string error)
    {
        appointmentId = ObjectId.Empty;
        error = null;

        try
        {
            var patientOid = ObjectId.Parse(patientIdStr);
            var doctorOid = ObjectId.Parse(doctorIdStr);
            var clinicOid = ObjectId.Parse(clinicIdStr);

            // 1) Create appointment document
            var apDoc = new BsonDocument
            {
                { "patient_id", patientOid },
                { "dr_id", doctorOid },
                { "clinic_id", clinicOid },
                { "app_date", date },
                { "app_time", time },
                { "status", "scheduled" }
            };

            _appointments.InsertOne(apDoc);
            appointmentId = apDoc["_id"].AsObjectId;

            // 2) Update doctor slot to booked where date/time match and slot is available
            var slotFilter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("_id", doctorOid),
                Builders<BsonDocument>.Filter.Eq("slots.date", date),
                Builders<BsonDocument>.Filter.Eq("slots.time", time)
            );

            var slotUpdate = Builders<BsonDocument>.Update
                .Set("slots.$.isBooked", true)
                .Set("slots.$.app_id", appointmentId)
                .Set("slots.$.patient_id", patientOid)
                .Set("slots.$.status", "booked");

            var updateRes = _doctors.UpdateOne(slotFilter, slotUpdate);

            // 3) Update patient's appointment_id (store string)
            _patients.UpdateOne(
                Builders<BsonDocument>.Filter.Eq("_id", patientOid),
                Builders<BsonDocument>.Update.Set("appointment_id", appointmentId.ToString()));

            // 4) Insert payment (initially pending/completed depending on method) — create immediate record
            var payStatus = "pending";
            if (paymentMethod == "cash") payStatus = "pending";
            else if (paymentMethod == "insurance") payStatus = "pending";
            else payStatus = "pending"; // card => pending until processed

            var paymentDoc = new BsonDocument
            {
                { "app_id", appointmentId },
                { "amount", fee },
                { "status", payStatus },
                { "payment_date", DateTime.UtcNow.ToString("yyyy-MM-dd") },
                { "method", paymentMethod }
            };

            _payments.InsertOne(paymentDoc);

            return true;
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }
    }
}
