using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace WindowsFormsApp1.Models
{
    public class Payment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("app_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AppointmentId { get; set; }

        [BsonElement("amount")]
        public double Amount { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }

        [BsonElement("payment_date")]
        public string PaymentDate { get; set; }

        [BsonElement("method")]
        public string Method { get; set; }
    }
}
