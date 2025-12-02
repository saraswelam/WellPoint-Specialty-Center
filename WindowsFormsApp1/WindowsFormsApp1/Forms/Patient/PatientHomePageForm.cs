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
    public partial class PatientHomePageForm : Form
    {
        private readonly DoctorService _doctorService;
        private readonly Models.Patient _patient;

        public PatientHomePageForm(Models.Patient patient)
        {
            InitializeComponent();
            _doctorService = new DoctorService();
            _patient = patient;
            this.WindowState = FormWindowState.Maximized;
        }

        private void PatientHomePageForm_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txtSearch, "Search doctors...");

            LoadFilters();
            LoadDoctors();

            // Filters
            cmbSpecialization.SelectedIndexChanged += (s, a) => LoadDoctors();
            cmbClinic.SelectedIndexChanged += (s, a) => LoadDoctors();
            txtSearch.TextChanged += (s, a) => LoadDoctors();
        }

        // ---------------------------------------------------------
        // PLACEHOLDER TEXT
        // ---------------------------------------------------------
        private void SetPlaceholder(TextBox box, string text)
        {
            box.Text = text;
            box.ForeColor = Color.Gray;

            box.GotFocus += (s, e) =>
            {
                if (box.Text == text)
                {
                    box.Text = "";
                    box.ForeColor = Color.Black;
                }
            };

            box.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    box.Text = text;
                    box.ForeColor = Color.Gray;
                }
            };
        }

        // ---------------------------------------------------------
        // LOAD FILTERS
        // ---------------------------------------------------------
        private void LoadFilters()
        {
            // ---- Specializations ----
            var specializations = _doctorService.GetSpecializations();
            cmbSpecialization.Items.Clear();
            cmbSpecialization.Items.Add("All");
            cmbSpecialization.Items.AddRange(specializations.ToArray());
            cmbSpecialization.SelectedIndex = 0;

            // ---- Clinics ----
            var clinics = _doctorService.GetClinics();
            cmbClinic.Items.Clear();
            cmbClinic.Items.Add("All");

            foreach (var c in clinics)
                cmbClinic.Items.Add(new ComboboxItem { Text = c.ClinicName, Value = c.Id });

            cmbClinic.SelectedIndex = 0;
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }
            public override string ToString() => Text;
        }

        // ---------------------------------------------------------
        // LOAD DOCTORS (APPLY FILTERS)
        // ---------------------------------------------------------
        private void LoadDoctors()
        {
            panelDoctorsList.Controls.Clear();

            string search = txtSearch.Text == "Search doctors..." ? "" : txtSearch.Text;

            string specialization = cmbSpecialization.SelectedItem?.ToString() ?? "All";

            string clinicId = (cmbClinic.SelectedItem is ComboboxItem item)
                              ? item.Value
                              : "All";

            // Query doctors
            var doctors = _doctorService.SearchDoctors(search, specialization, clinicId);

            foreach (var doctor in doctors)
                panelDoctorsList.Controls.Add(CreateDoctorCard(doctor));
        }

        // ---------------------------------------------------------
        // CREATE DOCTOR CARD  — includes average rating
        // ---------------------------------------------------------
        private Panel CreateDoctorCard(DoctorModel doctor)
        {
            Panel card = new Panel()
            {
                Width = 350,
                Height = 150,
                Margin = new Padding(20),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15)
            };

            card.BackColor = Color.FromArgb(245, 247, 250);
            card.BorderStyle = BorderStyle.None;

            // Shadow-like border
            card.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid,
                    Color.LightGray, 1, ButtonBorderStyle.Solid);
            };

            Label lblName = new Label()
            {
                Text = $"{doctor.FirstName} {doctor.LastName}",
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true,
                ForeColor = Color.FromArgb(30, 30, 30)
            };

            // Department
            string departmentText = "Department: N/A";
            if (!string.IsNullOrWhiteSpace(doctor.ClinicId) &&
                ObjectId.TryParse(doctor.ClinicId, out ObjectId clinicOid))
            {
                var clinic = _doctorService.GetClinicById(clinicOid);
                if (clinic != null && clinic.Departments?.Any() == true)
                {
                    departmentText = $"Department: {clinic.Departments[0].DepartmentName}";
                }
            }

            Label lblDept = new Label()
            {
                Text = departmentText,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(10, 45),
                AutoSize = true,
                ForeColor = Color.FromArgb(80, 80, 80)
            };

            // Rating
            double rating = _doctorService.GetDoctorRating(doctor.Id);
            string ratingText = rating <= 0 ? "Rating: No ratings yet" : $"Rating: ⭐ {rating:F1}/5";

            Label lblRating = new Label()
            {
                Text = ratingText,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(10, 70),
                AutoSize = true,
                ForeColor = Color.FromArgb(90, 90, 90)
            };

            // VIEW PROFILE BUTTON
            Button btnView = new Button()
            {
                Text = "View Profile",
                Location = new Point(10, 100),
                Width = 120,
                Height = 32,
                BackColor = Color.FromArgb(52, 152, 219),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnView.FlatAppearance.BorderSize = 0;

            btnView.Click += (s, e) =>
            {
                ViewDrProfileForm profileForm = new ViewDrProfileForm(doctor , _patient);
                profileForm.ShowDialog();
            };

            // Add controls
            card.Controls.Add(lblName);
            card.Controls.Add(lblDept);
            card.Controls.Add(lblRating);
            card.Controls.Add(btnView);

            return card;
        }


        private void panelDoctorsList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFilters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDoctorsList_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            var f = new PatientAppointmentsForm(_patient);
            f.ShowDialog();
        }

        private void btnWriteReview_Click(object sender, EventArgs e)
        {
            var f = new PatientWriteReviewsForm(_patient);
            f.ShowDialog();
        }

        
    }

}

