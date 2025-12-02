using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ClinicalBookingSystem.Services
{
   
    public class ReviewService
    {
        private readonly IMongoCollection<BsonDocument> _reviews;

        public ReviewService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("ClinicalBookingSystem");

            _reviews = db.GetCollection<BsonDocument>("reviews");
        }

        public bool AddReview(string doctorId, string patientId, int rating, string comment)
        {
            try
            {
                var docId = ObjectId.Parse(doctorId);
                var patId = ObjectId.Parse(patientId);

                BsonDocument review = new BsonDocument
            {
                { "doctor_id", docId },
                { "patient_id", patId },
                { "rating", rating },
                { "comment", comment ?? "" },
                { "created_at", DateTime.UtcNow.ToString("yyyy-MM-dd") }
            };

                _reviews.InsertOne(review);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<BsonDocument> GetReviewsForDoctor(string doctorId)
        {
            var docId = ObjectId.Parse(doctorId);

            return _reviews.Find(
                Builders<BsonDocument>.Filter.Eq("doctor_id", docId)
            ).ToList();
        }
    }

}
