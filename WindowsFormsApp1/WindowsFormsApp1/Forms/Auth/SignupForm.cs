using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Forms.Admin;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms.Auth
{
    public partial class SignupForm : Form
    {
        private readonly MongoDBService _db;

        public SignupForm()
        {
            InitializeComponent();
            _db = new MongoDBService();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            GenderComboBox.Items.Clear();
            GenderComboBox.Items.Add("Male");
            GenderComboBox.Items.Add("Female");
            GenderComboBox.SelectedIndex = 0;
        }

        // Phone validation for Egyptian mobile numbers - ONLY 11 DIGITS STARTING WITH 01
        private bool ValidatePhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // Remove spaces, dashes, parentheses
            string cleanedPhone = Regex.Replace(phone, @"[\s\-\(\)]", "");

            // Must be exactly 11 digits
            if (cleanedPhone.Length != 11)
                return false;

            // Check if it's all digits
            if (!Regex.IsMatch(cleanedPhone, @"^\d+$"))
                return false;

            // Egyptian mobile numbers: EXACTLY 11 digits starting with 01 (e.g., 01012345678)
            if (Regex.IsMatch(cleanedPhone, @"^01[0-9]{9}$"))
                return true;

            return false;
        }

        // Strong password validation
        private bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            // Password requirements:
            // 1. At least 8 characters
            if (password.Length < 8)
                return false;

            // 2. At least one uppercase letter
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;

            // 3. At least one lowercase letter
            if (!Regex.IsMatch(password, @"[a-z]"))
                return false;

            // 4. At least one digit
            if (!Regex.IsMatch(password, @"[0-9]"))
                return false;

           

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();
            string gender = GenderComboBox.Text.Trim();
            string phone = PhoneTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string emergencyContact = EmergencyContactTextBox.Text.Trim();

            string area = AreaTextBox.Text.Trim();
            string city = CityTextBox.Text.Trim();
            string street = StreetTextBox.Text.Trim();

            string insuranceCompany = CompanyNameTextbox.Text.Trim();
            string insuranceExpiry = ExpiryDateBox.Value.ToString("yyyy-MM-dd");

            string conditions = ConditionsTextBox.Text.Trim();
            string allergies = AllergiesTextBox.Text.Trim();
            string pastSurgeries = PastSurgeriesTextbox.Text.Trim();

            DateTime dob = DateOfBirthBox.Value;
            int age = CalculateAge(dob);

            // Basic validation - required fields
            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(gender) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(area) ||
                string.IsNullOrEmpty(city) ||
                string.IsNullOrEmpty(street))
            {
                MessageBox.Show("All required fields must be filled.", "Validation Error");
                return;
            }

            // Email validation
            try
            {
                var m = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Invalid email format.", "Validation Error");
                return;
            }

            // Phone validation - ONLY 11 DIGITS STARTING WITH 01
            if (!ValidatePhoneNumber(phone))
            {
                MessageBox.Show("Invalid phone number. Please enter a valid 11-digit Egyptian mobile number starting with 01 (e.g., 01012345678).", "Validation Error");
                return;
            }

            // Emergency contact validation (if provided) - ONLY 11 DIGITS STARTING WITH 01
            if (!string.IsNullOrEmpty(emergencyContact) && !ValidatePhoneNumber(emergencyContact))
            {
                MessageBox.Show("Invalid emergency contact number. Please enter a valid 11-digit Egyptian mobile number starting with 01.", "Validation Error");
                return;
            }

            // Password validation
            if (!ValidatePassword(password))
            {
                MessageBox.Show("Password must be at least 8 characters long and contain:\n• At least one uppercase letter\n• At least one lowercase letter\n• At least one digit", "Validation Error");
                return;
            }

            // Check if email already exists
            var users = _db.GetCollection<User>("users");
            if (users.Find(u => u.Email == email).FirstOrDefault() != null)
            {
                MessageBox.Show("Email already exists.", "Validation Error");
                return;
            }

            User newUser = new User
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Email = email,
                Password = password,
                Role = "patient"
            };

            users.InsertOne(newUser);

            var patients = _db.GetCollection<WindowsFormsApp1.Models.Patient>("patients");

            Models.Patient p = new Models.Patient
            {
                Id = ObjectId.GenerateNewId().ToString(),
                UserId = newUser.Id,
                FirstName = firstName,
                LastName = lastName,
                Gender = gender,
                Age = age,
                AppointmentId = null,

                ContactInfo = new ContactInfo
                {
                    Phone = phone,
                    Email = email,
                    EmergencyContact = emergencyContact,
                    Address = new Address
                    {
                        Area = area,
                        City = city,
                        Street = street
                    }
                },

                Insurance = new Insurance
                {
                    Company = insuranceCompany,
                    ExpiryDate = insuranceExpiry
                },

                MedicalHistory = new MedicalHistory
                {
                    Conditions = conditions.Split(',').Where(x => !string.IsNullOrWhiteSpace(x)).ToList(),
                    Allergies = allergies.Split(',').Where(x => !string.IsNullOrWhiteSpace(x)).ToList(),
                    PastSurgeries = pastSurgeries.Split(',').Where(x => !string.IsNullOrWhiteSpace(x)).ToList()
                }
            };

            patients.InsertOne(p);

            MessageBox.Show("Signup successful!", "Success");

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private int CalculateAge(DateTime dob)
        {
            int age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now < dob.AddYears(age)) age--;
            return age;
        }

        private void label3_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }

        private void label8_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click_1(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e) { }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e) { }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e) { }

        private void DateOfBirthBox_ValueChanged(object sender, EventArgs e) { }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e) { }

        private void EmailTextBox_TextChanged(object sender, EventArgs e) { }

        private void EmergencyContactTextBox_TextChanged(object sender, EventArgs e) { }

        private void CompanyNameTextbox_TextChanged(object sender, EventArgs e) { }

        private void ExpiryDateBox_ValueChanged(object sender, EventArgs e) { }

        private void CityTextBox_TextChanged(object sender, EventArgs e) { }

        private void AreaTextBox_TextChanged(object sender, EventArgs e) { }

        private void StreetTextBox_TextChanged(object sender, EventArgs e) { }

        private void ConditionsTextBox_TextChanged(object sender, EventArgs e) { }

        private void AllergiesTextBox_TextChanged(object sender, EventArgs e) { }

        private void PastSurgeriesTextbox_TextChanged(object sender, EventArgs e) { }

        private void CityTextBox_TextChanged_1(object sender, EventArgs e) { }

        private void panelScroll_Paint(object sender, PaintEventArgs e) { }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            var result = form.ShowDialog();
        }
    }
}