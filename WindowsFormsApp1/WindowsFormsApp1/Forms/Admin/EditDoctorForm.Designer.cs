namespace WindowsFormsApp1.Forms.Admin
{
    partial class EditDoctorForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AvailableDaysCheckList = new System.Windows.Forms.CheckedListBox();
            this.AvailableDaysLabel = new System.Windows.Forms.Label();
            this.ClinicComboBox = new System.Windows.Forms.ComboBox();
            this.ClinicLabel = new System.Windows.Forms.Label();
            this.ConsultationFeeTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.ConsultationFeeLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.Controls.Add(this.UpdateButton);
            this.MainPanel.Controls.Add(this.LastNameTextBox);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.StartTimeLabel);
            this.MainPanel.Controls.Add(this.EndTimeLabel);
            this.MainPanel.Controls.Add(this.EndDatePicker);
            this.MainPanel.Controls.Add(this.StartDatePicker);
            this.MainPanel.Controls.Add(this.AvailableDaysCheckList);
            this.MainPanel.Controls.Add(this.AvailableDaysLabel);
            this.MainPanel.Controls.Add(this.ClinicComboBox);
            this.MainPanel.Controls.Add(this.ClinicLabel);
            this.MainPanel.Controls.Add(this.ConsultationFeeTextBox);
            this.MainPanel.Controls.Add(this.PhoneTextBox);
            this.MainPanel.Controls.Add(this.ConsultationFeeLabel);
            this.MainPanel.Controls.Add(this.PhoneLabel);
            this.MainPanel.Controls.Add(this.FirstNameTextBox);
            this.MainPanel.Controls.Add(this.LastNameLabel);
            this.MainPanel.Controls.Add(this.FirstNameLabel);
            this.MainPanel.Location = new System.Drawing.Point(12, 20);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1070, 644);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.BlueViolet;
            this.UpdateButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(873, 578);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(133, 44);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(177, 132);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.LastNameTextBox.TabIndex = 17;
            this.LastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Violet;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Edit Selected Doctor";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.StartTimeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(25, 532);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(119, 25);
            this.StartTimeLabel.TabIndex = 15;
            this.StartTimeLabel.Text = "Start Time";
            this.StartTimeLabel.Click += new System.EventHandler(this.StartTimeLabel_Click);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EndTimeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLabel.Location = new System.Drawing.Point(535, 532);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(109, 25);
            this.EndTimeLabel.TabIndex = 14;
            this.EndTimeLabel.Text = "End Time";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndDatePicker.Location = new System.Drawing.Point(708, 532);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 22);
            this.EndDatePicker.TabIndex = 13;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartDatePicker.Location = new System.Drawing.Point(188, 532);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 22);
            this.StartDatePicker.TabIndex = 12;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // AvailableDaysCheckList
            // 
            this.AvailableDaysCheckList.FormattingEnabled = true;
            this.AvailableDaysCheckList.Location = new System.Drawing.Point(30, 374);
            this.AvailableDaysCheckList.Name = "AvailableDaysCheckList";
            this.AvailableDaysCheckList.Size = new System.Drawing.Size(198, 89);
            this.AvailableDaysCheckList.TabIndex = 11;
            this.AvailableDaysCheckList.SelectedIndexChanged += new System.EventHandler(this.AvailableDaysCheckList_SelectedIndexChanged);
            // 
            // AvailableDaysLabel
            // 
            this.AvailableDaysLabel.AutoSize = true;
            this.AvailableDaysLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AvailableDaysLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableDaysLabel.Location = new System.Drawing.Point(25, 329);
            this.AvailableDaysLabel.Name = "AvailableDaysLabel";
            this.AvailableDaysLabel.Size = new System.Drawing.Size(155, 25);
            this.AvailableDaysLabel.TabIndex = 10;
            this.AvailableDaysLabel.Text = "Available Days";
            // 
            // ClinicComboBox
            // 
            this.ClinicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClinicComboBox.FormattingEnabled = true;
            this.ClinicComboBox.Location = new System.Drawing.Point(188, 249);
            this.ClinicComboBox.Name = "ClinicComboBox";
            this.ClinicComboBox.Size = new System.Drawing.Size(121, 24);
            this.ClinicComboBox.TabIndex = 9;
            this.ClinicComboBox.SelectedIndexChanged += new System.EventHandler(this.ClinicComboBox_SelectedIndexChanged);
            // 
            // ClinicLabel
            // 
            this.ClinicLabel.AutoSize = true;
            this.ClinicLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClinicLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClinicLabel.Location = new System.Drawing.Point(25, 248);
            this.ClinicLabel.Name = "ClinicLabel";
            this.ClinicLabel.Size = new System.Drawing.Size(68, 25);
            this.ClinicLabel.TabIndex = 8;
            this.ClinicLabel.Text = "Clinic";
            // 
            // ConsultationFeeTextBox
            // 
            this.ConsultationFeeTextBox.Location = new System.Drawing.Point(768, 76);
            this.ConsultationFeeTextBox.Name = "ConsultationFeeTextBox";
            this.ConsultationFeeTextBox.Size = new System.Drawing.Size(100, 22);
            this.ConsultationFeeTextBox.TabIndex = 6;
            this.ConsultationFeeTextBox.TextChanged += new System.EventHandler(this.ConsultationFeeTextBox_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(768, 136);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.PhoneTextBox.TabIndex = 5;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // ConsultationFeeLabel
            // 
            this.ConsultationFeeLabel.AutoSize = true;
            this.ConsultationFeeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ConsultationFeeLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultationFeeLabel.Location = new System.Drawing.Point(527, 78);
            this.ConsultationFeeLabel.Name = "ConsultationFeeLabel";
            this.ConsultationFeeLabel.Size = new System.Drawing.Size(182, 25);
            this.ConsultationFeeLabel.TabIndex = 4;
            this.ConsultationFeeLabel.Text = "Consultation Fee";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PhoneLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(527, 132);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(165, 25);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone Number";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(177, 72);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LastNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(25, 132);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(121, 25);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FirstNameLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(25, 72);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(124, 25);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // EditDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1094, 683);
            this.Controls.Add(this.MainPanel);
            this.Name = "EditDoctorForm";
            this.Text = "Edit Doctor";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ComboBox ClinicComboBox;
        private System.Windows.Forms.Label ClinicLabel;
        private System.Windows.Forms.TextBox ConsultationFeeTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label ConsultationFeeLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.CheckedListBox AvailableDaysCheckList;
        private System.Windows.Forms.Label AvailableDaysLabel;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button UpdateButton;
    }
}