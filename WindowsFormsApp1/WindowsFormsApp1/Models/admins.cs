using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

public class Admin
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Username { get; set; }
    public string Password { get; set; } // Should be hashed in real application
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; } // "SuperAdmin", "ClinicManager", "Staff"

    // Reference to clinic if managing specific clinic
    public string ClinicId { get; set; }

    public List<string> Permissions { get; set; } = new List<string>();

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}