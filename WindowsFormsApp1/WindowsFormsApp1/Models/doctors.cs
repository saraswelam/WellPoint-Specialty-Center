using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

public class Doctor
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Name { get; set; }
    public string Specialization { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string LicenseNumber { get; set; }

    // References
    public string ClinicId { get; set; }
    public string DepartmentId { get; set; }

    // Embedded schedule
    public List<ScheduleSlot> Schedule { get; set; } = new List<ScheduleSlot>();

    public decimal ConsultationFee { get; set; }
    public int YearsOfExperience { get; set; }
}

public class ScheduleSlot
{
    public DayOfWeek Day { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public bool IsAvailable { get; set; } = true;
}