
using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



// Fix namespace conflict
using DoctorModel = WindowsFormsApp1.Models.Doctor;

namespace WindowsFormsApp1.Forms.Patient
{
    public partial class ViewDrProfileForm : Form
    {
        private readonly DoctorModel _doctor;
        private readonly DoctorService _doctorService;
        private readonly AppointmentService _appointmentService;
        private readonly Models.Patient _patient;

        private string selectedDate = null;
        private string selectedTime = null;
        //private Models.Doctor doctor;



        public ViewDrProfileForm(DoctorModel doctor, Models.Patient patient)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _doctor = doctor;
            _patient = patient;       // ✅ save logged in patient
            _doctorService = new DoctorService();
            _appointmentService = new AppointmentService();
        }


        // ============================================================
        // FORM LOAD
        // ============================================================
        private void ViewDrProfileForm_Load(object sender, EventArgs e)
        {

            ReloadDoctorData();
            ApplyPalette();
            DisplayDoctorInfo();
            LoadRecentReviews();
            SetupBookingPanel();
        }

        // ============================================================
        // APPLY BLUE PALETTE
        // ============================================================
        private void ApplyPalette()
        {
            this.BackColor = Color.WhiteSmoke;
            panelHeader.BackColor = Color.FromArgb(52, 152, 219);
            lblHeader.ForeColor = Color.White;

            btnProceedPayment.BackColor = Color.FromArgb(41, 128, 185);
            btnProceedPayment.ForeColor = Color.White;
        }

        // ============================================================
        // FILL DOCTOR INFO
        // ============================================================
        private void DisplayDoctorInfo()
        {
            lblDrName.Text = $"{_doctor.FirstName} {_doctor.LastName}";
            lblSpecialization.Text = $"Specialization: {_doctor.Specialization}";
            lblCerts.Text = _doctor.Certification != null ?
                            string.Join(", ", _doctor.Certification) :
                            "No certifications listed";

            lblPhone.Text = $"Phone: {_doctor.PhoneNumber ?? "N/A"}";
            lblFee.Text = $"Consultation Fee: {_doctor.ConsultationFee ?? 0} EGP";

            // -----------------------------------
            // CLINIC + DEPARTMENT
            // -----------------------------------
            lblClinic.Text = "Clinic: N/A";
            lblDepartment.Text = "Department: N/A";

            if (!string.IsNullOrWhiteSpace(_doctor.ClinicId) &&
                ObjectId.TryParse(_doctor.ClinicId, out ObjectId clinicOid))
            {
                var clinic = _doctorService.GetClinicById(clinicOid);
                if (clinic != null)
                {
                    lblClinic.Text = $"Clinic: {clinic.ClinicName}";
                    if (clinic.Departments != null && clinic.Departments.Count > 0)
                        lblDepartment.Text = $"Department: {clinic.Departments[0].DepartmentName}";
                }
            }

            // -----------------------------------
            // DOCTOR AVERAGE RATING
            // -----------------------------------
            double rating = _doctorService.GetDoctorRating(_doctor.Id);
            lblRating.Text = rating <= 0 ? "Rating: No ratings yet" : $"Rating: {rating:F1}/5";
        }

        // ============================================================
        // LOAD LATEST REVIEWS
        // ============================================================
        private void LoadRecentReviews()
        {
            flpReviews.Controls.Clear();
            var reviews = _doctorService.GetRecentReviews(_doctor.Id, 2);

            if (reviews == null || reviews.Count == 0)
            {
                flpReviews.Controls.Add(new Label
                {
                    Text = "No reviews yet.",
                    ForeColor = Color.Gray,
                    AutoSize = true
                });
                return;
            }

            foreach (var r in reviews)
            {
                var card = new Panel
                {
                    Width = flpReviews.Width - 25,
                    Height = 70,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(4)
                };

                var lblR = new Label
                {
                    Text = $"Rating: {r.Rating}/5",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    Location = new Point(8, 8),
                    AutoSize = true
                };

                var lblComment = new Label
                {
                    Text = r.Comment,
                    Location = new Point(8, 30),
                    AutoSize = true,
                    MaximumSize = new Size(card.Width - 16, 0)
                };

                card.Controls.Add(lblR);
                card.Controls.Add(lblComment);
                flpReviews.Controls.Add(card);
            }
        }

