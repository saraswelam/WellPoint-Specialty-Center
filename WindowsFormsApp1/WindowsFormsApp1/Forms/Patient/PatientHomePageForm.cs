using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// Fix namespace conflict
using DoctorModel = Doctor;

namespace WindowsFormsApp1.Forms.Patient
{
    public partial class PatientHomePageForm : Form
    {
        private readonly DoctorService _doctorService;

        public PatientHomePageForm()
        {
            InitializeComponent();
            _doctorService = new DoctorService();
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
                Width = 300,
                Height = 160,
                Margin = new Padding(10),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblName = new Label()
            {
                Text = $"{doctor.FirstName} {doctor.LastName}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // get clinic department (first one) safely
            string departmentText = "Department: N/A";
            if (!string.IsNullOrWhiteSpace(doctor.ClinicId))
            {
                ObjectId clinicOid;
                if (ObjectId.TryParse(doctor.ClinicId, out clinicOid))
                {
                    var clinic = _doctorService.GetClinicById(clinicOid);
                    if (clinic != null && clinic.Departments != null && clinic.Departments.Count > 0)
                    {
                        departmentText = $"Department: {clinic.Departments[0].DepartmentName}";
                    }
                }
            }
            Label lblDept = new Label()
            {
                Text = departmentText,
                Location = new Point(10, 40),
                AutoSize = true
            };

            // rating
            double rating = _doctorService.GetDoctorRating(doctor.Id);
            string ratingText = rating <= 0 ? "Rating: No ratings yet" : $"Rating: {rating:F1}/5";
            Label lblRating = new Label()
            {
                Text = ratingText,
                Location = new Point(10, 65),
                AutoSize = true
            };

            Label lblFee = new Label()
            {
                Text = $"Consultation Fee: {doctor.ConsultationFee ?? 0} EGP",
                Location = new Point(10, 90),
                AutoSize = true
            };

            Button btnView = new Button()
            {
                Text = "View Profile",
                Location = new Point(10, 115),
                Width = 120
            };

            btnView.Click += (s, e) =>
            {
                ViewDrProfileForm profileForm = new ViewDrProfileForm(doctor);
                profileForm.ShowDialog();
            };

            card.Controls.Add(lblName);
            card.Controls.Add(lblDept);
            card.Controls.Add(lblRating);
            card.Controls.Add(lblFee);
            card.Controls.Add(btnView);

            return card;
        }

        private void panelDoctorsList_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

