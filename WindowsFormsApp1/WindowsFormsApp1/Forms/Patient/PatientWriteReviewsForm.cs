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

            foreach (var appt in appts)
            {
                var apptId = appt["_id"].AsObjectId;

                //  skip if already reviewed
                bool reviewed = _reviewService.HasReviewForAppointment(apptId);
                if (reviewed) continue;

                var doctorId = appt["dr_id"].AsObjectId;
                var doctor = _doctorService.GetDoctorById(doctorId);
                if (doctor == null) continue;

                cmbAppointments.Items.Add(new AppointmentComboItem
                {
                    Text = $"{doctor.FirstName} {doctor.LastName} — {appt["app_date"]} at {appt["app_time"]}",
                    AppointmentId = apptId.ToString(),
                    DoctorId = doctor.Id
                });
            }

            if (cmbAppointments.Items.Count == 0)
            {
                MessageBox.Show("All completed appointments already have reviews.",
                                "Nothing to Review",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                cmbAppointments.SelectedIndex = 0;
            }
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
                appointmentId: selected.AppointmentId,
                doctorId: selected.DoctorId,
                patientId: _patient.Id,
                rating: rating,
                comment: comment
            );

            if (!success)
            {
                MessageBox.Show("You already reviewed this appointment.",
                                "Duplicate Review",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


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

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
