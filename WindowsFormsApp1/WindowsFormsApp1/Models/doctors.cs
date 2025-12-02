using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
namespace WindowsFormsApp1.Models
{
    public class Doctor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("user_id")]
        public string UserId { get; set; }

        // ✔ Added reference to clinic
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("clinic_id")]
        public string ClinicId { get; set; }

        [BsonElement("first_name")]
        public string FirstName { get; set; }

        [BsonElement("last_name")]
        public string LastName { get; set; }

        [BsonElement("phone_number")]
        public string PhoneNumber { get; set; }

        [BsonElement("consultation_fee")]
        public double? ConsultationFee { get; set; }

        [BsonElement("certification")]
        public List<string> Certification { get; set; }

        [BsonElement("specialization")]
        public string Specialization { get; set; }

        [BsonElement("schedule")]
        public Schedule Schedule { get; set; }

        [BsonElement("working_hours")]
        public WorkingHours WorkingHours { get; set; }

        [BsonElement("slots")]
        public List<DoctorSlot> Slots { get; set; }
    }

    public class Schedule
    {
        [BsonElement("available_days")]
        public List<string> AvailableDays { get; set; }
    }

    public class WorkingHours
    {
        [BsonElement("start_time")]
        public string StartTime { get; set; }

        [BsonElement("end_time")]
        public string EndTime { get; set; }
    }

    public class DoctorSlot
    {
        [BsonElement("date")]
        public string Date { get; set; }

        [BsonElement("time")]
        public string Time { get; set; }

        [BsonElement("isBooked")]
        public bool IsBooked { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("app_id")]
        public string AppointmentId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("patient_id")]
        public string PatientId { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }
    }
}
