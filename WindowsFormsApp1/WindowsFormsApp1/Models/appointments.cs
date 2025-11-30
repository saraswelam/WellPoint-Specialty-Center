using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Appointment
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    // References to other collections
    public string PatientId { get; set; }
    public string DoctorId { get; set; }
    public string ClinicId { get; set; }

    public DateTime AppointmentDate { get; set; }
    public TimeSpan AppointmentTime { get; set; }
    public string AppointmentType { get; set; } // "Checkup", "Consultation", "Surgery"
    public string Status { get; set; } // "Scheduled", "Completed", "Cancelled", "NoShow"

    public string Notes { get; set; }
    public int DurationMinutes { get; set; } = 30;

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}