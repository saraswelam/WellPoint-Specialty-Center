
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ClinicalBookingSystem.Services
{
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

        public List<BsonDocument> GetAppointmentsByPatient(string patientIdStr)
        {
            var patOid = ObjectId.Parse(patientIdStr);

            return _appointments.Find(
                Builders<BsonDocument>.Filter.Eq("patient_id", patOid)
            ).ToList();
        }

        public List<BsonDocument> GetCompletedAppointmentsByPatient(string patientIdStr)
        {
            var patOid = ObjectId.Parse(patientIdStr);

            var filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("patient_id", patOid),
                Builders<BsonDocument>.Filter.Eq("status", "completed")     
            );

            return _appointments.Find(filter).ToList();
        }

        public bool CancelAppointment(ObjectId appointmentId)
        {
            try
            {
                

                var appt = _appointments.Find(
                    Builders<BsonDocument>.Filter.Eq("_id", appointmentId)
                ).FirstOrDefault();

                if (appt == null)
                {
                    
                    return false;
                }

               

                var doctorId = appt["dr_id"].AsObjectId;
                string date = appt["app_date"].AsString;
                string time = appt["app_time"].AsString;

                
                var result1 = _appointments.UpdateOne(
                    Builders<BsonDocument>.Filter.Eq("_id", appointmentId),
                    Builders<BsonDocument>.Update.Set("status", "cancelled")
                );


               
                var slotFilter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("_id", doctorId),
                    Builders<BsonDocument>.Filter.ElemMatch<BsonValue>("slots",
                        new BsonDocument
                        {
                    { "date", date },
                    { "time", time }
                        })
                );

                var slotUpdate = Builders<BsonDocument>.Update.Combine(
                    Builders<BsonDocument>.Update.Set("slots.$.isBooked", false),
                    Builders<BsonDocument>.Update.Set("slots.$.status", "available"),
                    Builders<BsonDocument>.Update.Set("slots.$.app_id", BsonNull.Value),
                    Builders<BsonDocument>.Update.Set("slots.$.patient_id", BsonNull.Value)
                );

                var result2 = _doctors.UpdateOne(slotFilter, slotUpdate);


                
                return result1.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cancel ERROR: " + ex.Message);
                return false;
            }
        }




       
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


                
                var slotFilter = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("_id", doctorOid),
                    Builders<BsonDocument>.Filter.ElemMatch<BsonValue>("slots",
                        new BsonDocument
                        {
                    { "date", date },
                    { "time", time }
                        })
                );

                var slotUpdate = Builders<BsonDocument>.Update.Combine(
                    Builders<BsonDocument>.Update.Set("slots.$.isBooked", true),
                    Builders<BsonDocument>.Update.Set("slots.$.status", "booked"),
                    Builders<BsonDocument>.Update.Set("slots.$.app_id", appointmentId),
                    Builders<BsonDocument>.Update.Set("slots.$.patient_id", patientOid)
                );

                var updated = _doctors.UpdateOne(slotFilter, slotUpdate);

                if (updated.ModifiedCount == 0)
                {
                    error = "Failed to update doctor slot – slot not found.";
                    return false;
                }


                
                _patients.UpdateOne(
                    Builders<BsonDocument>.Filter.Eq("_id", patientOid),
                    Builders<BsonDocument>.Update.Set("appointment_id", appointmentId.ToString())
                );


               
                var payStatus = "pending";

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

}
