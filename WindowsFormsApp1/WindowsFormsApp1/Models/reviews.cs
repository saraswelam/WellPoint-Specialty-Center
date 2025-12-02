using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace WindowsFormsApp1.Models
{
    public class Review
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("dr_id")]
        public string DoctorId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("patient_id")]
        public string PatientId { get; set; }

        [BsonElement("rating")]
        public int Rating { get; set; }

        [BsonElement("comment")]
        public string Comment { get; set; }
    }
}
