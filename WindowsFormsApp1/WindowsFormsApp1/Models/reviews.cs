using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Review
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("dr_id")]
    public string DoctorId { get; set; }

    [BsonElement("patient_id")]
    public string PatientId { get; set; }

    [BsonElement("rating")]
    public int Rating { get; set; }

    [BsonElement("comment")]
    public string Comment { get; set; }
}
