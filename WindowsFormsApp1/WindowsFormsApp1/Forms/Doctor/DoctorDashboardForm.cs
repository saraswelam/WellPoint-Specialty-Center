using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
// MongoDB Namespaces
using MongoDB.Bson;
using MongoDB.Driver;
// Import your Service Namespace
using ClinicalBookingSystem.Services;

namespace WindowsFormsApp1.Forms.Doctor
{
    public partial class DoctorDashboardForm : Form
    {
        private Models.Doctor _currentDoctor;
        private MongoDBService _dbService;

        // UI Controls
        private Button btnProfile;
        private DataGridView dgvAppointments;
        private Label lblTitle;

        public DoctorDashboardForm(Models.Doctor doctor)
        {
            InitializeComponent();
            _currentDoctor = doctor;
            _dbService = new MongoDBService();

            SetupCustomUI();
            LoadAppointmentsFromMongoDB();
        }

        private void SetupCustomUI()
        {
            // 1. Form Settings
            this.Text = "Doctor Homepage";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            // 2. Profile Button (Top Left)
            btnProfile = new Button();

            // --- FEATURE 1: Set Initials and Colors ---
            string firstLetter = "";
            if (!string.IsNullOrEmpty(_currentDoctor.FirstName))
            {
                firstLetter = _currentDoctor.FirstName.Substring(0, 1).ToUpper();
            }

            btnProfile.Text = firstLetter;
            btnProfile.Font = new Font("Arial", 22, FontStyle.Bold); // Big font for the letter
            btnProfile.ForeColor = Color.White;                      // White text
            btnProfile.BackColor = Color.SteelBlue;                  // Nice Blue Background
            // ------------------------------------------

            btnProfile.Size = new Size(60, 60);
            btnProfile.Location = new Point(30, 30);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.FlatAppearance.BorderSize = 0; // Remove border for cleaner look

            // Make it circular
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnProfile.Width, btnProfile.Height);
            btnProfile.Region = new Region(path);

            btnProfile.Click += BtnProfile_Click;
            this.Controls.Add(btnProfile);

            // 3. Welcome Title
            lblTitle = new Label();
            lblTitle.Text = $"Welcome, Dr. {_currentDoctor.FirstName} {_currentDoctor.LastName}";
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(110, 45);
            this.Controls.Add(lblTitle);

            // 4. Gadwal (DataGridView)
            dgvAppointments = new DataGridView();
            dgvAppointments.Size = new Size(700, 350);

            int x = (this.ClientSize.Width - dgvAppointments.Width) / 2;
            int y = (this.ClientSize.Height - dgvAppointments.Height) / 2 + 40;
            dgvAppointments.Location = new Point(x, y);

            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.BorderStyle = BorderStyle.None;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvAppointments.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);

            this.Controls.Add(dgvAppointments);
        }

        private void LoadAppointmentsFromMongoDB()
        {
            try
            {
                var appointmentsCollection = _dbService.GetCollection<BsonDocument>("appointments");
                var patientsCollection = _dbService.GetCollection<BsonDocument>("patients");

                var doctorId = ObjectId.Parse(_currentDoctor.Id);
                var filter = Builders<BsonDocument>.Filter.Eq("dr_id", doctorId);

                var appointmentList = appointmentsCollection.Find(filter).ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("Date");
                dt.Columns.Add("Time");
                dt.Columns.Add("Patient Name");
                dt.Columns.Add("Status");

                foreach (var app in appointmentList)
                {
                    string date = app.Contains("app_date") ? app["app_date"].AsString : "N/A";
                    string time = app.Contains("app_time") ? app["app_time"].AsString : "N/A";
                    string status = app.Contains("status") ? app["status"].AsString : "N/A";

                    string patientName = "Unknown";

                    if (app.Contains("patient_id") && !app["patient_id"].IsBsonNull)
                    {
                        var patientId = app["patient_id"].AsObjectId;
                        var pFilter = Builders<BsonDocument>.Filter.Eq("_id", patientId);
                        var patientDoc = patientsCollection.Find(pFilter).FirstOrDefault();

                        if (patientDoc != null)
                        {
                            string fname = patientDoc.Contains("first_name") ? patientDoc["first_name"].AsString : "";
                            string lname = patientDoc.Contains("last_name") ? patientDoc["last_name"].AsString : "";
                            patientName = $"{fname} {lname}";
                        }
                    }

                    dt.Rows.Add(date, time, patientName, status);
                }

                dgvAppointments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            // --- FEATURE 2: Navigate to DoctorProfile ---

            // This assumes DoctorProfile has a constructor that accepts a Doctor model
            DoctorProfile profileForm = new DoctorProfile(_currentDoctor);
            profileForm.Show();

            // Optional: Close current dashboard if you don't want multiple windows
            this.Hide();
        }

        private void DoctorDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}