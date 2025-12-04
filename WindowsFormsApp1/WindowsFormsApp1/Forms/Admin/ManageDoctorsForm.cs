
using ClinicalBookingSystem.Services;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms.Admin
{
    public partial class ManageDoctorsForm : Form
    {
        private readonly MongoDBService _db;

        public ManageDoctorsForm()
        {
            InitializeComponent();
            _db = new MongoDBService();

            LoadDoctors();
            LoadSpecializations();
        }

      
        private void LoadDoctors()
        {
            var doctorsCollection = _db.GetCollection<WindowsFormsApp1.Models.Doctor>("doctors");
            var usersCollection = _db.GetCollection<User>("users");

            var doctors = doctorsCollection.AsQueryable().ToList();

            var result = doctors
                .Select(d =>
                {
                    var user = usersCollection.Find(u => u.Id == d.UserId).FirstOrDefault();

                    return new
                    {
                        d.Id,
                        d.FirstName,
                        d.LastName,
                        Email = user?.Email ?? "(no email)",
                        Phone = d.PhoneNumber,
                        d.Specialization,
                        ConsultationFee = d.ConsultationFee ?? 0,
                        Certifications = d.Certification != null ? string.Join(", ", d.Certification) : "",
                        ClinicId = d.ClinicId
                    };
                })
                .ToList();

            dataGridView1.DataSource = result;
        }

    
        private void LoadSpecializations()
        {
            var specs = _db.GetCollection<WindowsFormsApp1.Models.Doctor>("doctors")
                           .AsQueryable()
                           .Select(d => d.Specialization)
                           .Distinct()
                           .Where(s => s != null)
                           .ToList();

            FilterSpecializationComboBox.Items.Clear();
            FilterSpecializationComboBox.Items.Add("All");
            FilterSpecializationComboBox.Items.AddRange(specs.ToArray());
            FilterSpecializationComboBox.SelectedIndex = 0;
        }

        // -------------------------------------------------------------
        // SEARCH BAR
        // -------------------------------------------------------------
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // -------------------------------------------------------------
        // SPECIALIZATION FILTER
        // -------------------------------------------------------------
        private void FilterSpecializationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        // -------------------------------------------------------------
        // APPLY SEARCH + FILTERS
        // (MATCHES MODEL)
        // -------------------------------------------------------------
        private void ApplyFilters()
        {
            string search = SearchTextBox.Text.Trim().ToLower();
            string spec = FilterSpecializationComboBox.SelectedItem?.ToString();

            var doctorsCollection = _db.GetCollection<WindowsFormsApp1.Models.Doctor>("doctors");
            var usersCollection = _db.GetCollection<User>("users");

            var doctors = doctorsCollection.AsQueryable().ToList();

            var filtered = doctors
                .Where(d =>
                    (string.IsNullOrEmpty(search) ||
                     d.FirstName.ToLower().Contains(search) ||
                     d.LastName.ToLower().Contains(search)) &&
                    (spec == "All" || d.Specialization == spec)
                )
                .Select(d =>
                {
                    var user = usersCollection.Find(u => u.Id == d.UserId).FirstOrDefault();

                    return new
                    {
                        d.Id,
                        d.FirstName,
                        d.LastName,
                        Email = user?.Email ?? "(no email)",
                        Phone = d.PhoneNumber,
                        d.Specialization,
                        ConsultationFee = d.ConsultationFee ?? 0,
                        Certifications = d.Certification != null ? string.Join(", ", d.Certification) : "",
                        ClinicId = d.ClinicId
                    };
                })
                .ToList();

            dataGridView1.DataSource = filtered;
        }

        // -------------------------------------------------------------
        // GET SELECTED DOCTOR ID
        // -------------------------------------------------------------
        private bool TryGetSelectedDoctorId(out string doctorId)
        {
            doctorId = null;

            if (dataGridView1.SelectedRows.Count == 0)
                return false;

            doctorId = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
            return true;
        }

        // -------------------------------------------------------------
        // ADD DOCTOR
        // -------------------------------------------------------------
        private void AddDoctorButton_Click(object sender, EventArgs e)
        {
            AddDoctorForm form = new AddDoctorForm();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadDoctors();
                LoadSpecializations();
            }
        }

        // -------------------------------------------------------------
        // EDIT DOCTOR
        // -------------------------------------------------------------
        private void EditDoctorButton_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedDoctorId(out string doctorId))
            {
                MessageBox.Show("Please select a doctor first.");
                return;
            }

            EditDoctorForm form = new EditDoctorForm(doctorId);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadDoctors();
                LoadSpecializations();
            }
        }

        // -------------------------------------------------------------
        // DELETE DOCTOR (MATCHES MODEL)
        // -------------------------------------------------------------
        private void DeleteDoctorButton_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedDoctorId(out string doctorId))
            {
                MessageBox.Show("Please select a doctor to delete.");
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this doctor?\nThis will remove their linked user and appointments.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            var doctors = _db.GetCollection<WindowsFormsApp1.Models.Doctor>("doctors");
            var doctor = doctors.Find(d => d.Id == doctorId).FirstOrDefault();

            if (doctor == null)
            {
                MessageBox.Show("Doctor not found.");
                return;
            }

            doctors.DeleteOne(d => d.Id == doctorId);

            var users = _db.GetCollection<User>("users");
            users.DeleteOne(u => u.Id == doctor.UserId);

            var appts = _db.GetCollection<Appointment>("appointments");
            appts.DeleteMany(a => a.DoctorId == doctorId);

            MessageBox.Show("Doctor deleted successfully.");

            LoadDoctors();
            LoadSpecializations();
        }

        // -------------------------------------------------------------
        // UNUSED
        // -------------------------------------------------------------
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void BottomPanel_Paint(object sender, PaintEventArgs e) { }
        private void MainContentPanel_Paint(object sender, PaintEventArgs e) { }
        private void TopPanel_Paint(object sender, PaintEventArgs e) { }
        private void FilterLabel_Click(object sender, EventArgs e) { }
        private void SearchLabel_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
