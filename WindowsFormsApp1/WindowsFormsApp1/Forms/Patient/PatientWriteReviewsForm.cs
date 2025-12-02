using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    public partial class PatientWriteReviewsForm : Form
    {
        private readonly Models.Patient _patient;
        private readonly AppointmentService _appointmentService;
        private readonly DoctorService _doctorService;
        private readonly ReviewService _reviewService;

        public PatientWriteReviewsForm(Models.Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            _appointmentService = new AppointmentService();
            _doctorService = new DoctorService();
            _reviewService = new ReviewService();
            this.WindowState = FormWindowState.Maximized;
        }

        private void PatientWriteReviewsForm_Load(object sender, EventArgs e)
        {
            LoadCompletedAppointments();
        }

        private void LoadCompletedAppointments()
        {
            cmbDoctors.Items.Clear();

            var appts = _appointmentService.GetCompletedAppointmentsByPatient(_patient.Id);

            foreach (var a in appts)
            {
                // Extract doctor id from BsonDocument
                ObjectId doctorId = a["dr_id"].AsObjectId;

                var doc = _doctorService.GetDoctorById(doctorId);

                if (doc == null) continue;

                cmbDoctors.Items.Add(new ComboItem
                {
                    Text = $"{doc.FirstName} {doc.LastName}",
                    Value = doc.Id
                });
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbDoctors.SelectedIndex == -1)
            {
                MessageBox.Show("Select a doctor.");
                return;
            }

            int rating = (int)numRating.Value;

            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Rating must be 1–5.");
                return;
            }

            var selectedDoc = (ComboItem)cmbDoctors.SelectedItem;

            bool success = _reviewService.AddReview(
                doctorId: selectedDoc.Value,
                patientId: _patient.Id,
                rating: rating,
                comment: txtReview.Text
            );

            if (success)
                MessageBox.Show("Review submitted!");
        }

        public class ComboItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;
        }

        private void PatientWriteReviewsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
