using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicalBookingSystem
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Connect to MongoDB
                var client = new MongoClient("mongodb://localhost:27017"); // change if using Atlas
                var database = client.GetDatabase("ClinicalBookingSystem");         // database name
                var collection = database.GetCollection<BsonDocument>("payments"); // collection name

                // 2. Create the document
                var document = new BsonDocument
                {

                    

                    { "appointmentId", ObjectId.GenerateNewId() },

                    { "amount", 505 },
                    { "currency", "USD" },
                    { "method", "card" },
                    { "status", "paid" },
                    { "paidAt", DateTime.Parse("2025-11-30T12:20:55.148Z").ToUniversalTime() }
                };
                collection.InsertOne(document);

                MessageBox.Show("Inserted document:\n\n" + document.ToJson(), "Success");

                // 4. Notify user
                MessageBox.Show("Payment document inserted successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}