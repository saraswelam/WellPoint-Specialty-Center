using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Admin
{
    partial class GenerateReportsForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.MostBookedDoctorsButton = new System.Windows.Forms.Button();
            this.AppointmentsPerClinicButton = new System.Windows.Forms.Button();
            this.DoctorRatingsButton = new System.Windows.Forms.Button();
            this.DoctorWorkloadButton = new System.Windows.Forms.Button();
            this.TotalRevenueButton = new System.Windows.Forms.Button();
            this.ReportGenerationLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainPanel.Controls.Add(this.dataGridView);
            this.MainPanel.Controls.Add(this.MostBookedDoctorsButton);
            this.MainPanel.Controls.Add(this.AppointmentsPerClinicButton);
            this.MainPanel.Controls.Add(this.DoctorRatingsButton);
            this.MainPanel.Controls.Add(this.DoctorWorkloadButton);
            this.MainPanel.Controls.Add(this.TotalRevenueButton);
            this.MainPanel.Controls.Add(this.ReportGenerationLabel);
            this.MainPanel.Location = new System.Drawing.Point(5, 5);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1208, 740);
            this.MainPanel.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(327, 116);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(862, 601);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // MostBookedDoctorsButton
            // 
            this.MostBookedDoctorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MostBookedDoctorsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostBookedDoctorsButton.Location = new System.Drawing.Point(15, 210);
            this.MostBookedDoctorsButton.Name = "MostBookedDoctorsButton";
            this.MostBookedDoctorsButton.Size = new System.Drawing.Size(232, 32);
            this.MostBookedDoctorsButton.TabIndex = 5;
            this.MostBookedDoctorsButton.Text = "Most Booked Doctors";
            this.MostBookedDoctorsButton.UseVisualStyleBackColor = false;
            this.MostBookedDoctorsButton.Click += new System.EventHandler(this.MostBookedDoctorsButton_Click);
            // 
            // AppointmentsPerClinicButton
            // 
            this.AppointmentsPerClinicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AppointmentsPerClinicButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsPerClinicButton.Location = new System.Drawing.Point(15, 301);
            this.AppointmentsPerClinicButton.Name = "AppointmentsPerClinicButton";
            this.AppointmentsPerClinicButton.Size = new System.Drawing.Size(232, 52);
            this.AppointmentsPerClinicButton.TabIndex = 4;
            this.AppointmentsPerClinicButton.Text = "Appointments Per Clinic";
            this.AppointmentsPerClinicButton.UseVisualStyleBackColor = false;
            this.AppointmentsPerClinicButton.Click += new System.EventHandler(this.AppointmentsPerClinicButton_Click);
            // 
            // DoctorRatingsButton
            // 
            this.DoctorRatingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DoctorRatingsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorRatingsButton.Location = new System.Drawing.Point(15, 397);
            this.DoctorRatingsButton.Name = "DoctorRatingsButton";
            this.DoctorRatingsButton.Size = new System.Drawing.Size(232, 42);
            this.DoctorRatingsButton.TabIndex = 3;
            this.DoctorRatingsButton.Text = "Doctor Ratings";
            this.DoctorRatingsButton.UseVisualStyleBackColor = false;
            this.DoctorRatingsButton.Click += new System.EventHandler(this.DoctorRatingsButton_Click);
            // 
            // DoctorWorkloadButton
            // 
            this.DoctorWorkloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DoctorWorkloadButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorWorkloadButton.Location = new System.Drawing.Point(15, 494);
            this.DoctorWorkloadButton.Name = "DoctorWorkloadButton";
            this.DoctorWorkloadButton.Size = new System.Drawing.Size(232, 57);
            this.DoctorWorkloadButton.TabIndex = 2;
            this.DoctorWorkloadButton.Text = "Doctor Workload by Month";
            this.DoctorWorkloadButton.UseVisualStyleBackColor = false;
            this.DoctorWorkloadButton.Click += new System.EventHandler(this.DoctorWorkloadButton_Click);
            // 
            // TotalRevenueButton
            // 
            this.TotalRevenueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TotalRevenueButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRevenueButton.Location = new System.Drawing.Point(15, 116);
            this.TotalRevenueButton.Name = "TotalRevenueButton";
            this.TotalRevenueButton.Size = new System.Drawing.Size(232, 32);
            this.TotalRevenueButton.TabIndex = 1;
            this.TotalRevenueButton.Text = "Total Revenue Report";
            this.TotalRevenueButton.UseVisualStyleBackColor = false;
            this.TotalRevenueButton.Click += new System.EventHandler(this.TotalRevenueButton_Click);
            // 
            // ReportGenerationLabel
            // 
            this.ReportGenerationLabel.AutoSize = true;
            this.ReportGenerationLabel.BackColor = System.Drawing.Color.Violet;
            this.ReportGenerationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportGenerationLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportGenerationLabel.Location = new System.Drawing.Point(464, 34);
            this.ReportGenerationLabel.Name = "ReportGenerationLabel";
            this.ReportGenerationLabel.Size = new System.Drawing.Size(313, 48);
            this.ReportGenerationLabel.TabIndex = 0;
            this.ReportGenerationLabel.Text = "Report Generation";
            // 
            // GenerateReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1243, 734);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GenerateReportsForm";
            this.Text = "Generate Reports";
            this.Load += new System.EventHandler(this.GenerateReportsForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private void GenerateReportsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button MostBookedDoctorsButton;
        private System.Windows.Forms.Button AppointmentsPerClinicButton;
        private System.Windows.Forms.Button DoctorRatingsButton;
        private System.Windows.Forms.Button DoctorWorkloadButton;
        private System.Windows.Forms.Button TotalRevenueButton;
        private System.Windows.Forms.Label ReportGenerationLabel;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}