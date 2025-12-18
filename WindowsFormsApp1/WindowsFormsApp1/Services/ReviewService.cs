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

            public bool AddReview(string appointmentId, string doctorId, string patientId, int rating, string comment)
            {
                try
                {
                    var apptOid = ObjectId.Parse(appointmentId);
                    var docId = ObjectId.Parse(doctorId);
                    var patId = ObjectId.Parse(patientId);

                    // ❌ prevent duplicate review
                    var exists = _reviews.Find(
                        Builders<BsonDocument>.Filter.Eq("app_id", apptOid)
                    ).Any();

                    if (exists)
                        return false;

                    BsonDocument review = new BsonDocument
            {
                { "app_id", apptOid },
                { "dr_id", docId },
                { "patient_id", patId },
                { "rating", rating },
                { "comment", comment ?? "" },
                { "created_at", DateTime.UtcNow.ToString("yyyy-MM-dd") }
            };

                    _reviews.InsertOne(review);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public bool HasReviewForAppointment(ObjectId appointmentId)
            {
                return _reviews.Find(
                    Builders<BsonDocument>.Filter.Eq("app_id", appointmentId)
                ).Any();
            }

        }

    }
