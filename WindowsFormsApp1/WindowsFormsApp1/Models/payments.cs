using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Payment
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    // Reference to appointment
    public string AppointmentId { get; set; }

    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; } // "Credit Card", "Cash", "Insurance"
    public string Status { get; set; } // "Pending", "Completed", "Failed", "Refunded"
    public string TransactionId { get; set; }

    [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
    public DateTime PaymentDate { get; set; } = DateTime.Now;

    public BillingInfo BillingInfo { get; set; }
}

public class BillingInfo
{
    public string BillingName { get; set; }
    public string BillingAddress { get; set; }
    public string TaxId { get; set; }
}