using ClinicalBookingSystem.Services;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms.Admin
{
    public partial class AllAppointmentsForm : Form
    {
        private readonly MongoDBService _db;

        public AllAppointmentsForm()
        {
            InitializeComponent();
            _db = new MongoDBService();

            LoadStatusFilter();
            LoadAppointments();
        }

        
        private void LoadStatusFilter()
        {
            FilterComboBox.Items.Clear();
            FilterComboBox.Items.Add("All");
            FilterComboBox.Items.Add("scheduled");
            FilterComboBox.Items.Add("confirmed");
            FilterComboBox.Items.Add("completed");
            FilterComboBox.Items.Add("cancelled");

            FilterComboBox.SelectedIndex = 0;
        }

       
        private void LoadAppointments()
        {
            ApplyFilters();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        
        private void ApplyFilters()
        {
            var apptCol = _db.GetCollection<Appointment>("appointments");
            var doctorCol = _db.GetCollection<WindowsFormsApp1.Models.Doctor>("doctors");
            var userCol = _db.GetCollection<User>("users");
            var patientCol = _db.GetCollection<WindowsFormsApp1.Models.Patient>("patients");
            var clinicCol = _db.GetCollection<Clinic>("clinics");

            string search = SearchTextBox.Text.Trim().ToLower();
            string status = FilterComboBox.SelectedItem?.ToString() ?? "All";

            var appts = apptCol.Find(_ => true).ToList();

            var full = appts.Select(a =>
            {
                var doctor = doctorCol.Find(d => d.Id == a.DoctorId).FirstOrDefault();
                var patient = patientCol.Find(p => p.Id == a.PatientId).FirstOrDefault();
                var clinic = clinicCol.Find(c => c.Id == a.ClinicId).FirstOrDefault();

                return new
                {
                    a.Id,
                    Doctor = doctor != null ? $"{doctor.FirstName} {doctor.LastName}" : "(Unknown)",
                    Patient = patient != null ? $"{patient.FirstName} {patient.LastName}" : "(Unknown)",
                    a.AppointmentDate,
                    a.AppointmentTime,
                    a.Status,
                    Clinic = clinic?.ClinicName ?? "(Unknown)"
                };
            }).ToList();

            
            if (!string.IsNullOrEmpty(search))
            {
                full = full.Where(a =>
                    a.Doctor.ToLower().Contains(search) ||
                    a.Patient.ToLower().Contains(search)
                ).ToList();
            }

            
            if (status != "All")
            {
                full = full.Where(a => a.Status == status).ToList();
            }

            AppointmentsGrid.DataSource = full;
        }
    }
}
