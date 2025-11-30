using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace ClinicalBookingApp.Models // <--- REMOVED .Models
{
    public class Patient
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; }

        [BsonElement("contact")]
        public ContactInfo Contact { get; set; }

        [BsonElement("insurance")]
        public InsuranceInfo Insurance { get; set; }

        [BsonElement("medicalHistory")]
        public List<MedicalRecord> MedicalHistory { get; set; }
    }

    public class ContactInfo
    {
        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }
    }

    public class InsuranceInfo
    {
        [BsonElement("provider")]
        public string Provider { get; set; }

        [BsonElement("policyNumber")]
        public string PolicyNumber { get; set; }
    }

    public class MedicalRecord 
    {
        public string Details { get; set; }
    }
}