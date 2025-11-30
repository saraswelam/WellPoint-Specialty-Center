using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Review
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    // References
    public string DoctorId { get; set; }
    public string PatientId { get; set; }
    public string AppointmentId { get; set; }

    public int Rating { get; set; } // 1-5
    public string Comment { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime ReviewDate { get; set; } = DateTime.Now;

    public bool IsApproved { get; set; } = true;
}