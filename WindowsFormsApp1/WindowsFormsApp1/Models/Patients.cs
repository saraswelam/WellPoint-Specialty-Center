using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

public class Patient
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("user_id")]
    public string UserId { get; set; }

    [BsonElement("first_name")]
    public string FirstName { get; set; }

    [BsonElement("last_name")]
    public string LastName { get; set; }

    [BsonElement("age")]
    public int Age { get; set; }

    [BsonElement("gender")]
    public string Gender { get; set; }

    [BsonElement("appointment_id")]
    public string AppointmentId { get; set; }

    [BsonElement("medical_history")]
    public MedicalHistory MedicalHistory { get; set; }

    [BsonElement("insurance")]
    public Insurance Insurance { get; set; }

    [BsonElement("contact_info")]
    public ContactInfo ContactInfo { get; set; }
}


public class MedicalHistory
{
    [BsonElement("allergies")]
    public List<string> Allergies { get; set; }

    [BsonElement("past_surgeries")]
    public List<string> PastSurgeries { get; set; }

    [BsonElement("conditions")]
    public List<string> Conditions { get; set; }
}

public class Insurance
{
    [BsonElement("company")]
    public string Company { get; set; }

    [BsonElement("expiry_date")]
    public string ExpiryDate { get; set; }
}

public class ContactInfo
{
    [BsonElement("phone")]
    public string Phone { get; set; }

    [BsonElement("email")]
    public string Email { get; set; }

    [BsonElement("emergency_contact")]
    public string EmergencyContact { get; set; }

    [BsonElement("address")]
    public Address Address { get; set; }
}

public class Address
{
    [BsonElement("area")]
    public string Area { get; set; }

    [BsonElement("city")]
    public string City { get; set; }

    [BsonElement("street")]
    public string Street { get; set; }
}
