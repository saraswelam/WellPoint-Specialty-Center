using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Admin
{
    public partial class GenerateReportsForm : Form
    {
        private readonly MongoDBService _db;

        public GenerateReportsForm()
        {
            InitializeComponent();
            _db = new MongoDBService();
        }
        
        // Utility: Convert aggregation results into DataTable for grid
        
        private DataTable ConvertToTable(List<BsonDocument> docs)
        {
            DataTable dt = new DataTable();

            if (docs.Count == 0)
                return dt;

            
            foreach (var element in docs[0].Elements)
                dt.Columns.Add(element.Name);

            
            foreach (var doc in docs)
            {
                DataRow row = dt.NewRow();
                foreach (var element in doc.Elements)
                    row[element.Name] = element.Value.ToString();
                dt.Rows.Add(row);
            }

            return dt;
        }

        //pipeline 1
        private void TotalRevenueButton_Click(object sender, EventArgs e)
        {
            var col = _db.GetCollection<BsonDocument>("payments");

            var pipeline = new[]
            {
                new BsonDocument("$match",
                    new BsonDocument("status", "completed")),

                new BsonDocument("$addFields",
                    new BsonDocument("paidAt",
                        new BsonDocument("$dateFromString",
                            new BsonDocument("dateString", "$payment_date")
                        ))),

                new BsonDocument("$group",
                    new BsonDocument
                    {
                        {
                            "_id", new BsonDocument
                            {
                                { "year", new BsonDocument("$year", "$paidAt") },
                                { "month", new BsonDocument("$month", "$paidAt") }
                            }
                        },
                        { "totalRevenue", new BsonDocument("$sum", "$amount") },
                        { "count", new BsonDocument("$sum", 1) }
                    }),

                new BsonDocument("$sort",
                    new BsonDocument
                    {
                        { "_id.year", -1 },
                        { "_id.month", -1 }
                    })
            };

            var results = col.Aggregate<BsonDocument>(pipeline).ToList();
            dataGridView.DataSource = ConvertToTable(results);
        }

        //pipeline 2
        private void MostBookedDoctorsButton_Click(object sender, EventArgs e)
        {
            var col = _db.GetCollection<BsonDocument>("appointments");

            var pipeline = new[]
            {
                new BsonDocument("$group",
                    new BsonDocument
                    {
                        { "_id", "$dr_id" },
                        { "count", new BsonDocument("$sum", 1) }
                    }),

                new BsonDocument("$sort", new BsonDocument("count", -1)),
                new BsonDocument("$limit", 5),

                new BsonDocument("$lookup",
                    new BsonDocument
                    {
                        { "from", "doctors" },
                        { "localField", "_id" },
                        { "foreignField", "_id" },
                        { "as", "doctor" }
                    }),

                new BsonDocument("$unwind", "$doctor"),

                new BsonDocument("$project",
                    new BsonDocument
                    {
                        {
                            "doctorName",
                            new BsonDocument("$concat",
                                new BsonArray { "$doctor.first_name", " ", "$doctor.last_name" })
                        },
                        { "count", 1 }
                    })
            };

            var results = col.Aggregate<BsonDocument>(pipeline).ToList();
            dataGridView.DataSource = ConvertToTable(results);
        }

        //pipeline 3
        private void AppointmentsPerClinicButton_Click(object sender, EventArgs e)
        {
            var col = _db.GetCollection<BsonDocument>("appointments");

            var pipeline = new[]
            {
                new BsonDocument("$group",
                    new BsonDocument
                    {
                        { "_id", "$clinic_id" },
                        { "totalAppointments", new BsonDocument("$sum", 1) }
                    }),

                new BsonDocument("$lookup",
                    new BsonDocument
                    {
                        { "from", "clinics" },
                        { "localField", "_id" },
                        { "foreignField", "_id" },
                        { "as", "clinic" }
                    }),

                new BsonDocument("$unwind", "$clinic"),

                new BsonDocument("$project",
                    new BsonDocument
                    {
                        { "clinicName", "$clinic.clinic_name" },
                        { "totalAppointments", 1 }
                    }),

                new BsonDocument("$sort", new BsonDocument("totalAppointments", -1))
            };

            var results = col.Aggregate<BsonDocument>(pipeline).ToList();
            dataGridView.DataSource = ConvertToTable(results);
        }

        //pipeline 4
        private void DoctorRatingsButton_Click(object sender, EventArgs e)
        {
            var col = _db.GetCollection<BsonDocument>("reviews");

            var pipeline = new[]
            {
                new BsonDocument("$group",
                    new BsonDocument
                    {
                        { "_id", "$dr_id" },
                        { "avgRating", new BsonDocument("$avg", "$rating") },
                        { "count", new BsonDocument("$sum", 1) }
                    }),

                new BsonDocument("$lookup",
                    new BsonDocument
                    {
                        { "from", "doctors" },
                        { "localField", "_id" },
                        { "foreignField", "_id" },
                        { "as", "doctor" }
                    }),

                new BsonDocument("$unwind", "$doctor"),

                new BsonDocument("$project",
                    new BsonDocument
                    {
                        {
                            "doctorName",
                            new BsonDocument("$concat",
                                new BsonArray { "$doctor.first_name", " ", "$doctor.last_name" })
                        },
                        { "avgRating", 1 },
                        { "count", 1 }
                    }),

                new BsonDocument("$sort", new BsonDocument("avgRating", -1))
            };

            var results = col.Aggregate<BsonDocument>(pipeline).ToList();
            dataGridView.DataSource = ConvertToTable(results);
        }

        //pipeline 5
        private void DoctorWorkloadButton_Click(object sender, EventArgs e)
        {
            var col = _db.GetCollection<BsonDocument>("appointments");

            var pipeline = new[]
            {
                new BsonDocument("$group",
                    new BsonDocument
                    {
                        {
                            "_id",
                            new BsonDocument
                            {
                                { "doctorId", "$dr_id" },
                                { "date", "$app_date" }
                            }
                        },
                        { "totalAppointments", new BsonDocument("$sum", 1) }
                    }),

                new BsonDocument("$lookup",
                    new BsonDocument
                    {
                        { "from", "doctors" },
                        { "localField", "_id.doctorId" },
                        { "foreignField", "_id" },
                        { "as", "doctor" }
                    }),

                new BsonDocument("$unwind", "$doctor"),

                new BsonDocument("$project",
                    new BsonDocument
                    {
                        {
                            "doctorName",
                            new BsonDocument("$concat",
                                new BsonArray { "$doctor.first_name", " ", "$doctor.last_name" })
                        },
                        { "date", "$_id.date" },
                        { "totalAppointments", 1 }
                    }),

                new BsonDocument("$sort", new BsonDocument("date", -1))
            };

            var results = col.Aggregate<BsonDocument>(pipeline).ToList();
            dataGridView.DataSource = ConvertToTable(results);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
