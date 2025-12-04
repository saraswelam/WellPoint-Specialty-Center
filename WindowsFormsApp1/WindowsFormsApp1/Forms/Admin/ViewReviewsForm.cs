using ClinicalBookingSystem.Services;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms.Admin
{
    public partial class ViewReviewsForm : Form
    {
        private readonly MongoDBService _db;

        public ViewReviewsForm()
        {
            InitializeComponent();
            _db = new MongoDBService();
        }

        private void ViewReviewsForm_Load(object sender, EventArgs e)
        {
            LoadReviews();
        }

        private void LoadReviews()
        {
            try
            {
                var reviews = _db.GetCollection<Review>("reviews")
                                 .AsQueryable()
                                 .Select(r => new
                                 {
                                     r.Id,
                                     r.DoctorId,
                                     r.PatientId,
                                     r.Rating,
                                     r.Comment
                                 })
                                 .ToList();

                ReviewsGrid.DataSource = reviews;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load reviews: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void ReviewsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
