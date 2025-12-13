using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms.Admin
{
    public partial class AddDoctorForm : Form
    {
        private readonly MongoDBService _db;
        private Models.Admin _admin;

        public AddDoctorForm()
        {
            InitializeComponent();
            _db = new MongoDBService();
        }

      
        private void AddDoctorForm_Load(object sender, EventArgs e)
        {
            LoadClinics();
            LoadSpecializations();
            LoadAvailableDays();

            CenterPanel();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterPanel();
        }

        private void CenterPanel()
        {
            MainPanel.Left = (this.ClientSize.Width - MainPanel.Width) / 2;
            MainPanel.Top = (this.ClientSize.Height - MainPanel.Height) / 2;
        }


       
        private void LoadClinics()
        {
            var clinics = _db.GetCollection<Clinic>("clinics")
                             .Find(_ => true)
                             .ToList();

            ClinicComboBox.DataSource = clinics;
            ClinicComboBox.DisplayMember = "ClinicName";
            ClinicComboBox.ValueMember = "Id";
        }

       
        private void LoadSpecializations()
        {
            var clinics = _db.GetCollection<Clinic>("clinics")
                             .Find(_ => true)
                             .ToList();

            var specializations = clinics
                .SelectMany(c => c.Departments)
                .Select(d => d.DepartmentName)
                .Distinct()
                .ToList();

            SpecializationComboBox.DataSource = specializations;
        }

      
        private void LoadAvailableDays()
        {
            AvailableDaysChecklist.Items.Clear();

            string[] days =
            {
                "Sunday","Monday","Tuesday","Wednesday",
                "Thursday","Friday","Saturday"
            };

            AvailableDaysChecklist.Items.AddRange(days);
        }

       
        private void AddCertificationButton_Click(object sender, EventArgs e)
        {
            string cert = CertificationsTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(cert))
            {
                MessageBox.Show("Please enter a certification.");
                return;
            }

            listBox1.Items.Add(cert);
            CertificationsTextBox.Clear();
        }

        
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            
            var userCol = _db.GetCollection<User>("users");
            var newUser = new User
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Email = EmailTextBox.Text.Trim(),
                Password = PasswordTextBox.Text.Trim(),
                Role = "doctor"
            };

            userCol.InsertOne(newUser);

            
            var days = AvailableDaysChecklist.CheckedItems.Cast<string>().ToList();
            var certifications = listBox1.Items.Cast<string>().ToList();

            
            var doctorCol = _db.GetCollection<WindowsFormsApp1.Models.Doctor>("doctors");

            var newDoctor = new global::WindowsFormsApp1.Models.Doctor  
            {
                Id = ObjectId.GenerateNewId().ToString(),
                UserId = newUser.Id,
                ClinicId = ClinicComboBox.SelectedValue.ToString(),
                FirstName = FirstNameTextBox.Text.Trim(),
                LastName = LastNameTextBox.Text.Trim(),
                PhoneNumber = PhoneTextBox.Text.Trim(),
                ConsultationFee = double.Parse(ConsultationFeeTextBox.Text.Trim()),
                Specialization = SpecializationComboBox.SelectedItem.ToString(),
                Certification = certifications,
                Schedule = new Schedule
                {
                    AvailableDays = days
                },
                WorkingHours = new WorkingHours
                {
                    StartTime = StartTimeDatePicker.Value.ToString("HH:mm"),
                    EndTime = EndTimeDatePicker.Value.ToString("HH:mm")
                },
                Slots = new List<DoctorSlot>() // empty
            };

            doctorCol.InsertOne(newDoctor);

            MessageBox.Show("Doctor added successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //some validations ashan inserting
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show("First name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show("Last name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                !EmailTextBox.Text.Contains("@") ||
                !EmailTextBox.Text.Contains("."))
            {
                MessageBox.Show("Valid email is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Password is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PhoneTextBox.Text))
            {
                MessageBox.Show("Phone number is required.");
                return false;
            }
            if (!ValidatePhoneNumber(PhoneTextBox.Text))
            {
                MessageBox.Show("Invalid phone number. Please enter a valid 11-digit Egyptian mobile number starting with 01 (e.g., 01012345678).", "Validation Error");
                return false;
            }
            if (!ValidatePassword(PasswordTextBox.Text))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain:\n• At least one uppercase letter\n• At least one lowercase letter\n• At least one digit", "Validation Error");
                return false;
            }

            if (!double.TryParse(ConsultationFeeTextBox.Text, out _))
            {
                MessageBox.Show("Consultation fee must be a number.");
                return false;
            }

            if (AvailableDaysChecklist.CheckedItems.Count == 0)
            {
                MessageBox.Show("Pick at least one working day.");
                return false;
            }

            if (StartTimeDatePicker.Value >= EndTimeDatePicker.Value)
            {
                MessageBox.Show("Start time must be earlier than end time.");
                return false;
            }

            return true;
        }


        private bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;


            if (password.Length < 8)
                return false;


            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;


            if (!Regex.IsMatch(password, @"[a-z]"))
                return false;


            if (!Regex.IsMatch(password, @"[0-9]"))
                return false;



            return true;
        }


        private void FirstNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void LastNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void EmailTextBox_TextChanged(object sender, EventArgs e) { }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e) { }
        private void PhoneTextBox_TextChanged(object sender, EventArgs e) { }
        private void ConsultationFeeTextBox_TextChanged(object sender, EventArgs e) { }
        private void SpecializationComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ClinicComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void CertificationsTextBox_TextChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AvailableDaysChecklist_SelectedIndexChanged(object sender, EventArgs e) { }
        private void StartTimeDatePicker_ValueChanged(object sender, EventArgs e) { }
        private void EndTimeDatePicker_ValueChanged(object sender, EventArgs e) { }
        private void FirstNameLabel_Click(object sender, EventArgs e) { }
        private void LastNameLabel_Click(object sender, EventArgs e) { }
        private void EndTimeLabel_Click(object sender, EventArgs e) { }
        private void EmailLabel_Click(object sender, EventArgs e) { }
        private void SpecializationLabel_Click(object sender, EventArgs e) { }
        private void ClinicLabel_Click(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }

        private void ConsultationFeeTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AdminDashboardForm form = new AdminDashboardForm(_admin);
            var result = form.ShowDialog();
        }

        private bool ValidatePhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;


            string cleanedPhone = Regex.Replace(phone, @"[\s\-\(\)]", "");

            // Must be exactly 11 digits
            if (cleanedPhone.Length != 11)
                return false;

            // Check if it's all digits
            if (!Regex.IsMatch(cleanedPhone, @"^\d+$"))
                return false;


            if (Regex.IsMatch(cleanedPhone, @"^01[0-9]{9}$"))
                return true;

            return false;
        }


        private void PhoneTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
