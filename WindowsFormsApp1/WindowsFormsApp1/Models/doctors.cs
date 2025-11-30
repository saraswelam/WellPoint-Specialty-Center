using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

public class Doctor
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("first_name")]
    public string FirstName { get; set; }

    [BsonElement("last_name")]
    public string LastName { get; set; }

    [BsonElement("phone_number")]
    public string PhoneNumber { get; set; }

    [BsonElement("email")]
    public string Email { get; set; }

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

    [BsonElement("app_id")]
    public string AppointmentId { get; set; }

    [BsonElement("patient_id")]
    public string PatientId { get; set; }

    [BsonElement("status")]
    public string Status { get; set; }
}
