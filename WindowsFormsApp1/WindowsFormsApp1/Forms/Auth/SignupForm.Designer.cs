namespace WindowsFormsApp1.Forms.Auth
{
    partial class SignupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PersonalDetailsLabel = new System.Windows.Forms.Label();
            this.ContactInfoLabel = new System.Windows.Forms.Label();
            this.InsuranceLabel = new System.Windows.Forms.Label();
            this.MedicalHistoryLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
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
            this.StreetLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.ExpiryDateLabel = new System.Windows.Forms.Label();
            this.CompanyNameTextbox = new System.Windows.Forms.TextBox();
            this.ExpiryDateBox = new System.Windows.Forms.DateTimePicker();
            this.ConditionsLabel = new System.Windows.Forms.Label();
            this.ConditionsTextBox = new System.Windows.Forms.TextBox();
            this.AllergiesLabel = new System.Windows.Forms.Label();
            this.AllergiesTextBox = new System.Windows.Forms.TextBox();
            this.PastSurgeriesLabel = new System.Windows.Forms.Label();
            this.PastSurgeriesTextbox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGNUP";
            // 
            // PersonalDetailsLabel
            // 
            this.PersonalDetailsLabel.AutoSize = true;
            this.PersonalDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalDetailsLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.PersonalDetailsLabel.Location = new System.Drawing.Point(12, 48);
            this.PersonalDetailsLabel.Name = "PersonalDetailsLabel";
            this.PersonalDetailsLabel.Size = new System.Drawing.Size(189, 29);
            this.PersonalDetailsLabel.TabIndex = 1;
            this.PersonalDetailsLabel.Text = "Personal Details";
            // 
            // ContactInfoLabel
            // 
            this.ContactInfoLabel.AutoSize = true;
            this.ContactInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactInfoLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.ContactInfoLabel.Location = new System.Drawing.Point(23, 288);
            this.ContactInfoLabel.Name = "ContactInfoLabel";
            this.ContactInfoLabel.Size = new System.Drawing.Size(139, 29);
            this.ContactInfoLabel.TabIndex = 2;
            this.ContactInfoLabel.Text = "Contact Info";
            this.ContactInfoLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // InsuranceLabel
            // 
            this.InsuranceLabel.AutoSize = true;
            this.InsuranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuranceLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.InsuranceLabel.Location = new System.Drawing.Point(24, 458);
            this.InsuranceLabel.Name = "InsuranceLabel";
            this.InsuranceLabel.Size = new System.Drawing.Size(117, 29);
            this.InsuranceLabel.TabIndex = 3;
            this.InsuranceLabel.Text = "Insurance";
            // 
            // MedicalHistoryLabel
            // 
            this.MedicalHistoryLabel.AutoSize = true;
            this.MedicalHistoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicalHistoryLabel.ForeColor = System.Drawing.Color.BlueViolet;
            this.MedicalHistoryLabel.Location = new System.Drawing.Point(12, 566);
            this.MedicalHistoryLabel.Name = "MedicalHistoryLabel";
            this.MedicalHistoryLabel.Size = new System.Drawing.Size(178, 29);
            this.MedicalHistoryLabel.TabIndex = 4;
            this.MedicalHistoryLabel.Text = "Medical History";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(124, 85);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.FirstNameTextBox.TabIndex = 5;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(25, 88);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(82, 16);
            this.FirstNameLabel.TabIndex = 6;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(25, 128);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(81, 16);
            this.LastNameLabel.TabIndex = 7;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(124, 128);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.LastNameTextBox.TabIndex = 8;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(26, 172);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(75, 16);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(124, 172);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(176, 22);
            this.PasswordTextBox.TabIndex = 10;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(26, 212);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(92, 16);
            this.DateOfBirthLabel.TabIndex = 11;
            this.DateOfBirthLabel.Text = "Date of Birth";
            // 
            // DateOfBirthBox
            // 
            this.DateOfBirthBox.Location = new System.Drawing.Point(124, 207);
            this.DateOfBirthBox.Name = "DateOfBirthBox";
            this.DateOfBirthBox.Size = new System.Drawing.Size(232, 22);
            this.DateOfBirthBox.TabIndex = 12;
            this.DateOfBirthBox.ValueChanged += new System.EventHandler(this.DateOfBirthBox_ValueChanged);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLabel.Location = new System.Drawing.Point(26, 253);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(58, 16);
            this.GenderLabel.TabIndex = 13;
            this.GenderLabel.Text = "Gender";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(124, 245);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(121, 24);
            this.GenderComboBox.TabIndex = 14;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(26, 331);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(51, 16);
            this.PhoneLabel.TabIndex = 15;
            this.PhoneLabel.Text = "Phone";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(124, 328);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(176, 22);
            this.PhoneTextBox.TabIndex = 16;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(26, 371);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 16);
            this.EmailLabel.TabIndex = 17;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(124, 371);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(176, 22);
            this.EmailTextBox.TabIndex = 18;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // EmergencyContactLabel
            // 
            this.EmergencyContactLabel.AutoSize = true;
            this.EmergencyContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmergencyContactLabel.Location = new System.Drawing.Point(26, 414);
            this.EmergencyContactLabel.Name = "EmergencyContactLabel";
            this.EmergencyContactLabel.Size = new System.Drawing.Size(141, 16);
            this.EmergencyContactLabel.TabIndex = 19;
            this.EmergencyContactLabel.Text = "Emergency Contact";
            this.EmergencyContactLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmergencyContactTextBox
            // 
            this.EmergencyContactTextBox.Location = new System.Drawing.Point(180, 411);
            this.EmergencyContactTextBox.Name = "EmergencyContactTextBox";
            this.EmergencyContactTextBox.Size = new System.Drawing.Size(176, 22);
            this.EmergencyContactTextBox.TabIndex = 20;
            this.EmergencyContactTextBox.TextChanged += new System.EventHandler(this.EmergencyContactTextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.AddressLabel.Location = new System.Drawing.Point(412, 315);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(69, 18);
            this.AddressLabel.TabIndex = 21;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(428, 351);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(33, 16);
            this.CityLabel.TabIndex = 22;
            this.CityLabel.Text = "City";
            this.CityLabel.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(491, 345);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(176, 22);
            this.CityTextBox.TabIndex = 23;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StreetLabel.Location = new System.Drawing.Point(428, 429);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(48, 16);
            this.StreetLabel.TabIndex = 24;
            this.StreetLabel.Text = "Street";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLabel.Location = new System.Drawing.Point(428, 387);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(40, 16);
            this.AreaLabel.TabIndex = 25;
            this.AreaLabel.Text = "Area";
            this.AreaLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(491, 426);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(176, 22);
            this.StreetTextBox.TabIndex = 26;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(491, 387);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(176, 22);
            this.AreaTextBox.TabIndex = 27;
            this.AreaTextBox.TextChanged += new System.EventHandler(this.AreaTextBox_TextChanged);
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(21, 503);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(117, 16);
            this.CompanyNameLabel.TabIndex = 28;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // ExpiryDateLabel
            // 
            this.ExpiryDateLabel.AutoSize = true;
            this.ExpiryDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDateLabel.Location = new System.Drawing.Point(21, 537);
            this.ExpiryDateLabel.Name = "ExpiryDateLabel";
            this.ExpiryDateLabel.Size = new System.Drawing.Size(87, 16);
            this.ExpiryDateLabel.TabIndex = 29;
            this.ExpiryDateLabel.Text = "Expiry Date";
            // 
            // CompanyNameTextbox
            // 
            this.CompanyNameTextbox.Location = new System.Drawing.Point(180, 497);
            this.CompanyNameTextbox.Name = "CompanyNameTextbox";
            this.CompanyNameTextbox.Size = new System.Drawing.Size(176, 22);
            this.CompanyNameTextbox.TabIndex = 30;
            this.CompanyNameTextbox.TextChanged += new System.EventHandler(this.CompanyNameTextbox_TextChanged);
            // 
            // ExpiryDateBox
            // 
            this.ExpiryDateBox.Location = new System.Drawing.Point(180, 537);
            this.ExpiryDateBox.Name = "ExpiryDateBox";
            this.ExpiryDateBox.Size = new System.Drawing.Size(232, 22);
            this.ExpiryDateBox.TabIndex = 31;
            this.ExpiryDateBox.ValueChanged += new System.EventHandler(this.ExpiryDateBox_ValueChanged);
            // 
            // ConditionsLabel
            // 
            this.ConditionsLabel.AutoSize = true;
            this.ConditionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionsLabel.Location = new System.Drawing.Point(21, 601);
            this.ConditionsLabel.Name = "ConditionsLabel";
            this.ConditionsLabel.Size = new System.Drawing.Size(80, 16);
            this.ConditionsLabel.TabIndex = 32;
            this.ConditionsLabel.Text = "Conditions";
            // 
            // ConditionsTextBox
            // 
            this.ConditionsTextBox.Location = new System.Drawing.Point(136, 598);
            this.ConditionsTextBox.Name = "ConditionsTextBox";
            this.ConditionsTextBox.Size = new System.Drawing.Size(176, 22);
            this.ConditionsTextBox.TabIndex = 33;
            this.ConditionsTextBox.TextChanged += new System.EventHandler(this.ConditionsTextBox_TextChanged);
            // 
            // AllergiesLabel
            // 
            this.AllergiesLabel.AutoSize = true;
            this.AllergiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllergiesLabel.Location = new System.Drawing.Point(25, 633);
            this.AllergiesLabel.Name = "AllergiesLabel";
            this.AllergiesLabel.Size = new System.Drawing.Size(69, 16);
            this.AllergiesLabel.TabIndex = 34;
            this.AllergiesLabel.Text = "Allergies";
            // 
            // AllergiesTextBox
            // 
            this.AllergiesTextBox.Location = new System.Drawing.Point(136, 633);
            this.AllergiesTextBox.Name = "AllergiesTextBox";
            this.AllergiesTextBox.Size = new System.Drawing.Size(176, 22);
            this.AllergiesTextBox.TabIndex = 35;
            this.AllergiesTextBox.TextChanged += new System.EventHandler(this.AllergiesTextBox_TextChanged);
            // 
            // PastSurgeriesLabel
            // 
            this.PastSurgeriesLabel.AutoSize = true;
            this.PastSurgeriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PastSurgeriesLabel.Location = new System.Drawing.Point(26, 670);
            this.PastSurgeriesLabel.Name = "PastSurgeriesLabel";
            this.PastSurgeriesLabel.Size = new System.Drawing.Size(144, 16);
            this.PastSurgeriesLabel.TabIndex = 36;
            this.PastSurgeriesLabel.Text = "Any past surgeries?";
            // 
            // PastSurgeriesTextbox
            // 
            this.PastSurgeriesTextbox.Location = new System.Drawing.Point(180, 670);
            this.PastSurgeriesTextbox.Name = "PastSurgeriesTextbox";
            this.PastSurgeriesTextbox.Size = new System.Drawing.Size(176, 22);
            this.PastSurgeriesTextbox.TabIndex = 37;
            this.PastSurgeriesTextbox.TextChanged += new System.EventHandler(this.PastSurgeriesTextbox_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ConfirmButton.Location = new System.Drawing.Point(695, 664);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(137, 42);
            this.ConfirmButton.TabIndex = 38;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(911, 718);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.PastSurgeriesTextbox);
            this.Controls.Add(this.PastSurgeriesLabel);
            this.Controls.Add(this.AllergiesTextBox);
            this.Controls.Add(this.AllergiesLabel);
            this.Controls.Add(this.ConditionsTextBox);
            this.Controls.Add(this.ConditionsLabel);
            this.Controls.Add(this.ExpiryDateBox);
            this.Controls.Add(this.CompanyNameTextbox);
            this.Controls.Add(this.ExpiryDateLabel);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EmergencyContactTextBox);
            this.Controls.Add(this.EmergencyContactLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.DateOfBirthBox);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.MedicalHistoryLabel);
            this.Controls.Add(this.InsuranceLabel);
            this.Controls.Add(this.ContactInfoLabel);
            this.Controls.Add(this.PersonalDetailsLabel);
            this.Controls.Add(this.label1);
            this.Name = "SignupForm";
            this.Text = "Signup Page";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Label CityLabel;
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
    }
}