using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace WindowsFormsApp1.Models
{
    public class Appointment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("patient_id")]
        public string PatientId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("dr_id")]
        public string DoctorId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("clinic_id")]
        public string ClinicId { get; set; }

        [BsonElement("app_date")]
        public string AppointmentDate { get; set; }

        [BsonElement("app_time")]
        public string AppointmentTime { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }
    }
}
