using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using ClinicalBookingSystem.Services;

namespace WindowsFormsApp1.Forms.Doctor
{
    public partial class editprofile : Form
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

        public editprofile(Models.Doctor doctor)
        {
            InitializeComponent();
            _doctor = doctor;
            _dbService = new MongoDBService();

            SetupUI();
            PopulateData();
        }

        public editprofile() { InitializeComponent(); }

        private void SetupUI()
        {
            this.Text = "Edit Profile";
            this.Size = new Size(500, 800); // Increased height for certifications
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            int y = 20;
            int x = 40;
            int width = 380;

            // Title
            Label lblTitle = new Label { Text = "Edit Your Details", Font = new Font("Segoe UI", 16, FontStyle.Bold), Location = new Point(x, y), AutoSize = true };
            this.Controls.Add(lblTitle);
            y += 50;

            // Phone
            Label lblPhone = new Label { Text = "Phone Number", Location = new Point(x, y), AutoSize = true };
            this.Controls.Add(lblPhone);
            txtPhone = new TextBox { Location = new Point(x, y + 25), Size = new Size(width, 30), Font = new Font("Segoe UI", 10) };
            this.Controls.Add(txtPhone);
            y += 70;

            // Fee
            Label lblFee = new Label { Text = "Consultation Fee", Location = new Point(x, y), AutoSize = true };
            this.Controls.Add(lblFee);
            numFee = new NumericUpDown { Location = new Point(x, y + 25), Size = new Size(width, 30), Maximum = 10000, Font = new Font("Segoe UI", 10) };
            this.Controls.Add(numFee);
            y += 70;

            // Hours
            Label lblHours = new Label { Text = "Working Hours (Start - End)", Location = new Point(x, y), AutoSize = true };
            this.Controls.Add(lblHours);
            dtpStartTime = new DateTimePicker { Format = DateTimePickerFormat.Time, ShowUpDown = true, Location = new Point(x, y + 25), Size = new Size(120, 30) };
            dtpEndTime = new DateTimePicker { Format = DateTimePickerFormat.Time, ShowUpDown = true, Location = new Point(x + 150, y + 25), Size = new Size(120, 30) };
            this.Controls.Add(dtpStartTime);
            this.Controls.Add(dtpEndTime);
            y += 70;

            // Days Selection
            Label lblDays = new Label { Text = "Available Days", Location = new Point(x, y), AutoSize = true };
            this.Controls.Add(lblDays);
            y += 30;

            cbMon = CreateCheck("Monday", x, y);
            cbTue = CreateCheck("Tuesday", x + 100, y);
            cbWed = CreateCheck("Wednesday", x + 200, y);
            y += 30;
            cbThu = CreateCheck("Thursday", x, y);
            cbFri = CreateCheck("Friday", x + 100, y);
            cbSat = CreateCheck("Saturday", x + 200, y);
            y += 30;
            cbSun = CreateCheck("Sunday", x, y);

            y += 50;

            // --- NEW SECTION: CERTIFICATIONS ---
            Label lblCert = new Label { Text = "Certifications", Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.Controls.Add(lblCert);
            y += 25;

            // ListBox to show existing
            lstCerts = new ListBox { Location = new Point(x, y), Size = new Size(width, 80), Font = new Font("Segoe UI", 9) };
            this.Controls.Add(lstCerts);
            y += 90;

            // Textbox for New Cert
            txtNewCert = new TextBox { Location = new Point(x, y), Size = new Size(240, 30), Font = new Font("Segoe UI", 10) };
            this.Controls.Add(txtNewCert);

            // Add Button
            btnAddCert = new Button { Text = "+ Add", BackColor = Color.SteelBlue, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(60, 30), Location = new Point(x + 250, y - 2) };
            btnAddCert.Click += BtnAddCert_Click;
            this.Controls.Add(btnAddCert);

            // Remove Button
            btnRemoveCert = new Button { Text = "Remove", BackColor = Color.IndianRed, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(70, 30), Location = new Point(x + 320, y - 2) };
            btnRemoveCert.Click += (s, e) => {
                if (lstCerts.SelectedIndex != -1) lstCerts.Items.RemoveAt(lstCerts.SelectedIndex);
            };
            this.Controls.Add(btnRemoveCert);

            y += 50; // Space for Save buttons

            // Buttons
            Button btnSave = new Button { Text = "Save Changes", BackColor = Color.SeaGreen, ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Size = new Size(150, 40), Location = new Point(x + 230, y) };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            Button btnCancel = new Button { Text = "Cancel", BackColor = Color.LightGray, FlatStyle = FlatStyle.Flat, Size = new Size(100, 40), Location = new Point(x + 120, y) };
            btnCancel.Click += (s, ev) => { new DoctorProfile(_doctor).Show(); this.Close(); };
            this.Controls.Add(btnCancel);
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
            CheckBox cb = new CheckBox { Text = text, Location = new Point(x, y), AutoSize = true, Font = new Font("Segoe UI", 9) };
            this.Controls.Add(cb);
            return cb;
        }

        private void PopulateData()
        {
            txtPhone.Text = _doctor.PhoneNumber;
            numFee.Value = (decimal)(_doctor.ConsultationFee ?? 0);

            // Parse Time
            if (_doctor.WorkingHours != null)
            {
                DateTime t;
                if (DateTime.TryParse(_doctor.WorkingHours.StartTime, out t)) dtpStartTime.Value = t;
                if (DateTime.TryParse(_doctor.WorkingHours.EndTime, out t)) dtpEndTime.Value = t;
            }

            // Check Days
            if (_doctor.Schedule != null && _doctor.Schedule.AvailableDays != null)
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

            // Populate Certifications
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
                // Collect Days
                List<string> selectedDays = new List<string>();
                if (cbMon.Checked) selectedDays.Add("Monday");
                if (cbTue.Checked) selectedDays.Add("Tuesday");
                if (cbWed.Checked) selectedDays.Add("Wednesday");
                if (cbThu.Checked) selectedDays.Add("Thursday");
                if (cbFri.Checked) selectedDays.Add("Friday");
                if (cbSat.Checked) selectedDays.Add("Saturday");
                if (cbSun.Checked) selectedDays.Add("Sunday");

                // Collect Certifications
                List<string> updatedCerts = new List<string>();
                foreach (var item in lstCerts.Items)
                {
                    updatedCerts.Add(item.ToString());
                }

                // MongoDB Update
                var collection = _dbService.GetCollection<BsonDocument>("doctors");
                var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(_doctor.Id));
                var update = Builders<BsonDocument>.Update
                    .Set("phone_number", txtPhone.Text)
                    .Set("consultation_fee", (double)numFee.Value)
                    .Set("working_hours.start_time", dtpStartTime.Value.ToString("HH:mm"))
                    .Set("working_hours.end_time", dtpEndTime.Value.ToString("HH:mm"))
                    .Set("schedule.available_days", selectedDays)
                    .Set("certification", updatedCerts); // Update Certs

                collection.UpdateOne(filter, update);

                // Update Local Object
                _doctor.PhoneNumber = txtPhone.Text;
                _doctor.ConsultationFee = (double)numFee.Value;

                if (_doctor.WorkingHours == null) _doctor.WorkingHours = new Models.WorkingHours();
                _doctor.WorkingHours.StartTime = dtpStartTime.Value.ToString("HH:mm");
                _doctor.WorkingHours.EndTime = dtpEndTime.Value.ToString("HH:mm");

                if (_doctor.Schedule == null) _doctor.Schedule = new Models.Schedule();
                _doctor.Schedule.AvailableDays = selectedDays;

                _doctor.Certification = updatedCerts; // Update Local Certs

                MessageBox.Show("Saved!");
                new DoctorProfile(_doctor).Show();
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