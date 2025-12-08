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
            this.panelScroll = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonalDetailsLabel = new System.Windows.Forms.Label();
            this.ContactInfoLabel = new System.Windows.Forms.Label();
            this.InsuranceLabel = new System.Windows.Forms.Label();
            this.MedicalHistoryLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DateOfBirthBox = new System.Windows.Forms.DateTimePicker();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmergencyContactLabel = new System.Windows.Forms.Label();
            this.EmergencyContactTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyNameTextbox = new System.Windows.Forms.TextBox();
            this.ExpiryDateLabel = new System.Windows.Forms.Label();
            this.ExpiryDateBox = new System.Windows.Forms.DateTimePicker();
            this.ConditionsLabel = new System.Windows.Forms.Label();
            this.ConditionsTextBox = new System.Windows.Forms.TextBox();
            this.AllergiesLabel = new System.Windows.Forms.Label();
            this.AllergiesTextBox = new System.Windows.Forms.TextBox();
            this.PastSurgeriesLabel = new System.Windows.Forms.Label();
            this.PastSurgeriesTextbox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.panelScroll.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelScroll
            // 
            this.panelScroll.AutoScroll = true;
            this.panelScroll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelScroll.Controls.Add(this.panelContainer);
            this.panelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScroll.Location = new System.Drawing.Point(0, 0);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1400, 900);
            this.panelScroll.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoSize = true;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.PersonalDetailsLabel);
            this.panelContainer.Controls.Add(this.ContactInfoLabel);
            this.panelContainer.Controls.Add(this.InsuranceLabel);
            this.panelContainer.Controls.Add(this.MedicalHistoryLabel);
            this.panelContainer.Controls.Add(this.FirstNameLabel);
            this.panelContainer.Controls.Add(this.FirstNameTextBox);
            this.panelContainer.Controls.Add(this.LastNameLabel);
            this.panelContainer.Controls.Add(this.LastNameTextBox);
            this.panelContainer.Controls.Add(this.PasswordLabel);
            this.panelContainer.Controls.Add(this.PasswordTextBox);
            this.panelContainer.Controls.Add(this.DateOfBirthLabel);
            this.panelContainer.Controls.Add(this.DateOfBirthBox);
            this.panelContainer.Controls.Add(this.GenderLabel);
            this.panelContainer.Controls.Add(this.GenderComboBox);
            this.panelContainer.Controls.Add(this.PhoneLabel);
            this.panelContainer.Controls.Add(this.PhoneTextBox);
            this.panelContainer.Controls.Add(this.EmailLabel);
            this.panelContainer.Controls.Add(this.EmailTextBox);
            this.panelContainer.Controls.Add(this.EmergencyContactLabel);
            this.panelContainer.Controls.Add(this.EmergencyContactTextBox);
            this.panelContainer.Controls.Add(this.AddressLabel);
            this.panelContainer.Controls.Add(this.CityLabel);
            this.panelContainer.Controls.Add(this.CityTextBox);
            this.panelContainer.Controls.Add(this.AreaLabel);
            this.panelContainer.Controls.Add(this.AreaTextBox);
            this.panelContainer.Controls.Add(this.StreetLabel);
            this.panelContainer.Controls.Add(this.StreetTextBox);
            this.panelContainer.Controls.Add(this.CompanyNameLabel);
            this.panelContainer.Controls.Add(this.CompanyNameTextbox);
            this.panelContainer.Controls.Add(this.ExpiryDateLabel);
            this.panelContainer.Controls.Add(this.ExpiryDateBox);
            this.panelContainer.Controls.Add(this.ConditionsLabel);
            this.panelContainer.Controls.Add(this.ConditionsTextBox);
            this.panelContainer.Controls.Add(this.AllergiesLabel);
            this.panelContainer.Controls.Add(this.AllergiesTextBox);
            this.panelContainer.Controls.Add(this.PastSurgeriesLabel);
            this.panelContainer.Controls.Add(this.PastSurgeriesTextbox);
            this.panelContainer.Controls.Add(this.ConfirmButton);
            this.panelContainer.Location = new System.Drawing.Point(350, 20);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelContainer.Size = new System.Drawing.Size(900, 770);
            this.panelContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(350, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGNUP";
            // 
            // PersonalDetailsLabel
            // 
            this.PersonalDetailsLabel.AutoSize = true;
            this.PersonalDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline);
            this.PersonalDetailsLabel.Location = new System.Drawing.Point(20, 60);
            this.PersonalDetailsLabel.Name = "PersonalDetailsLabel";
            this.PersonalDetailsLabel.Size = new System.Drawing.Size(182, 32);
            this.PersonalDetailsLabel.TabIndex = 1;
            this.PersonalDetailsLabel.Text = "Personal Details";
            // 
            // ContactInfoLabel
            // 
            this.ContactInfoLabel.AutoSize = true;
            this.ContactInfoLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline);
            this.ContactInfoLabel.Location = new System.Drawing.Point(20, 260);
            this.ContactInfoLabel.Name = "ContactInfoLabel";
            this.ContactInfoLabel.Size = new System.Drawing.Size(145, 32);
            this.ContactInfoLabel.TabIndex = 2;
            this.ContactInfoLabel.Text = "Contact Info";
            // 
            // InsuranceLabel
            // 
            this.InsuranceLabel.AutoSize = true;
            this.InsuranceLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline);
            this.InsuranceLabel.Location = new System.Drawing.Point(20, 430);
            this.InsuranceLabel.Name = "InsuranceLabel";
            this.InsuranceLabel.Size = new System.Drawing.Size(116, 32);
            this.InsuranceLabel.TabIndex = 3;
            this.InsuranceLabel.Text = "Insurance";
            // 
            // MedicalHistoryLabel
            // 
            this.MedicalHistoryLabel.AutoSize = true;
            this.MedicalHistoryLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Underline);
            this.MedicalHistoryLabel.Location = new System.Drawing.Point(20, 540);
            this.MedicalHistoryLabel.Name = "MedicalHistoryLabel";
            this.MedicalHistoryLabel.Size = new System.Drawing.Size(180, 32);
            this.MedicalHistoryLabel.TabIndex = 4;
            this.MedicalHistoryLabel.Text = "Medical History";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FirstNameLabel.Location = new System.Drawing.Point(20, 110);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(72, 16);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(150, 110);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.FirstNameTextBox.TabIndex = 6;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LastNameLabel.Location = new System.Drawing.Point(20, 150);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(72, 16);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(150, 150);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.LastNameTextBox.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasswordLabel.Location = new System.Drawing.Point(20, 190);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(150, 190);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 22);
            this.PasswordTextBox.TabIndex = 10;
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(20, 230);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(79, 16);
            this.DateOfBirthLabel.TabIndex = 11;
            this.DateOfBirthLabel.Text = "Date of Birth";
            // 
            // DateOfBirthBox
            // 
            this.DateOfBirthBox.Location = new System.Drawing.Point(150, 230);
            this.DateOfBirthBox.Name = "DateOfBirthBox";
            this.DateOfBirthBox.Size = new System.Drawing.Size(200, 22);
            this.DateOfBirthBox.TabIndex = 12;
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GenderLabel.Location = new System.Drawing.Point(400, 110);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(52, 16);
            this.GenderLabel.TabIndex = 13;
            this.GenderLabel.Text = "Gender";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Location = new System.Drawing.Point(500, 110);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(150, 24);
            this.GenderComboBox.TabIndex = 14;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PhoneLabel.Location = new System.Drawing.Point(20, 310);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(46, 16);
            this.PhoneLabel.TabIndex = 15;
            this.PhoneLabel.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(150, 310);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.PhoneTextBox.TabIndex = 16;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmailLabel.Location = new System.Drawing.Point(20, 350);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 16);
            this.EmailLabel.TabIndex = 17;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(150, 350);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(200, 22);
            this.EmailTextBox.TabIndex = 18;
            // 
            // EmergencyContactLabel
            // 
            this.EmergencyContactLabel.AutoSize = true;
            this.EmergencyContactLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmergencyContactLabel.Location = new System.Drawing.Point(20, 390);
            this.EmergencyContactLabel.Name = "EmergencyContactLabel";
            this.EmergencyContactLabel.Size = new System.Drawing.Size(124, 16);
            this.EmergencyContactLabel.TabIndex = 19;
            this.EmergencyContactLabel.Text = "Emergency Contact";
            // 
            // EmergencyContactTextBox
            // 
            this.EmergencyContactTextBox.Location = new System.Drawing.Point(200, 390);
            this.EmergencyContactTextBox.Name = "EmergencyContactTextBox";
            this.EmergencyContactTextBox.Size = new System.Drawing.Size(200, 22);
            this.EmergencyContactTextBox.TabIndex = 20;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddressLabel.Location = new System.Drawing.Point(400, 260);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(87, 28);
            this.AddressLabel.TabIndex = 21;
            this.AddressLabel.Text = "Address";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CityLabel.Location = new System.Drawing.Point(400, 310);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(29, 16);
            this.CityLabel.TabIndex = 22;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(500, 310);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(200, 22);
            this.CityTextBox.TabIndex = 23;
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AreaLabel.Location = new System.Drawing.Point(400, 350);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(36, 16);
            this.AreaLabel.TabIndex = 24;
            this.AreaLabel.Text = "Area";
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(500, 350);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(200, 22);
            this.AreaTextBox.TabIndex = 25;
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StreetLabel.Location = new System.Drawing.Point(400, 390);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(42, 16);
            this.StreetLabel.TabIndex = 26;
            this.StreetLabel.Text = "Street";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(500, 390);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(200, 22);
            this.StreetTextBox.TabIndex = 27;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CompanyNameLabel.Location = new System.Drawing.Point(20, 480);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(105, 16);
            this.CompanyNameLabel.TabIndex = 28;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // CompanyNameTextbox
            // 
            this.CompanyNameTextbox.Location = new System.Drawing.Point(170, 480);
            this.CompanyNameTextbox.Name = "CompanyNameTextbox";
            this.CompanyNameTextbox.Size = new System.Drawing.Size(200, 22);
            this.CompanyNameTextbox.TabIndex = 29;
            // 
            // ExpiryDateLabel
            // 
            this.ExpiryDateLabel.AutoSize = true;
            this.ExpiryDateLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExpiryDateLabel.Location = new System.Drawing.Point(20, 520);
            this.ExpiryDateLabel.Name = "ExpiryDateLabel";
            this.ExpiryDateLabel.Size = new System.Drawing.Size(76, 16);
            this.ExpiryDateLabel.TabIndex = 30;
            this.ExpiryDateLabel.Text = "Expiry Date";
            // 
            // ExpiryDateBox
            // 
            this.ExpiryDateBox.Location = new System.Drawing.Point(170, 520);
            this.ExpiryDateBox.Name = "ExpiryDateBox";
            this.ExpiryDateBox.Size = new System.Drawing.Size(200, 22);
            this.ExpiryDateBox.TabIndex = 31;
            // 
            // ConditionsLabel
            // 
            this.ConditionsLabel.AutoSize = true;
            this.ConditionsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConditionsLabel.Location = new System.Drawing.Point(20, 590);
            this.ConditionsLabel.Name = "ConditionsLabel";
            this.ConditionsLabel.Size = new System.Drawing.Size(70, 16);
            this.ConditionsLabel.TabIndex = 32;
            this.ConditionsLabel.Text = "Conditions";
            // 
            // ConditionsTextBox
            // 
            this.ConditionsTextBox.Location = new System.Drawing.Point(150, 590);
            this.ConditionsTextBox.Name = "ConditionsTextBox";
            this.ConditionsTextBox.Size = new System.Drawing.Size(200, 22);
            this.ConditionsTextBox.TabIndex = 33;
            // 
            // AllergiesLabel
            // 
            this.AllergiesLabel.AutoSize = true;
            this.AllergiesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllergiesLabel.Location = new System.Drawing.Point(20, 630);
            this.AllergiesLabel.Name = "AllergiesLabel";
            this.AllergiesLabel.Size = new System.Drawing.Size(60, 16);
            this.AllergiesLabel.TabIndex = 34;
            this.AllergiesLabel.Text = "Allergies";
            // 
            // AllergiesTextBox
            // 
            this.AllergiesTextBox.Location = new System.Drawing.Point(150, 630);
            this.AllergiesTextBox.Name = "AllergiesTextBox";
            this.AllergiesTextBox.Size = new System.Drawing.Size(200, 22);
            this.AllergiesTextBox.TabIndex = 35;
            // 
            // PastSurgeriesLabel
            // 
            this.PastSurgeriesLabel.AutoSize = true;
            this.PastSurgeriesLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PastSurgeriesLabel.Location = new System.Drawing.Point(20, 670);
            this.PastSurgeriesLabel.Name = "PastSurgeriesLabel";
            this.PastSurgeriesLabel.Size = new System.Drawing.Size(95, 16);
            this.PastSurgeriesLabel.TabIndex = 36;
            this.PastSurgeriesLabel.Text = "Past Surgeries";
            // 
            // PastSurgeriesTextbox
            // 
            this.PastSurgeriesTextbox.Location = new System.Drawing.Point(150, 670);
            this.PastSurgeriesTextbox.Name = "PastSurgeriesTextbox";
            this.PastSurgeriesTextbox.Size = new System.Drawing.Size(200, 22);
            this.PastSurgeriesTextbox.TabIndex = 37;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.HotPink;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ConfirmButton.ForeColor = System.Drawing.Color.White;
            this.ConfirmButton.Location = new System.Drawing.Point(650, 700);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(180, 45);
            this.ConfirmButton.TabIndex = 38;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panelScroll);
            this.Name = "SignupForm";
            this.Text = "Signup Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.panelScroll.ResumeLayout(false);
            this.panelScroll.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
