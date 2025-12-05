using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Doctor
{
    public partial class DoctorProfile : Form
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

        public DoctorProfile(Models.Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
            _dbService = new MongoDBService();

            SetupDashboardUI();
            LoadLiveData();
        }

        private void SetupDashboardUI()
        {
            // 1. Form
            this.Text = "Doctor Profile";
            this.Size = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 247, 250); // Light Gray-Blue Background
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // =========================================================
            // LEFT PANEL: PROFILE CARD (White Box)
            // =========================================================
            Panel pnlLeft = new Panel();
            pnlLeft.Size = new Size(300, 640);
            pnlLeft.Location = new Point(20, 10);
            pnlLeft.BackColor = Color.White;
            pnlLeft.BorderStyle = BorderStyle.FixedSingle; // Thin border
            this.Controls.Add(pnlLeft);

            // A. Avatar
            lblInitials = new Label();
            string firstLetter = !string.IsNullOrEmpty(_doctor.FirstName) ? _doctor.FirstName.Substring(0, 1).ToUpper() : "D";
            lblInitials.Text = firstLetter;
            lblInitials.Font = new Font("Segoe UI", 48, FontStyle.Bold);
            lblInitials.ForeColor = Color.White;
            lblInitials.BackColor = Color.FromArgb(60, 120, 216); // Professional Blue
            lblInitials.TextAlign = ContentAlignment.MiddleCenter;
            lblInitials.Size = new Size(120, 120);
            lblInitials.Location = new Point(90, 40);

            // Circular Logic
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, lblInitials.Width, lblInitials.Height);
            lblInitials.Region = new Region(path);
            pnlLeft.Controls.Add(lblInitials);

            // B. Name & Role
            lblName = new Label();
            lblName.Text = $"Dr. {_doctor.FirstName} {_doctor.LastName}";
            lblName.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = false;
            lblName.Size = new Size(300, 40);
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            lblName.Location = new Point(0, 170);
            pnlLeft.Controls.Add(lblName);

            lblRole = new Label();
            lblRole.Text = _doctor.Specialization ?? "General Practitioner";
            lblRole.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            lblRole.ForeColor = Color.Gray;
            lblRole.AutoSize = false;
            lblRole.Size = new Size(300, 30);
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            lblRole.Location = new Point(0, 205);
            pnlLeft.Controls.Add(lblRole);

            // C. Status Badge
            lblStatus = new Label();
            lblStatus.Text = "● Available";
            lblStatus.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblStatus.ForeColor = Color.SeaGreen;
            lblStatus.AutoSize = false;
            lblStatus.Size = new Size(300, 30);
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Location = new Point(0, 235);
            pnlLeft.Controls.Add(lblStatus);

            // D. Details List (Phone, Email, etc.)
            int startY = 300;
            AddDetailRow(pnlLeft, "Phone:", _doctor.PhoneNumber, startY);
            AddDetailRow(pnlLeft, "Fees:", $"{_doctor.ConsultationFee} EGP", startY + 40);

            // Working Days Logic
            string days = _doctor.Schedule?.AvailableDays != null ? string.Join(", ", _doctor.Schedule.AvailableDays) : "Mon-Fri";
            AddDetailRow(pnlLeft, "Days:", days, startY + 80);

            string hours = $"{_doctor.WorkingHours?.StartTime ?? "09:00"} - {_doctor.WorkingHours?.EndTime ?? "17:00"}";
            AddDetailRow(pnlLeft, "Hours:", hours, startY + 120);

            // E. Edit Button
            btnEdit = new Button();
            btnEdit.Text = "Edit Profile";
            btnEdit.Size = new Size(200, 45);
            btnEdit.Location = new Point(50, 550);
            btnEdit.BackColor = Color.FromArgb(60, 120, 216);
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnEdit.Click += BtnEdit_Click;
            pnlLeft.Controls.Add(btnEdit);


            // =========================================================
            // RIGHT PANEL: SCHEDULE TABLE & STATS
            // =========================================================

            // Title
            Label lblTableTitle = new Label();
            lblTableTitle.Text = "Today's Schedule";
            lblTableTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblTableTitle.Location = new Point(340, 20);
            lblTableTitle.AutoSize = true;
            this.Controls.Add(lblTableTitle);

            // Grid View
            gridSchedule = new DataGridView();
            gridSchedule.Location = new Point(340, 70);
            gridSchedule.Size = new Size(520, 350);
            gridSchedule.BackgroundColor = Color.White;
            gridSchedule.BorderStyle = BorderStyle.None;
            gridSchedule.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            gridSchedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridSchedule.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            gridSchedule.RowHeadersVisible = false;
            gridSchedule.AllowUserToAddRows = false;
            gridSchedule.ReadOnly = true;
            gridSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(gridSchedule);

            // Stats / Certifications Panel (Bottom Right)
            Panel pnlStats = new Panel();
            pnlStats.Location = new Point(340, 440);
            pnlStats.Size = new Size(520, 210);
            pnlStats.BackColor = Color.White;
            this.Controls.Add(pnlStats);

            Label lblCertTitle = new Label();
            lblCertTitle.Text = "Certifications & Education";
            lblCertTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblCertTitle.Location = new Point(15, 15);
            lblCertTitle.AutoSize = true;
            pnlStats.Controls.Add(lblCertTitle);

            Label lblCerts = new Label();
            string certs = _doctor.Certification != null ? string.Join("\n• ", _doctor.Certification) : "• MBBS";
            lblCerts.Text = "• " + certs;
            lblCerts.Font = new Font("Segoe UI", 11);
            lblCerts.Location = new Point(15, 50);
            lblCerts.AutoSize = true;
            pnlStats.Controls.Add(lblCerts);
        }

        private void AddDetailRow(Panel pnl, string title, string value, int y)
        {
            Label t = new Label();
            t.Text = title;
            t.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            t.ForeColor = Color.Gray;
            t.Location = new Point(20, y);
            t.AutoSize = true;
            pnl.Controls.Add(t);

            Label v = new Label();
            v.Text = value;
            v.Font = new Font("Segoe UI", 10, FontStyle.Regular); // Slightly smaller to fit
            v.ForeColor = Color.Black;
            v.Location = new Point(80, y);
            v.AutoSize = false;
            v.Size = new Size(200, 40); // Allow wrapping
            pnl.Controls.Add(v);
        }

        private void LoadLiveData()
        {
            // 1. Fill Grid with Slots (Mock or Real)
            DataTable dt = new DataTable();
            dt.Columns.Add("Time");
            dt.Columns.Add("Status");
            dt.Columns.Add("Patient");

            if (_doctor.Slots != null)
            {
                foreach (var slot in _doctor.Slots)
                {
                    // Basic filter for "Today" (optional)
                    dt.Rows.Add(slot.Time, slot.Status, slot.IsBooked ? "Booked" : "--");
                }
            }
            gridSchedule.DataSource = dt;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            editprofile editForm = new editprofile(_doctor);
            editForm.Show();
            this.Close();
        }

        private void DoctorProfile_Load(object sender, EventArgs e) { }
    }
}