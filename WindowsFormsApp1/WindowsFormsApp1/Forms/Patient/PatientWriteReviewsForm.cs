using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
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
            this.BackColor = Color.WhiteSmoke;
        }

        
        private void PatientWriteReviewsForm_Load(object sender, EventArgs e)
        {
            LoadCompletedAppointments();
        }

        
        private void LoadCompletedAppointments()
        {
            cmbAppointments.Items.Clear();

            var appts = _appointmentService.GetCompletedAppointmentsByPatient(_patient.Id);

            if (appts == null || appts.Count == 0)
            {
                MessageBox.Show(
                    "You have no completed appointments to review.",
                    "No Completed Appointments",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            foreach (var appt in appts)
            {
                var doctorId = appt["dr_id"].AsObjectId;
                var doctor = _doctorService.GetDoctorById(doctorId);
                if (doctor == null) continue;

                string text = $"{doctor.FirstName} {doctor.LastName} — {appt["app_date"]} at {appt["app_time"]}";

                cmbAppointments.Items.Add(new AppointmentComboItem
                {
                    Text = text,
                    AppointmentId = appt["_id"].ToString(),
                    DoctorId = doctor.Id
                });
            }

            if (cmbAppointments.Items.Count > 0)
                cmbAppointments.SelectedIndex = 0;
        }

        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbAppointments.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an appointment to review.");
                return;
            }

            var selected = (AppointmentComboItem)cmbAppointments.SelectedItem;
            int rating = (int)numRating.Value;
            string comment = txtReview.Text?.Trim() ?? "";

            if (rating < 1 || rating > 5)
            {
                MessageBox.Show("Rating must be between 1 and 5.");
                return;
            }

            bool success = _reviewService.AddReview(
                doctorId: selected.DoctorId,
                patientId: _patient.Id,
                rating: rating,
                comment: comment);

            if (success)
            {
                MessageBox.Show("Thank you! Your review has been submitted.",
                                "Review Submitted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Could not save your review. Please try again.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private class AppointmentComboItem
        {
            public string Text { get; set; }
            public string AppointmentId { get; set; }
            public string DoctorId { get; set; }

            public override string ToString() => Text;
        }
    }
}
