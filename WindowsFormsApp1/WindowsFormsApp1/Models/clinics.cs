using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Clinic
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("clinic_name")]
    public string ClinicName { get; set; }

    [BsonElement("working_hours")]
    public string WorkingHours { get; set; }

    [BsonElement("department")]
    public Department Department { get; set; }

    [BsonElement("clinic_info")]
    public ClinicInfo ClinicInfo { get; set; }
}

public class Department
{
    [BsonElement("dep_name")]
    public string DepartmentName { get; set; }

    [BsonElement("description")]
    public string Description { get; set; }
}

public class ClinicInfo
{
    [BsonElement("phone")]
    public string Phone { get; set; }

    [BsonElement("location")]
    public string Location { get; set; }

    [BsonElement("email")]
    public string Email { get; set; }
}
