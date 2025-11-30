using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Appointment
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("patient_id")]
    public string PatientId { get; set; }

    [BsonElement("dr_id")]
    public string DoctorId { get; set; }

    [BsonElement("clinic_id")]
    public string ClinicId { get; set; }

    [BsonElement("app_date")]
    public string AppointmentDate { get; set; }

    [BsonElement("app_time")]
    public string AppointmentTime { get; set; }

    [BsonElement("status")]
    public string Status { get; set; }
}
