using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using ClinicalBookingSystem.Services;
using MongoDB.Driver;

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
            // Gender options
            GenderComboBox.Items.Clear();
            GenderComboBox.Items.Add("Male");
            GenderComboBox.Items.Add("Female");
           

            GenderComboBox.SelectedIndex = 0;
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

            // Email format validation
            try
            {
                var m = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                MessageBox.Show("Invalid email format.", "Validation Error");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error");
                return;
            }

            // Unique email check
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
    }
}
