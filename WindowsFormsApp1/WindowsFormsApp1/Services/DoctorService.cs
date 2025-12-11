using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Models;

namespace ClinicalBookingSystem.Services
{
    public class DoctorService
    {
        private readonly IMongoCollection<Doctor> _doctors;
        private readonly IMongoCollection<Clinic> _clinics;
        private readonly IMongoCollection<Review> _reviews;

        public DoctorService()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("ClinicalBookingSystem");

            _doctors = db.GetCollection<Doctor>("doctors");
            _clinics = db.GetCollection<Clinic>("clinics");
           
            _reviews = db.GetCollection<Review>("reviews");
        }

        public List<Doctor> GetAllDoctors()
        {
            return _doctors.Find(_ => true).ToList();
        }

        public Doctor GetDoctorById(ObjectId doctorId)
        {
            return _doctors.Find(d => d.Id == doctorId.ToString() || d.Id == doctorId.ToString()).FirstOrDefault();
        }


        
        public List<string> GetSpecializations()
        {
            return _doctors.AsQueryable()
                .Select(d => d.Specialization)
                .Where(s => s != null)
                .Distinct()
                .OrderBy(s => s)
                .ToList();
        }

       
        public List<Clinic> GetClinics()
        {
            return _clinics.Find(_ => true).ToList();
        }

       
        public Clinic GetClinicById(ObjectId id)
        {
            return _clinics.Find(c => c.Id == id.ToString() || c.Id == id.ToString()).FirstOrDefault();
          
        }

       
        public List<string> GetDepartments()
        {
            var clinics = GetClinics();
            return clinics
                .SelectMany(c => c.Departments ?? new List<Department>())
                .Select(d => d.DepartmentName)
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .Distinct()
                .OrderBy(n => n)
                .ToList();
        }

        public double GetDoctorRating(string doctorId)
        {
            if (!ObjectId.TryParse(doctorId, out ObjectId oid))
                return 0;

            var reviews = _reviews.Find(r => r.DoctorId == doctorId).ToList();


            if (reviews.Count == 0)
                return 0;

            return reviews.Average(r => r.Rating);
        }

        public List<Review> GetRecentReviews(string doctorId, int take = 2)
        {
            if (string.IsNullOrWhiteSpace(doctorId)) return new List<Review>();
            var filter = Builders<Review>.Filter.Eq("dr_id", ObjectId.Parse(doctorId));
            return _reviews.Find(filter).SortByDescending(r => r.Id).Limit(take).ToList();
        }

        public List<Doctor> SearchDoctors(string search, string specialization, string clinicId)
        {
            var builder = Builders<Doctor>.Filter;
            var filter = builder.Empty;

            if (!string.IsNullOrWhiteSpace(search))
            {
                var regex = new BsonRegularExpression(search, "i");
                var nameFilter = builder.Or(
                    builder.Regex("first_name", regex),
                    builder.Regex("last_name", regex)
                );
                filter &= nameFilter;
            }

            // specialization
            if (!string.IsNullOrWhiteSpace(specialization) && specialization != "All")
                filter &= builder.Eq("specialization", specialization);

            if (!string.IsNullOrWhiteSpace(clinicId) && clinicId != "All")
            {
                ObjectId clinicOid;
                if (ObjectId.TryParse(clinicId, out clinicOid))
                {
                    filter &= builder.Eq("clinic_id", clinicOid);
                }
                else
                {
                    filter &= builder.Eq("clinic_id", clinicId);
                }
            }

            return _doctors.Find(filter).ToList();
        }
    }
}
