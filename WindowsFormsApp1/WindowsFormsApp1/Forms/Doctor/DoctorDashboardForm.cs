using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using ClinicalBookingSystem.Services;

namespace WindowsFormsApp1.Forms.Doctor
{
    public partial class DoctorDashboardForm : Form
    {
        private Models.Doctor _currentDoctor;
        private MongoDBService _dbService;

        // UI Controls
        private Button btnProfile;
        private Button btnLogout;
        private Button btnMarkCompleted; // NEW: Button to mark as completed
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
            // 1. Form Settings (FULL SCREEN)
            this.Text = "Doctor Homepage";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.BackColor = Color.WhiteSmoke;

            // 2. Profile Button (Top Left)
            btnProfile = new Button();
            string firstLetter = !string.IsNullOrEmpty(_currentDoctor.FirstName)
                                ? _currentDoctor.FirstName.Substring(0, 1).ToUpper()
                                : "";

            btnProfile.Text = firstLetter;
            btnProfile.Font = new Font("Arial", 22, FontStyle.Bold);
            btnProfile.ForeColor = Color.White;
            btnProfile.BackColor = Color.SteelBlue;
            btnProfile.Size = new Size(60, 60);
            btnProfile.Location = new Point(30, 30);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.FlatAppearance.BorderSize = 0;

            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, btnProfile.Width, btnProfile.Height);
            btnProfile.Region = new Region(path);

            btnProfile.Click += BtnProfile_Click;
            this.Controls.Add(btnProfile);

            // 3. Welcome Label
            lblTitle = new Label();
            lblTitle.Text = $"Welcome, Dr. {_currentDoctor.FirstName} {_currentDoctor.LastName}";
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitle.Location = new Point(110, 45);
            this.Controls.Add(lblTitle);

            // 4. Logout Button (Top Right)
            btnLogout = new Button();
            btnLogout.Text = "Logout";
            btnLogout.Size = new Size(100, 40);
            btnLogout.Location = new Point(this.ClientSize.Width - 130, 40);
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.IndianRed;
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Click += LogoutButton_Click;
            this.Controls.Add(btnLogout);

            // 5. Mark as Completed Button (Next to Logout)
            btnMarkCompleted = new Button();
            btnMarkCompleted.Text = "Mark as Completed";
            btnMarkCompleted.Size = new Size(150, 40);
            btnMarkCompleted.Location = new Point(this.ClientSize.Width - 290, 40);
            btnMarkCompleted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMarkCompleted.BackColor = Color.SeaGreen;
            btnMarkCompleted.ForeColor = Color.White;
            btnMarkCompleted.FlatStyle = FlatStyle.Flat;
            btnMarkCompleted.Click += BtnMarkCompleted_Click;
            btnMarkCompleted.Enabled = false; // Disabled until a row is selected
            this.Controls.Add(btnMarkCompleted);

            // 6. Appointments Table
            dgvAppointments = new DataGridView();
            dgvAppointments.Location = new Point(30, 120);
            dgvAppointments.Size = new Size(this.ClientSize.Width - 60, this.ClientSize.Height - 160);
            dgvAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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

            // Add event for row selection
            dgvAppointments.SelectionChanged += DgvAppointments_SelectionChanged;

