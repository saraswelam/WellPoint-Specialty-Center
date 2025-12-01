// Forms/Patient/PaymentForm.cs
using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    public partial class PaymentForm : Form
    {
        private readonly AppointmentService _appointmentService;

        private readonly string _patientId;
        private readonly string _doctorId;
        private readonly string _clinicId;
        private readonly string _appointmentDate;
        private readonly string _appointmentTime;
        private readonly double _fee;

        public bool BookingSucceeded { get; private set; } = false;

        public PaymentForm(string patientId, string doctorId, string clinicId, string appointmentDate, string appointmentTime, double fee)
        {
            InitializeComponent();
            _appointmentService = new AppointmentService();

            _patientId = patientId;
            _doctorId = doctorId;
            _clinicId = clinicId;
            _appointmentDate = appointmentDate;
            _appointmentTime = appointmentTime;
            _fee = fee;

            // Fill UI
            lblDoctor.Text = $"Doctor: {GetDoctorDisplayName()}";
            lblAppt.Text = $"When: {_appointmentDate} at {_appointmentTime}";
            lblFee.Text = $"Amount: {_fee:F0} EGP";
        }

        private string GetDoctorDisplayName()
        {
            // Basic: if you need full doctor object, call DoctorService
            var ds = new DoctorService();
            var doc = ds.GetAllDoctors().Find(d => d.Id == _doctorId);
            return doc != null ? $"{doc.FirstName} {doc.LastName}" : "Doctor";
        }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            // Basic validation (if card selected, check fields)
            var method = cmbMethod.SelectedItem?.ToString() ?? "cash";
            // For demo, we won't process card; we just create the appointment+payment record (status pending/completed).
            var success = _appointmentService.BookAppointment(_patientId, _doctorId, _clinicId, _appointmentDate, _appointmentTime, _fee, method, out ObjectId apptId, out string error);

            if (!success)
            {
                MessageBox.Show($"Booking failed: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BookingSucceeded = false;
                return;
            }

            // Optionally mark payment status completed if cash or simulated card
            MessageBox.Show("Appointment booked. Payment recorded (status pending/completed depending on method).", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BookingSucceeded = true;
            this.Close();
        }
    }
}