        // ============================================================
        // BOOKING UI SETUP
        // ============================================================
        private void SetupBookingPanel()
        {
            monthCalendar.MinDate = DateTime.Today;
            monthCalendar.MaxSelectionCount = 1;

            monthCalendar.DateChanged += (s, e) =>
                RefreshTimeSlotsForDate(e.Start);

            RefreshTimeSlotsForDate(DateTime.Today);

            btnProceedPayment.Click += BtnProceedPayment_Click;
        }

        // ============================================================
        // REFRESH TIME SLOTS (RADIO BUTTONS)
        // ============================================================
        private void RefreshTimeSlotsForDate(DateTime date)
        {
            flpTimeSlots.Controls.Clear();
            selectedDate = null;
            selectedTime = null;

            string dateStr = date.ToString("yyyy-MM-dd");

            // No slots?
            if (_doctor.Slots == null)
            {
                flpTimeSlots.Controls.Add(new Label
                {
                    Text = "No available slots.",
                    ForeColor = Color.Gray,
                    AutoSize = true
                });
                return;
            }

            // Filter by date
            var slots = _doctor.Slots
                .Where(s => s.Date == dateStr && s.IsBooked == false)
                .OrderBy(s => s.Time)
                .ToList();

            if (slots.Count == 0)
            {
                flpTimeSlots.Controls.Add(new Label
                {
                    Text = "No available time slots for this day.",
                    ForeColor = Color.Gray,
                    AutoSize = true
                });
                return;
            }

            // Create full-date-time radio buttons
            foreach (var slot in slots)
            {
                DateTime dt = DateTime.Parse($"{slot.Date} {slot.Time}");

                var rb = new RadioButton
                {
                    AutoSize = true,
                    Tag = slot.Time,
                    Margin = new Padding(6),
                    Font = new Font("Segoe UI", 9),
                    Text = $"{dt:dddd, MMM dd  —  hh:mm tt}"
                };

                rb.CheckedChanged += (s, e) =>
                {
                    if (rb.Checked)
                    {
                        selectedDate = slot.Date;
                        selectedTime = slot.Time;
                    }
                };

                flpTimeSlots.Controls.Add(rb);
            }
        }

        // ============================================================
        // PROCEED TO PAYMENT
        // ============================================================
        private void BtnProceedPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(selectedDate) || string.IsNullOrWhiteSpace(selectedTime))
            {
                MessageBox.Show("Please select a date and time slot.",
                                "Missing Selection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string patientId = _patient.Id;
            if (patientId == null)
            {
                MessageBox.Show("Patient is not logged in.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Open payment form
            var paymentForm = new PaymentForm(
                patientId: patientId,
                doctorId: _doctor.Id,
                clinicId: _doctor.ClinicId,
                appointmentDate: selectedDate,
                appointmentTime: selectedTime,
                fee: _doctor.ConsultationFee ?? 0
            );

            paymentForm.ShowDialog();

            if (paymentForm.BookingSucceeded)
            {
                ReloadDoctorData();          // refresh doctor
                DisplayDoctorInfo();         // refresh labels
                LoadRecentReviews();         // refresh reviews
                RefreshTimeSlotsForDate(DateTime.Parse(selectedDate)); // refresh slots

                MessageBox.Show("Booking completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void ReloadDoctorData()
        {
            var oid = ObjectId.Parse(_doctor.Id);
            var updated = _doctorService.GetDoctorById(oid);

            if (updated == null)
                return;

            _doctor.FirstName = updated.FirstName;
            _doctor.LastName = updated.LastName;
            _doctor.PhoneNumber = updated.PhoneNumber;
            _doctor.Specialization = updated.Specialization;
            _doctor.Certification = updated.Certification;
            _doctor.ClinicId = updated.ClinicId;            // FIXED
            _doctor.ConsultationFee = updated.ConsultationFee;
            _doctor.Slots = updated.Slots;
        }


        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
