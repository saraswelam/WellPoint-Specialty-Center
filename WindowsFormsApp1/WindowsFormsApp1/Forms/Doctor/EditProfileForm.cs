using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Doctor
{
    public partial class EditProfileForm : Form
    {
        private Models.Doctor _doctor;
        private MongoDBService _dbService;

        // UI Controls
        private TextBox txtPhone;
        private NumericUpDown numFee;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpEndTime;

        // Certification Controls
        private ListBox lstCerts;
        private TextBox txtNewCert;
        private Button btnAddCert;
        private Button btnRemoveCert;

        // Day Checkboxes
        private CheckBox cbMon, cbTue, cbWed, cbThu, cbFri, cbSat, cbSun;

        public EditProfileForm()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                SetupUI();
            }
        }

        public EditProfileForm(Models.Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
            _dbService = new MongoDBService();
            SetupUI();
            PopulateData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDashboardForm form = new DoctorDashboardForm(_doctor);
            form.ShowDialog();
            this.Close();
        }

        private void SetupUI()
        {
            // --- CRITICAL FIX: Clear existing controls to prevent overlap ---
            this.Controls.Clear();

            this.Text = "Edit Profile";
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.BackColor = Color.White;

            int y = 20;
            int x = 50; // Increased left margin slightly
            int width = 400;

            // --- 1. BACK BUTTON ---
            Button btnBack = new Button
            {
                Text = "← Back",
                Location = new Point(20, 20), // Top Left
                Size = new Size(80, 35),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };
            btnBack.Click += BackButton_Click;
            this.Controls.Add(btnBack);

            // Move y down so Title doesn't overlap Back button
            y += 60;

            // --- 2. TITLE ---
            Label lblTitle = new Label
            {
                Text = "Edit Your Details",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(x, y),
                AutoSize = true
            };
            this.Controls.Add(lblTitle);
            y += 60;

            // --- 3. FORM FIELDS ---

            // Phone
            Label lblPhone = new Label { Text = "Phone Number", Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.Controls.Add(lblPhone);
            txtPhone = new TextBox { Location = new Point(x, y + 25), Size = new Size(width, 30), Font = new Font("Segoe UI", 10) };
            this.Controls.Add(txtPhone);
            y += 80;

            // Fee
            Label lblFee = new Label { Text = "Consultation Fee", Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.Controls.Add(lblFee);
            numFee = new NumericUpDown { Location = new Point(x, y + 25), Size = new Size(width, 30), Maximum = 10000, Font = new Font("Segoe UI", 10) };
            this.Controls.Add(numFee);
            y += 80;

            // Hours
            Label lblHours = new Label { Text = "Working Hours (Start - End)", Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.Controls.Add(lblHours);
            dtpStartTime = new DateTimePicker { Format = DateTimePickerFormat.Time, ShowUpDown = true, Location = new Point(x, y + 25), Size = new Size(150, 30), Font = new Font("Segoe UI", 10) };
            dtpEndTime = new DateTimePicker { Format = DateTimePickerFormat.Time, ShowUpDown = true, Location = new Point(x + 180, y + 25), Size = new Size(150, 30), Font = new Font("Segoe UI", 10) };
            this.Controls.Add(dtpStartTime);
            this.Controls.Add(dtpEndTime);
            y += 80;

            // Days
            Label lblDays = new Label { Text = "Available Days", Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.Controls.Add(lblDays);
            y += 30;

            cbMon = CreateCheck("Monday", x, y);
            cbTue = CreateCheck("Tuesday", x + 110, y);
            cbWed = CreateCheck("Wednesday", x + 220, y);
            y += 35;
            cbThu = CreateCheck("Thursday", x, y);
            cbFri = CreateCheck("Friday", x + 110, y);
            cbSat = CreateCheck("Saturday", x + 220, y);
            y += 35;
            cbSun = CreateCheck("Sunday", x, y);
            y += 60;

            // --- 4. CERTIFICATIONS ---
            Label lblCert = new Label { Text = "Certifications", Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.Controls.Add(lblCert);
            y += 30;

            // ListBox
            lstCerts = new ListBox { Location = new Point(x, y), Size = new Size(width, 100), Font = new Font("Segoe UI", 10) };
            this.Controls.Add(lstCerts);
            y += 110;

            // Textbox for New Cert
            txtNewCert = new TextBox { Location = new Point(x, y), Size = new Size(240, 30), Font = new Font("Segoe UI", 10) };
            this.Controls.Add(txtNewCert);

            // Add Button
            btnAddCert = new Button { Text = "+ Add", BackColor = Color.SteelBlue, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(70, 32), Location = new Point(x + 250, y - 2) };
            btnAddCert.Click += BtnAddCert_Click;
            this.Controls.Add(btnAddCert);

            // Remove Button
            btnRemoveCert = new Button { Text = "Remove", BackColor = Color.IndianRed, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(70, 32), Location = new Point(x + 330, y - 2) };
            btnRemoveCert.Click += (s, e) => {
                if (lstCerts.SelectedIndex != -1) lstCerts.Items.RemoveAt(lstCerts.SelectedIndex);
            };
            this.Controls.Add(btnRemoveCert);

            y += 80; // Gap before Save buttons

            // --- 5. ACTION BUTTONS ---

            // Cancel Button
            Button btnCancel = new Button { Text = "Cancel", BackColor = Color.LightGray, FlatStyle = FlatStyle.Flat, Size = new Size(120, 45), Location = new Point(x, y) };
            btnCancel.Click += BackButton_Click;
            this.Controls.Add(btnCancel);

            // Save Button (Placed next to Cancel)
            Button btnSave = new Button { Text = "Save Changes", BackColor = Color.SeaGreen, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(180, 45), Location = new Point(x + 140, y) };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);
        }

        private void BtnAddCert_Click(object sender, EventArgs e)
        {
            string newCert = txtNewCert.Text.Trim();
            if (!string.IsNullOrEmpty(newCert))
            {
                lstCerts.Items.Add(newCert);
                txtNewCert.Clear();
            }
        }

        private CheckBox CreateCheck(string text, int x, int y)
        {
            CheckBox cb = new CheckBox { Text = text, Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10) };
            this.Controls.Add(cb);
            return cb;
        }

        private void PopulateData()
        {
            if (_doctor == null) return;

            txtPhone.Text = _doctor.PhoneNumber;
            numFee.Value = (decimal)(_doctor.ConsultationFee ?? 0);

            if (_doctor.WorkingHours != null)
            {
                if (DateTime.TryParse(_doctor.WorkingHours.StartTime, out DateTime tStart)) dtpStartTime.Value = tStart;
                if (DateTime.TryParse(_doctor.WorkingHours.EndTime, out DateTime tEnd)) dtpEndTime.Value = tEnd;
            }

            if (_doctor.Schedule?.AvailableDays != null)
            {
                var days = _doctor.Schedule.AvailableDays;
                if (days.Contains("Monday")) cbMon.Checked = true;
                if (days.Contains("Tuesday")) cbTue.Checked = true;
                if (days.Contains("Wednesday")) cbWed.Checked = true;
                if (days.Contains("Thursday")) cbThu.Checked = true;
                if (days.Contains("Friday")) cbFri.Checked = true;
                if (days.Contains("Saturday")) cbSat.Checked = true;
                if (days.Contains("Sunday")) cbSun.Checked = true;
            }

            if (_doctor.Certification != null)
            {
                foreach (var cert in _doctor.Certification)
                {
                    lstCerts.Items.Add(cert);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> selectedDays = new List<string>();
                if (cbMon.Checked) selectedDays.Add("Monday");
                if (cbTue.Checked) selectedDays.Add("Tuesday");
                if (cbWed.Checked) selectedDays.Add("Wednesday");
                if (cbThu.Checked) selectedDays.Add("Thursday");
                if (cbFri.Checked) selectedDays.Add("Friday");
                if (cbSat.Checked) selectedDays.Add("Saturday");
                if (cbSun.Checked) selectedDays.Add("Sunday");

                List<string> updatedCerts = new List<string>();
                foreach (var item in lstCerts.Items) updatedCerts.Add(item.ToString());

                var collection = _dbService.GetCollection<BsonDocument>("doctors");
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(_doctor.Id));
                var update = Builders<BsonDocument>.Update
                    .Set("phone_number", txtPhone.Text)
                    .Set("consultation_fee", (double)numFee.Value)
                    .Set("working_hours.start_time", dtpStartTime.Value.ToString("HH:mm"))
                    .Set("working_hours.end_time", dtpEndTime.Value.ToString("HH:mm"))
                    .Set("schedule.available_days", selectedDays)
                    .Set("certification", updatedCerts);

                collection.UpdateOne(filter, update);

                // Update Local Object
                _doctor.PhoneNumber = txtPhone.Text;
                _doctor.ConsultationFee = (double)numFee.Value;
                if (_doctor.WorkingHours == null) _doctor.WorkingHours = new Models.WorkingHours();
                _doctor.WorkingHours.StartTime = dtpStartTime.Value.ToString("HH:mm");
                _doctor.WorkingHours.EndTime = dtpEndTime.Value.ToString("HH:mm");
                if (_doctor.Schedule == null) _doctor.Schedule = new Models.Schedule();
                _doctor.Schedule.AvailableDays = selectedDays;
                _doctor.Certification = updatedCerts;

                MessageBox.Show("Saved!");

                this.Hide();
                new DoctorDashboardForm(_doctor).ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void editprofile_Load(object sender, EventArgs e) { }
    }
}