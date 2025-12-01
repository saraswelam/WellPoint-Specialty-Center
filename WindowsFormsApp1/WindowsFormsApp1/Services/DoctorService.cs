using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            _reviews = db.GetCollection<Review>("Reviews");
        }

        // ---------------------------
        // GET ALL DOCTORS
        // ---------------------------
        public List<Doctor> GetAllDoctors()
        {
            return _doctors.Find(_ => true).ToList();
        }

        // ---------------------------
        // GET SPECIALIZATION LIST
        // ---------------------------
        public List<string> GetSpecializations()
        {
            return _doctors.AsQueryable()
                .Select(d => d.Specialization)
                .Distinct()
                .OrderBy(s => s)
                .ToList();
        }

        // ---------------------------
        // GET CLINICS LIST
        // ---------------------------
        public List<Clinic> GetClinics()
        {
            return _clinics.Find(_ => true).ToList();
        }

        // ---------------------------
        // GET DEPARTMENTS (FROM CLINICS)
        // ---------------------------
        public List<string> GetDepartments()
        {
            var clinics = _clinics.Find(_ => true).ToList();

            return clinics
                .SelectMany(c => c.Departments.Select(d => d.DepartmentName))
                .Distinct()
                .OrderBy(s => s)
                .ToList();
        }


        public double GetDoctorRating(string doctorId)
        {
            var reviews = _reviews.Find(r => r.DoctorId == doctorId).ToList();

            if (reviews.Count == 0)
                return 0;

            return reviews.Average(r => r.Rating);
        }



        // ---------------------------
        // SEARCH + FILTERS
        // ---------------------------
        public List<Doctor> SearchDoctors(string search, string specialization, string clinicId)
        {
            var filter = Builders<Doctor>.Filter.Empty;

            if (!string.IsNullOrWhiteSpace(search))
                filter &= Builders<Doctor>.Filter.Regex("first_name", new BsonRegularExpression(search, "i"))
                       | Builders<Doctor>.Filter.Regex("last_name", new BsonRegularExpression(search, "i"));

            if (specialization != "All")
                filter &= Builders<Doctor>.Filter.Eq("specialization", specialization);

            if (clinicId != "All")
                filter &= Builders<Doctor>.Filter.Eq("clinic_id", clinicId);

            return _doctors.Find(filter).ToList();
        }

    }
}
