namespace WindowsFormsApp1.Forms.Admin
{
    partial class AddDoctorForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.BasicInfoLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.ConsultationFeeLabel = new System.Windows.Forms.Label();
            this.ConsultationFeeTextBox = new System.Windows.Forms.TextBox();
            this.SpecializationLabel = new System.Windows.Forms.Label();
            this.SpecializationComboBox = new System.Windows.Forms.ComboBox();
            this.ClinicLabel = new System.Windows.Forms.Label();
            this.ClinicComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CertificationsLabel = new System.Windows.Forms.Label();
            this.CertificationsTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AvailableDaysLabel = new System.Windows.Forms.Label();
            this.AvailableDaysChecklist = new System.Windows.Forms.CheckedListBox();
            this.WorkingHoursLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddCertificationButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasicInfoLabel
            // 
            this.BasicInfoLabel.AutoSize = true;
            this.BasicInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BasicInfoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline);
            this.BasicInfoLabel.Location = new System.Drawing.Point(4, 81);
            this.BasicInfoLabel.Name = "BasicInfoLabel";
            this.BasicInfoLabel.Size = new System.Drawing.Size(150, 32);
            this.BasicInfoLabel.TabIndex = 0;
            this.BasicInfoLabel.Text = "Basic Info";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(189, 125);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(180, 22);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.FirstNameLabel.Location = new System.Drawing.Point(12, 135);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(107, 22);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.LastNameLabel.Location = new System.Drawing.Point(438, 125);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(105, 22);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(589, 125);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.EmailLabel.Location = new System.Drawing.Point(20, 180);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(59, 22);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(189, 180);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(180, 22);
            this.EmailTextBox.TabIndex = 6;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.Location = new System.Drawing.Point(438, 167);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(97, 22);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(589, 167);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(200, 22);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.PhoneLabel.Location = new System.Drawing.Point(12, 227);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(142, 22);
            this.PhoneLabel.TabIndex = 9;
            this.PhoneLabel.Text = "Phone Number";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(189, 227);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(180, 22);
            this.PhoneTextBox.TabIndex = 10;
            // 
            // ConsultationFeeLabel
            // 
            this.ConsultationFeeLabel.AutoSize = true;
            this.ConsultationFeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.ConsultationFeeLabel.Location = new System.Drawing.Point(438, 225);
            this.ConsultationFeeLabel.Name = "ConsultationFeeLabel";
            this.ConsultationFeeLabel.Size = new System.Drawing.Size(162, 22);
            this.ConsultationFeeLabel.TabIndex = 11;
            this.ConsultationFeeLabel.Text = "Consultation Fee";
            // 
            // ConsultationFeeTextBox
            // 
            this.ConsultationFeeTextBox.Location = new System.Drawing.Point(606, 225);
            this.ConsultationFeeTextBox.Name = "ConsultationFeeTextBox";
            this.ConsultationFeeTextBox.Size = new System.Drawing.Size(100, 22);
            this.ConsultationFeeTextBox.TabIndex = 12;
            this.ConsultationFeeTextBox.TextChanged += new System.EventHandler(this.ConsultationFeeTextBox_TextChanged_1);
            // 
            // SpecializationLabel
            // 
            this.SpecializationLabel.AutoSize = true;
            this.SpecializationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.SpecializationLabel.Location = new System.Drawing.Point(12, 278);
            this.SpecializationLabel.Name = "SpecializationLabel";
            this.SpecializationLabel.Size = new System.Drawing.Size(134, 22);
            this.SpecializationLabel.TabIndex = 13;
            this.SpecializationLabel.Text = "Specialization";
            // 
            // SpecializationComboBox
            // 
            this.SpecializationComboBox.Location = new System.Drawing.Point(189, 276);
            this.SpecializationComboBox.Name = "SpecializationComboBox";
            this.SpecializationComboBox.Size = new System.Drawing.Size(180, 24);
            this.SpecializationComboBox.TabIndex = 14;
            // 
            // ClinicLabel
            // 
            this.ClinicLabel.AutoSize = true;
            this.ClinicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.ClinicLabel.Location = new System.Drawing.Point(450, 274);
            this.ClinicLabel.Name = "ClinicLabel";
            this.ClinicLabel.Size = new System.Drawing.Size(60, 22);
            this.ClinicLabel.TabIndex = 15;
            this.ClinicLabel.Text = "Clinic";
            // 
            // ClinicComboBox
            // 
            this.ClinicComboBox.Location = new System.Drawing.Point(589, 272);
            this.ClinicComboBox.Name = "ClinicComboBox";
            this.ClinicComboBox.Size = new System.Drawing.Size(200, 24);
            this.ClinicComboBox.TabIndex = 16;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Violet;
            this.AddButton.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.AddButton.Location = new System.Drawing.Point(898, 653);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 45);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CertificationsLabel
            // 
            this.CertificationsLabel.AutoSize = true;
            this.CertificationsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CertificationsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline);
            this.CertificationsLabel.Location = new System.Drawing.Point(10, 327);
            this.CertificationsLabel.Name = "CertificationsLabel";
            this.CertificationsLabel.Size = new System.Drawing.Size(200, 32);
            this.CertificationsLabel.TabIndex = 17;
            this.CertificationsLabel.Text = "Certifications";
            // 
            // CertificationsTextBox
            // 
            this.CertificationsTextBox.Location = new System.Drawing.Point(16, 399);
            this.CertificationsTextBox.Name = "CertificationsTextBox";
            this.CertificationsTextBox.Size = new System.Drawing.Size(220, 22);
            this.CertificationsTextBox.TabIndex = 18;
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(480, 353);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 68);
            this.listBox1.TabIndex = 20;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // AvailableDaysLabel
            // 
            this.AvailableDaysLabel.AutoSize = true;
            this.AvailableDaysLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AvailableDaysLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline);
            this.AvailableDaysLabel.Location = new System.Drawing.Point(-1, 470);
            this.AvailableDaysLabel.Name = "AvailableDaysLabel";
            this.AvailableDaysLabel.Size = new System.Drawing.Size(217, 32);
            this.AvailableDaysLabel.TabIndex = 21;
            this.AvailableDaysLabel.Text = "Available Days";
            // 
            // AvailableDaysChecklist
            // 
            this.AvailableDaysChecklist.Location = new System.Drawing.Point(16, 533);
            this.AvailableDaysChecklist.Name = "AvailableDaysChecklist";
            this.AvailableDaysChecklist.Size = new System.Drawing.Size(200, 106);
            this.AvailableDaysChecklist.TabIndex = 22;
            // 
            // WorkingHoursLabel
            // 
            this.WorkingHoursLabel.AutoSize = true;
            this.WorkingHoursLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WorkingHoursLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline);
            this.WorkingHoursLabel.Location = new System.Drawing.Point(337, 470);
            this.WorkingHoursLabel.Name = "WorkingHoursLabel";
            this.WorkingHoursLabel.Size = new System.Drawing.Size(217, 32);
            this.WorkingHoursLabel.TabIndex = 23;
            this.WorkingHoursLabel.Text = "Working Hours";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.StartTimeLabel.Location = new System.Drawing.Point(339, 550);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(103, 22);
            this.StartTimeLabel.TabIndex = 24;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.EndTimeLabel.Location = new System.Drawing.Point(339, 617);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(95, 22);
            this.EndTimeLabel.TabIndex = 26;
            this.EndTimeLabel.Text = "End Time";
            // 
            // StartTimeDatePicker
            // 
            this.StartTimeDatePicker.CustomFormat = "HH:mm";
            this.StartTimeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimeDatePicker.Location = new System.Drawing.Point(480, 550);
            this.StartTimeDatePicker.Name = "StartTimeDatePicker";
            this.StartTimeDatePicker.Size = new System.Drawing.Size(150, 22);
            this.StartTimeDatePicker.TabIndex = 25;
            // 
            // EndTimeDatePicker
            // 
            this.EndTimeDatePicker.CustomFormat = "HH:mm";
            this.EndTimeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimeDatePicker.Location = new System.Drawing.Point(480, 617);
            this.EndTimeDatePicker.Name = "EndTimeDatePicker";
            this.EndTimeDatePicker.Size = new System.Drawing.Size(150, 22);
            this.EndTimeDatePicker.TabIndex = 27;
            // 
            // AddCertificationButton
            // 
            this.AddCertificationButton.BackColor = System.Drawing.Color.Violet;
            this.AddCertificationButton.Location = new System.Drawing.Point(249, 394);
            this.AddCertificationButton.Name = "AddCertificationButton";
            this.AddCertificationButton.Size = new System.Drawing.Size(131, 27);
            this.AddCertificationButton.TabIndex = 19;
            this.AddCertificationButton.Text = "add certification";
            this.AddCertificationButton.UseVisualStyleBackColor = false;
            this.AddCertificationButton.Click += new System.EventHandler(this.AddCertificationButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPanel.Controls.Add(this.BackButton);
            this.MainPanel.Controls.Add(this.BasicInfoLabel);
            this.MainPanel.Controls.Add(this.FirstNameLabel);
            this.MainPanel.Controls.Add(this.FirstNameTextBox);
            this.MainPanel.Controls.Add(this.LastNameLabel);
            this.MainPanel.Controls.Add(this.LastNameTextBox);
            this.MainPanel.Controls.Add(this.EmailLabel);
            this.MainPanel.Controls.Add(this.EmailTextBox);
            this.MainPanel.Controls.Add(this.PasswordLabel);
            this.MainPanel.Controls.Add(this.PasswordTextBox);
            this.MainPanel.Controls.Add(this.PhoneLabel);
            this.MainPanel.Controls.Add(this.PhoneTextBox);
            this.MainPanel.Controls.Add(this.ConsultationFeeLabel);
            this.MainPanel.Controls.Add(this.ConsultationFeeTextBox);
            this.MainPanel.Controls.Add(this.SpecializationLabel);
            this.MainPanel.Controls.Add(this.SpecializationComboBox);
            this.MainPanel.Controls.Add(this.ClinicLabel);
            this.MainPanel.Controls.Add(this.ClinicComboBox);
            this.MainPanel.Controls.Add(this.CertificationsLabel);
            this.MainPanel.Controls.Add(this.CertificationsTextBox);
            this.MainPanel.Controls.Add(this.AddCertificationButton);
            this.MainPanel.Controls.Add(this.listBox1);
            this.MainPanel.Controls.Add(this.AvailableDaysLabel);
            this.MainPanel.Controls.Add(this.AvailableDaysChecklist);
            this.MainPanel.Controls.Add(this.WorkingHoursLabel);
            this.MainPanel.Controls.Add(this.StartTimeLabel);
            this.MainPanel.Controls.Add(this.StartTimeDatePicker);
            this.MainPanel.Controls.Add(this.EndTimeLabel);
            this.MainPanel.Controls.Add(this.EndTimeDatePicker);
            this.MainPanel.Controls.Add(this.AddButton);
            this.MainPanel.Location = new System.Drawing.Point(50, 50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1100, 760);
            this.MainPanel.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.BackButton.Location = new System.Drawing.Point(5, 13);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(90, 35);
            this.BackButton.TabIndex = 41;
            this.BackButton.Text = "← Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddDoctorForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.MainPanel);
            this.Name = "AddDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Doctor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddDoctorForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label BasicInfoLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label ConsultationFeeLabel;
        private System.Windows.Forms.TextBox ConsultationFeeTextBox;
        private System.Windows.Forms.Label SpecializationLabel;
        private System.Windows.Forms.ComboBox SpecializationComboBox;
        private System.Windows.Forms.Label ClinicLabel;
        private System.Windows.Forms.ComboBox ClinicComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CertificationsLabel;
        private System.Windows.Forms.TextBox CertificationsTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label AvailableDaysLabel;
        private System.Windows.Forms.CheckedListBox AvailableDaysChecklist;
        private System.Windows.Forms.Label WorkingHoursLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.DateTimePicker StartTimeDatePicker;
        private System.Windows.Forms.DateTimePicker EndTimeDatePicker;
        private System.Windows.Forms.Button AddCertificationButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BackButton;
    }
}
