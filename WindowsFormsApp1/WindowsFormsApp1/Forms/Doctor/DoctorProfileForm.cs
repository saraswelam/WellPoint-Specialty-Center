using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Doctor
{
    public partial class DoctorProfileForm : Form
    {
        private Models.Doctor _doctor;
        private MongoDBService _dbService;

        // UI Controls
        private Label lblInitials;
        private Label lblName;
        private Label lblRole;
        private Label lblStatus;
        private DataGridView gridSchedule;
        private Button btnEdit;
        private Panel pnlLeft;
        private Panel titleBar;

        public DoctorProfileForm(Models.Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
            _dbService = new MongoDBService();

            SetupDashboardUI();
            LoadLiveData();
        }

        private void SetupDashboardUI()
        {
            // 1. Form Settings (FULL SCREEN WITH NO DEFAULT TITLE BAR)
            this.Text = "Doctor Profile";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None; // Remove default title bar completely
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Resize += DoctorProfileForm_Resize;

            // =========================================================
            // CUSTOM TITLE BAR
            // =========================================================
            titleBar = new Panel();
            titleBar.BackColor = Color.FromArgb(60, 120, 216);
            titleBar.Size = new Size(this.ClientSize.Width, 50); // Slightly taller for better look
            titleBar.Location = new Point(0, 0);
            titleBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(titleBar);

            // Back Button in Title Bar
            Button btnBack = new Button();
            btnBack.Text = "← Back to Dashboard";
            btnBack.Size = new Size(180, 35);
            btnBack.Location = new Point(20, 8);
            btnBack.BackColor = Color.White;
            btnBack.ForeColor = Color.FromArgb(60, 120, 216);
            btnBack.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Click += BtnBack_Click;
            titleBar.Controls.Add(btnBack);

            // Title Label in Title Bar
            Label titleLabel = new Label();
            titleLabel.Text = "DOCTOR PROFILE";
            titleLabel.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(this.ClientSize.Width / 2 - 100, 12);
            titleLabel.AutoSize = true;
            titleLabel.Anchor = AnchorStyles.Top;
            titleBar.Controls.Add(titleLabel);

            // =========================================================
            // LEFT PANEL: PROFILE CARD
            // =========================================================
            pnlLeft = new Panel();
            pnlLeft.Size = new Size(350, this.ClientSize.Height - 70); // Account for title bar
            pnlLeft.Location = new Point(20, 60); // Below title bar
            pnlLeft.BackColor = Color.White;
            pnlLeft.BorderStyle = BorderStyle.FixedSingle;
            pnlLeft.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.Controls.Add(pnlLeft);
            pnlLeft.BringToFront();

            // A. Avatar
            lblInitials = new Label();
            string firstLetter = !string.IsNullOrEmpty(_doctor.FirstName) ? _doctor.FirstName.Substring(0, 1).ToUpper() : "D";
            lblInitials.Text = firstLetter;
            lblInitials.Font = new Font("Segoe UI", 48, FontStyle.Bold);
            lblInitials.ForeColor = Color.White;
            lblInitials.BackColor = Color.FromArgb(60, 120, 216);
            lblInitials.TextAlign = ContentAlignment.MiddleCenter;
            lblInitials.Size = new Size(140, 140);
            lblInitials.Location = new Point(105, 40); // Adjusted Y position

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, lblInitials.Width, lblInitials.Height);
            lblInitials.Region = new Region(path);
            pnlLeft.Controls.Add(lblInitials);

            // B. Name & Role
            lblName = new Label();
            lblName.Text = $"Dr. {_doctor.FirstName} {_doctor.LastName}";
            lblName.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = false;
            lblName.Size = new Size(350, 50);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Location = new Point(0, 200); // Adjusted from 210
            pnlLeft.Controls.Add(lblName);

            lblRole = new Label();
            lblRole.Text = _doctor.Specialization ?? "General Practitioner";
            lblRole.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblRole.ForeColor = Color.Gray;
            lblRole.AutoSize = false;
            lblRole.Size = new Size(350, 40);
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            lblRole.Location = new Point(0, 250); // Adjusted from 260
            pnlLeft.Controls.Add(lblRole);

            // C. Status Badge
            lblStatus = new Label();
            lblStatus.Text = "● Available";
            lblStatus.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblStatus.ForeColor = Color.SeaGreen;
            lblStatus.AutoSize = false;
            lblStatus.Size = new Size(350, 40);
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Location = new Point(0, 290); // Adjusted from 300
            pnlLeft.Controls.Add(lblStatus);

            // D. Details List
            int startY = 350; // Adjusted from 370
            AddDetailRow(pnlLeft, "Phone:", _doctor.PhoneNumber, startY);
            AddDetailRow(pnlLeft, "Fees:", $"{_doctor.ConsultationFee} EGP", startY + 50);

            string days = _doctor.Schedule?.AvailableDays != null ? string.Join(", ", _doctor.Schedule.AvailableDays) : "Mon-Fri";
            AddDetailRow(pnlLeft, "Days:", days, startY + 100);

            string hours = $"{_doctor.WorkingHours?.StartTime ?? "09:00"} - {_doctor.WorkingHours?.EndTime ?? "17:00"}";
            AddDetailRow(pnlLeft, "Hours:", hours, startY + 150);

            // E. Edit Button (Bottom of panel)
            btnEdit = new Button();
            btnEdit.Text = "Edit Profile";
            btnEdit.Size = new Size(250, 55);
            btnEdit.Location = new Point((pnlLeft.Width - 250) / 2, pnlLeft.Height - 100);
            btnEdit.BackColor = Color.FromArgb(60, 120, 216);
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnEdit.Anchor = AnchorStyles.Bottom;
            btnEdit.Click += BtnEdit_Click;
            pnlLeft.Controls.Add(btnEdit);

            // =========================================================
            // RIGHT PANEL: SCHEDULE TABLE & STATS
            // =========================================================

            // Title
            Label lblTableTitle = new Label();
            lblTableTitle.Text = "Today's Schedule";
            lblTableTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblTableTitle.Location = new Point(390, 60); // Adjusted Y for title bar
            lblTableTitle.AutoSize = true;
            this.Controls.Add(lblTableTitle);

            // Grid View
            gridSchedule = new DataGridView();
            gridSchedule.Location = new Point(390, 110); // Adjusted Y for title bar
            gridSchedule.Size = new Size(this.ClientSize.Width - 420, this.ClientSize.Height - 480); // Adjusted height
            gridSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridSchedule.BackgroundColor = Color.White;
            gridSchedule.BorderStyle = BorderStyle.FixedSingle;
            gridSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            gridSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            gridSchedule.ColumnHeadersHeight = 40;
            gridSchedule.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridSchedule.RowHeadersVisible = false;
            gridSchedule.AllowUserToAddRows = false;
            gridSchedule.ReadOnly = true;
            gridSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridSchedule.RowTemplate.Height = 35;
            this.Controls.Add(gridSchedule);

            // Stats / Certifications Panel (Bottom Right)
            Panel pnlStats = new Panel();
            pnlStats.Location = new Point(390, this.ClientSize.Height - 360); // Adjusted Y
            pnlStats.Size = new Size(this.ClientSize.Width - 420, 300);
            pnlStats.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlStats.BackColor = Color.White;
            pnlStats.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(pnlStats);

            Label lblCertTitle = new Label();
            lblCertTitle.Text = "Certifications & Education";
            lblCertTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblCertTitle.ForeColor = Color.FromArgb(60, 120, 216);
            lblCertTitle.Location = new Point(20, 20);
            lblCertTitle.AutoSize = true;
            pnlStats.Controls.Add(lblCertTitle);

            Label lblCerts = new Label();
            string certs = _doctor.Certification != null ? string.Join("\n• ", _doctor.Certification) : "• MBBS";
            lblCerts.Text = "• " + certs;
            lblCerts.Font = new Font("Segoe UI", 11);
            lblCerts.Location = new Point(20, 60);
            lblCerts.AutoSize = true;
            lblCerts.MaximumSize = new Size(pnlStats.Width - 40, 0);
            pnlStats.Controls.Add(lblCerts);
        }

        private void AddDetailRow(Panel pnl, string title, string value, int y)
        {
            Label t = new Label();
            t.Text = title;
            t.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            t.ForeColor = Color.Gray;
            t.Location = new Point(30, y);
            t.AutoSize = true;
            pnl.Controls.Add(t);

            Label v = new Label();
            v.Text = value;
            v.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            v.ForeColor = Color.Black;
            v.Location = new Point(120, y);
            v.AutoSize = false;
            v.Size = new Size(200, 40);
            pnl.Controls.Add(v);
        }

        private void LoadLiveData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Time");
            dt.Columns.Add("Status");
            dt.Columns.Add("Patient");

            if (_doctor.Slots != null)
            {
                var today = DateTime.Today.ToString("yyyy-MM-dd");
                var patientsCollection = _dbService.GetCollection<BsonDocument>("patients");

                foreach (var slot in _doctor.Slots)
                {
                    // Only show today's slots
                    if (slot.Date != today) continue;

                    string patientName = "--";

                    if (slot.IsBooked && !string.IsNullOrEmpty(slot.PatientId))
                    {
                        try
                        {
                            var patientId = ObjectId.Parse(slot.PatientId);
                            var pFilter = Builders<BsonDocument>.Filter.Eq("_id", patientId);
                            var patientDoc = patientsCollection.Find(pFilter).FirstOrDefault();

                            if (patientDoc != null)
                            {
                                string fname = patientDoc.GetValue("first_name", "").AsString;
                                string lname = patientDoc.GetValue("last_name", "").AsString;
                                patientName = $"{fname} {lname}".Trim();
                            }
                            else
                            {
                                patientName = "Booked";
                            }
                        }
                        catch (Exception)
                        {
                            patientName = "Booked";
                        }
                    }
                    else if (slot.IsBooked)
                    {
                        patientName = "Booked";
                    }

                    dt.Rows.Add(slot.Time, slot.Status, patientName);
                }
            }

            gridSchedule.DataSource = dt;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Return to dashboard
            this.Hide();
            DoctorDashboardForm dashboard = new DoctorDashboardForm(_doctor);
            dashboard.ShowDialog();
            this.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditProfileForm editForm = new EditProfileForm(_doctor);
            editForm.Show();
            this.Close();
        }

        // Handle form resize for better full-screen experience
        private void DoctorProfileForm_Resize(object sender, EventArgs e)
        {
            // Update title bar width
            if (titleBar != null)
            {
                titleBar.Size = new Size(this.ClientSize.Width, 50);

                // Update title label position
                var titleLabel = titleBar.Controls.OfType<Label>().FirstOrDefault();
                if (titleLabel != null)
                {
                    titleLabel.Location = new Point(this.ClientSize.Width / 2 - 100, 12);
                }
            }

            // Update panel height
            if (pnlLeft != null)
            {
                pnlLeft.Size = new Size(350, this.ClientSize.Height - 70);
                pnlLeft.Location = new Point(20, 60);

                // Re-position edit button if it exists
                if (btnEdit != null)
                {
                    btnEdit.Location = new Point((pnlLeft.Width - 250) / 2, pnlLeft.Height - 100);
                }
            }

            // Update grid size
            if (gridSchedule != null)
            {
                gridSchedule.Size = new Size(this.ClientSize.Width - 420, this.ClientSize.Height - 480);
                gridSchedule.Location = new Point(390, 110);
            }

            // Update stats panel position
            var pnlStats = this.Controls.OfType<Panel>().FirstOrDefault(p => p.Controls.OfType<Label>().Any(l => l.Text.Contains("Certifications")));
            if (pnlStats != null)
            {
                pnlStats.Location = new Point(390, this.ClientSize.Height - 360);
                pnlStats.Size = new Size(this.ClientSize.Width - 420, 300);
            }

            // Update schedule title position
            var lblTableTitle = this.Controls.OfType<Label>().FirstOrDefault(l => l.Text == "Today's Schedule");
            if (lblTableTitle != null)
            {
                lblTableTitle.Location = new Point(390, 60);
            }
        }

        private void DoctorProfile_Load(object sender, EventArgs e) { }
    }
}