            this.Controls.Add(dgvAppointments);
        }

        private void DgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            // Enable/disable the "Mark as Completed" button based on selection
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                var selectedRow = dgvAppointments.SelectedRows[0];
                string status = selectedRow.Cells["Status"].Value?.ToString() ?? "";

                // Only enable if appointment is "scheduled" (not cancelled or already completed)
                btnMarkCompleted.Enabled = (status == "scheduled" || status == "confirmed");
            }
            else
            {
                btnMarkCompleted.Enabled = false;
            }
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
                dt.Columns.Add("Appointment ID"); // Hidden column for the ID
                dt.Columns.Add("Date");
                dt.Columns.Add("Time");
                dt.Columns.Add("Patient Name");
                dt.Columns.Add("Status");

                foreach (var app in appointmentList)
                {
                    string id = app.GetValue("_id", "").AsObjectId.ToString();
                    string date = app.GetValue("app_date", "N/A").AsString;
                    string time = app.GetValue("app_time", "N/A").AsString;
                    string status = app.GetValue("status", "N/A").AsString;

                    string patientName = "Unknown";
                    if (app.Contains("patient_id") && !app["patient_id"].IsBsonNull)
                    {
                        var patientId = app["patient_id"].AsObjectId;
                        var pFilter = Builders<BsonDocument>.Filter.Eq("_id", patientId);
                        var patientDoc = patientsCollection.Find(pFilter).FirstOrDefault();

                        if (patientDoc != null)
                        {
                            string fname = patientDoc.GetValue("first_name", "").AsString;
                            string lname = patientDoc.GetValue("last_name", "").AsString;
                            patientName = $"{fname} {lname}";
                        }
                    }

                    dt.Rows.Add(id, date, time, patientName, status);
                }

                dgvAppointments.DataSource = dt;

                // Hide the Appointment ID column (it's just for reference)
                if (dgvAppointments.Columns.Contains("Appointment ID"))
                {
                    dgvAppointments.Columns["Appointment ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void BtnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to mark as completed.");
                return;
            }

            var selectedRow = dgvAppointments.SelectedRows[0];
            string appointmentId = selectedRow.Cells["Appointment ID"].Value?.ToString();
            string patientName = selectedRow.Cells["Patient Name"].Value?.ToString();
            string date = selectedRow.Cells["Date"].Value?.ToString();
            string time = selectedRow.Cells["Time"].Value?.ToString();

            if (string.IsNullOrEmpty(appointmentId))
            {
                MessageBox.Show("Could not find appointment ID.");
                return;
            }

            // Ask for confirmation
            var result = MessageBox.Show(
                $"Mark appointment for {patientName} on {date} at {time} as completed?",
                "Confirm Completion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Update the appointment status in MongoDB
                    var appointmentsCollection = _dbService.GetCollection<BsonDocument>("appointments");
                    var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(appointmentId));
                    var update = Builders<BsonDocument>.Update.Set("status", "completed");

                    var resultUpdate = appointmentsCollection.UpdateOne(filter, update);

                    if (resultUpdate.ModifiedCount > 0)
                    {
                        MessageBox.Show("Appointment marked as completed successfully!");

                        // Also update the corresponding slot in doctor's slots if needed
                        UpdateDoctorSlotStatus(appointmentId, "completed");

                        // Refresh the data
                        LoadAppointmentsFromMongoDB();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update appointment status.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating appointment: {ex.Message}");
                }
            }
        }

        private void UpdateDoctorSlotStatus(string appointmentId, string status)
        {
            try
            {
                // Find and update the doctor's slot that has this appointment ID
                var doctorsCollection = _dbService.GetCollection<BsonDocument>("doctors");
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(_currentDoctor.Id));
                var doctor = doctorsCollection.Find(filter).FirstOrDefault();

                if (doctor != null && doctor.Contains("slots"))
                {
                    var slots = doctor["slots"].AsBsonArray;
                    bool updated = false;

                    for (int i = 0; i < slots.Count; i++)
                    {
                        var slot = slots[i].AsBsonDocument;
                        if (slot.Contains("app_id") && slot["app_id"].AsString == appointmentId)
                        {
                            // Update the slot status
                            var update = Builders<BsonDocument>.Update.Set($"slots.{i}.status", status);
                            doctorsCollection.UpdateOne(filter, update);
                            updated = true;
                            break;
                        }
                    }

                    if (!updated)
                    {
                        Console.WriteLine("Slot not found for this appointment.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating slot: {ex.Message}");
            }
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            DoctorProfileForm profileForm = new DoctorProfileForm(_currentDoctor);
            profileForm.Show();
            this.Hide();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                var res = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res != DialogResult.Yes) return;

                var login = new WindowsFormsApp1.Forms.Auth.LoginForm();
                login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Logout error: " + ex.Message);
            }
        }

        private void DoctorDashboardForm_Load_1(object sender, EventArgs e) { }
    }
}