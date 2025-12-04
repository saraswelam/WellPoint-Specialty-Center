using ClinicalBookingSystem.Services;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms.Admin;
using WindowsFormsApp1.Forms.Doctor;
using WindowsFormsApp1.Forms.Patient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WindowsFormsApp1.Models; 
//using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Forms.Auth
{

    public partial class LoginForm : Form
    {
        private readonly MongoDBService _db;

        public LoginForm()
        {

            InitializeComponent();
            _db = new MongoDBService();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            // 1) Empty fields check
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email field cannot be empty.", "Validation Error");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password field cannot be empty.", "Validation Error");
                return;
            }


            // 2) Email format validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error");
                return;
            }

            // 3) Optional: Minimum password rules for login (not signup)
            if (password.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters long.", "Validation Error");
                return;
            }

            // 4) Attempt to log in
            var users = _db.GetCollection<User>("users");
            var user = users.Find(u => u.Email == email && u.Password == password).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show("Incorrect email or password.", "Login Failed");
                return;
            }




            // 5) Redirect based on user role
            switch (user.Role)
            {
                case "patient":
                    LoadPatient(user.Id);
                    break;

                case "doctor":
                    LoadDoctor(user.Id);
                    break;

                case "admin":
                    LoadAdmin(user.Id);
                    break;

                default:
                    MessageBox.Show("Unknown user role detected.");
                    break;
            }
        }


        private void LoadPatient(string userId)
        {
            var patients = _db.GetCollection<WindowsFormsApp1.Models.Patient>("patients");
            var patient = patients.Find(p => p.UserId == userId).FirstOrDefault();

            if (patient == null)
            {
                MessageBox.Show("Patient profile not found.");
                return;
            }

            PatientHomePageForm form = new PatientHomePageForm(patient);
            form.Show();
            this.Hide();
        }


        private void LoadDoctor(string userId)
        {
            var doctors = _db.GetCollection<WindowsFormsApp1.Models.Doctor>("doctors");
            var doctor = doctors.Find(d => d.UserId == userId).FirstOrDefault();

            if (doctor == null)
            {
                MessageBox.Show("Doctor profile not found.");
                return;
            }


            DoctorDashboardForm form = new DoctorDashboardForm(doctor);
            form.Show();
            this.Hide();
        }


        private void LoadAdmin(string userId)
        {
            var admins = _db.GetCollection<WindowsFormsApp1.Models.Admin>("admins");
            var admin = admins.Find(a => a.UserId == userId).FirstOrDefault();

            if (admin == null)
            {
                MessageBox.Show("Admin profile not found.");
                return;
            }

            AdminDashboardForm form = new AdminDashboardForm(admin);
            form.Show();
            this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {

                return false;
            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WellPointSpecialtyCenterLabel_Click(object sender, EventArgs e)
        {
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignupForm signup = new SignupForm();
            signup.Show();
            this.Hide();

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
