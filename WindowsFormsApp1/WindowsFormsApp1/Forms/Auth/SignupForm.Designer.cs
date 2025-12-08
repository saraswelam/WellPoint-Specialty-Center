using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Auth
{
    partial class SignupForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelScroll;
        private System.Windows.Forms.Panel panelContainer;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PersonalDetailsLabel;
        private System.Windows.Forms.Label ContactInfoLabel;
        private System.Windows.Forms.Label InsuranceLabel;
        private System.Windows.Forms.Label MedicalHistoryLabel;

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;

        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;

        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker DateOfBirthBox;

        private System.Windows.Forms.Label GenderLabel;
        private System.Windows.Forms.ComboBox GenderComboBox;

        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;

        private System.Windows.Forms.Label EmergencyContactLabel;
        private System.Windows.Forms.TextBox EmergencyContactTextBox;

        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;

        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.TextBox AreaTextBox;

        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox StreetTextBox;

        private System.Windows.Forms.Label CompanyNameLabel;
        private System.Windows.Forms.Label ExpiryDateLabel;
        private System.Windows.Forms.TextBox CompanyNameTextbox;
        private System.Windows.Forms.DateTimePicker ExpiryDateBox;

        private System.Windows.Forms.Label ConditionsLabel;
        private System.Windows.Forms.TextBox ConditionsTextBox;

        private System.Windows.Forms.Label AllergiesLabel;
        private System.Windows.Forms.TextBox AllergiesTextBox;

        private System.Windows.Forms.Label PastSurgeriesLabel;
        private System.Windows.Forms.TextBox PastSurgeriesTextbox;

        private System.Windows.Forms.Button ConfirmButton;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ---------------- FORM ----------------
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Text = "Signup Page";
            this.Load += new System.EventHandler(this.SignupForm_Load);

            // ---------------- PANEL SCROLL ----------------
            this.panelScroll = new System.Windows.Forms.Panel();
            this.panelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScroll.AutoScroll = true;
            this.panelScroll.BackColor = System.Drawing.Color.WhiteSmoke;

            // ---------------- PANEL CONTAINER ----------------
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelContainer.Width = 900;
            this.panelContainer.AutoSize = true;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelContainer.Location = new System.Drawing.Point(350, 20); // centered visually

            // ---------------- TITLE ----------------
            this.label1 = new System.Windows.Forms.Label();
            this.label1.Text = "SIGNUP";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(350, 10);
            this.label1.AutoSize = true;

            // ---------------- SECTION TITLES ----------------
            this.PersonalDetailsLabel = new Label();
            this.PersonalDetailsLabel.Text = "Personal Details";
            this.PersonalDetailsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            this.PersonalDetailsLabel.Location = new Point(20, 60);
            this.PersonalDetailsLabel.AutoSize = true;

            this.ContactInfoLabel = new Label();
            this.ContactInfoLabel.Text = "Contact Info";
            this.ContactInfoLabel.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            this.ContactInfoLabel.Location = new Point(20, 260);
            this.ContactInfoLabel.AutoSize = true;

            this.InsuranceLabel = new Label();
            this.InsuranceLabel.Text = "Insurance";
            this.InsuranceLabel.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            this.InsuranceLabel.Location = new Point(20, 430);
            this.InsuranceLabel.AutoSize = true;

            this.MedicalHistoryLabel = new Label();
            this.MedicalHistoryLabel.Text = "Medical History";
            this.MedicalHistoryLabel.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
            this.MedicalHistoryLabel.Location = new Point(20, 540);
            this.MedicalHistoryLabel.AutoSize = true;

            // ---------------- PERSONAL DETAILS CONTROLS ----------------
            this.FirstNameLabel = new Label();
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.Location = new Point(20, 110);
            this.FirstNameLabel.AutoSize = true;

            this.FirstNameTextBox = new TextBox();
            this.FirstNameTextBox.Location = new Point(150, 110);
            this.FirstNameTextBox.Width = 200;

            this.LastNameLabel = new Label();
            this.LastNameLabel.Text = "Last Name";
            this.LastNameLabel.Location = new Point(20, 150);
            this.LastNameLabel.AutoSize = true;

            this.LastNameTextBox = new TextBox();
            this.LastNameTextBox.Location = new Point(150, 150);
            this.LastNameTextBox.Width = 200;

            this.PasswordLabel = new Label();
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Location = new Point(20, 190);
            this.PasswordLabel.AutoSize = true;

            this.PasswordTextBox = new TextBox();
            this.PasswordTextBox.Location = new Point(150, 190);
            this.PasswordTextBox.Width = 200;

            this.DateOfBirthLabel = new Label();
            this.DateOfBirthLabel.Text = "Date of Birth";
            this.DateOfBirthLabel.Location = new Point(20, 230);
            this.DateOfBirthLabel.AutoSize = true;

            this.DateOfBirthBox = new DateTimePicker();
            this.DateOfBirthBox.Location = new Point(150, 230);
            this.DateOfBirthBox.Width = 200;

            this.GenderLabel = new Label();
            this.GenderLabel.Text = "Gender";
            this.GenderLabel.Location = new Point(400, 110);
            this.GenderLabel.AutoSize = true;

            this.GenderComboBox = new ComboBox();
            this.GenderComboBox.Location = new Point(500, 110);
            this.GenderComboBox.Width = 150;

            // ---------------- CONTACT INFO ----------------
            this.PhoneLabel = new Label();
            this.PhoneLabel.Text = "Phone";
            this.PhoneLabel.Location = new Point(20, 310);
            this.PhoneLabel.AutoSize = true;

            this.PhoneTextBox = new TextBox();
            this.PhoneTextBox.Location = new Point(150, 310);
            this.PhoneTextBox.Width = 200;

            this.EmailLabel = new Label();
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Location = new Point(20, 350);
            this.EmailLabel.AutoSize = true;

            this.EmailTextBox = new TextBox();
            this.EmailTextBox.Location = new Point(150, 350);
            this.EmailTextBox.Width = 200;

            this.EmergencyContactLabel = new Label();
            this.EmergencyContactLabel.Text = "Emergency Contact";
            this.EmergencyContactLabel.Location = new Point(20, 390);
            this.EmergencyContactLabel.AutoSize = true;

            this.EmergencyContactTextBox = new TextBox();
            this.EmergencyContactTextBox.Location = new Point(200, 390);
            this.EmergencyContactTextBox.Width = 200;

            // ---------------- ADDRESS ----------------
            this.AddressLabel = new Label();
            this.AddressLabel.Text = "Address";
            this.AddressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.AddressLabel.Location = new Point(400, 260);
            this.AddressLabel.AutoSize = true;

            this.CityLabel = new Label();
            this.CityLabel.Text = "City";
            this.CityLabel.Location = new Point(400, 310);
            this.CityLabel.AutoSize = true;

            this.CityTextBox = new TextBox();
            this.CityTextBox.Location = new Point(500, 310);
            this.CityTextBox.Width = 200;

            this.AreaLabel = new Label();
            this.AreaLabel.Text = "Area";
            this.AreaLabel.Location = new Point(400, 350);
            this.AreaLabel.AutoSize = true;

            this.AreaTextBox = new TextBox();
            this.AreaTextBox.Location = new Point(500, 350);
            this.AreaTextBox.Width = 200;

            this.StreetLabel = new Label();
            this.StreetLabel.Text = "Street";
            this.StreetLabel.Location = new Point(400, 390);
            this.StreetLabel.AutoSize = true;

            this.StreetTextBox = new TextBox();
            this.StreetTextBox.Location = new Point(500, 390);
            this.StreetTextBox.Width = 200;

            // ---------------- INSURANCE ----------------
            this.CompanyNameLabel = new Label();
            this.CompanyNameLabel.Text = "Company Name";
            this.CompanyNameLabel.Location = new Point(20, 480);
            this.CompanyNameLabel.AutoSize = true;

            this.CompanyNameTextbox = new TextBox();
            this.CompanyNameTextbox.Location = new Point(170, 480);
            this.CompanyNameTextbox.Width = 200;

            this.ExpiryDateLabel = new Label();
            this.ExpiryDateLabel.Text = "Expiry Date";
            this.ExpiryDateLabel.Location = new Point(20, 520);
            this.ExpiryDateLabel.AutoSize = true;

            this.ExpiryDateBox = new DateTimePicker();
            this.ExpiryDateBox.Location = new Point(170, 520);
            this.ExpiryDateBox.Width = 200;

            // ---------------- MEDICAL HISTORY ----------------
            this.ConditionsLabel = new Label();
            this.ConditionsLabel.Text = "Conditions";
            this.ConditionsLabel.Location = new Point(20, 590);
            this.ConditionsLabel.AutoSize = true;

            this.ConditionsTextBox = new TextBox();
            this.ConditionsTextBox.Location = new Point(150, 590);
            this.ConditionsTextBox.Width = 200;

            this.AllergiesLabel = new Label();
            this.AllergiesLabel.Text = "Allergies";
            this.AllergiesLabel.Location = new Point(20, 630);
            this.AllergiesLabel.AutoSize = true;

            this.AllergiesTextBox = new TextBox();
            this.AllergiesTextBox.Location = new Point(150, 630);
            this.AllergiesTextBox.Width = 200;

            this.PastSurgeriesLabel = new Label();
            this.PastSurgeriesLabel.Text = "Past Surgeries";
            this.PastSurgeriesLabel.Location = new Point(20, 670);
            this.PastSurgeriesLabel.AutoSize = true;

            this.PastSurgeriesTextbox = new TextBox();
            this.PastSurgeriesTextbox.Location = new Point(150, 670);
            this.PastSurgeriesTextbox.Width = 200;

            // ---------------- CONFIRM BUTTON ----------------
            this.ConfirmButton = new Button();
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.ConfirmButton.FlatStyle = FlatStyle.Flat;
            this.ConfirmButton.Location = new Point(650, 700);
            this.ConfirmButton.Size = new Size(180, 45);
            this.ConfirmButton.Click += new System.EventHandler(this.button1_Click);

            // ---------------- ADD CONTROLS ----------------
            this.panelContainer.Controls.AddRange(new Control[]
            {
                label1, PersonalDetailsLabel, ContactInfoLabel, InsuranceLabel, MedicalHistoryLabel,

                FirstNameLabel, FirstNameTextBox,
                LastNameLabel, LastNameTextBox,
                PasswordLabel, PasswordTextBox,
                DateOfBirthLabel, DateOfBirthBox,
                GenderLabel, GenderComboBox,

                PhoneLabel, PhoneTextBox,
                EmailLabel, EmailTextBox,
                EmergencyContactLabel, EmergencyContactTextBox,

                AddressLabel, CityLabel, CityTextBox,
                AreaLabel, AreaTextBox,
                StreetLabel, StreetTextBox,

                CompanyNameLabel, CompanyNameTextbox,
                ExpiryDateLabel, ExpiryDateBox,

                ConditionsLabel, ConditionsTextBox,
                AllergiesLabel, AllergiesTextBox,
                PastSurgeriesLabel, PastSurgeriesTextbox,

                ConfirmButton
            });

            this.panelScroll.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelScroll);

            this.ResumeLayout(false);
        }
    }
}
