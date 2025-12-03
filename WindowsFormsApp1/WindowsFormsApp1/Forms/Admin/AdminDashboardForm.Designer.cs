namespace WindowsFormsApp1.Forms.Admin
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.AdminButtonsPanel = new System.Windows.Forms.Panel();
            this.ManageDoctorsButton = new System.Windows.Forms.Button();
            this.AllAppointmentsButton = new System.Windows.Forms.Button();
            this.ViewPaymentsButton = new System.Windows.Forms.Button();
            this.ViewReviewsButton = new System.Windows.Forms.Button();
            this.GenerateReportsButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.AdminButtonsPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminButtonsPanel
            // 
            this.AdminButtonsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AdminButtonsPanel.Controls.Add(this.ManageDoctorsButton);
            this.AdminButtonsPanel.Controls.Add(this.AllAppointmentsButton);
            this.AdminButtonsPanel.Controls.Add(this.ViewPaymentsButton);
            this.AdminButtonsPanel.Controls.Add(this.ViewReviewsButton);
            this.AdminButtonsPanel.Controls.Add(this.GenerateReportsButton);
            this.AdminButtonsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminButtonsPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminButtonsPanel.Name = "AdminButtonsPanel";
            this.AdminButtonsPanel.Size = new System.Drawing.Size(200, 700);
            this.AdminButtonsPanel.TabIndex = 2;
            // 
            // ManageDoctorsButton
            // 
            this.ManageDoctorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ManageDoctorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ManageDoctorsButton.Location = new System.Drawing.Point(20, 30);
            this.ManageDoctorsButton.Name = "ManageDoctorsButton";
            this.ManageDoctorsButton.Size = new System.Drawing.Size(174, 80);
            this.ManageDoctorsButton.TabIndex = 0;
            this.ManageDoctorsButton.Text = "Manage Doctors";
            this.ManageDoctorsButton.UseVisualStyleBackColor = false;
            this.ManageDoctorsButton.Click += new System.EventHandler(this.ManageDoctorsButton_Click);
            // 
            // AllAppointmentsButton
            // 
            this.AllAppointmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AllAppointmentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.AllAppointmentsButton.Location = new System.Drawing.Point(20, 140);
            this.AllAppointmentsButton.Name = "AllAppointmentsButton";
            this.AllAppointmentsButton.Size = new System.Drawing.Size(174, 80);
            this.AllAppointmentsButton.TabIndex = 1;
            this.AllAppointmentsButton.Text = "All Appointments";
            this.AllAppointmentsButton.UseVisualStyleBackColor = false;
            this.AllAppointmentsButton.Click += new System.EventHandler(this.AllAppointmentsButton_Click);
            // 
            // ViewPaymentsButton
            // 
            this.ViewPaymentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ViewPaymentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ViewPaymentsButton.Location = new System.Drawing.Point(20, 250);
            this.ViewPaymentsButton.Name = "ViewPaymentsButton";
            this.ViewPaymentsButton.Size = new System.Drawing.Size(174, 80);
            this.ViewPaymentsButton.TabIndex = 2;
            this.ViewPaymentsButton.Text = "View Payments";
            this.ViewPaymentsButton.UseVisualStyleBackColor = false;
            this.ViewPaymentsButton.Click += new System.EventHandler(this.ViewPaymentsButton_Click);
            // 
            // ViewReviewsButton
            // 
            this.ViewReviewsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ViewReviewsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ViewReviewsButton.Location = new System.Drawing.Point(20, 360);
            this.ViewReviewsButton.Name = "ViewReviewsButton";
            this.ViewReviewsButton.Size = new System.Drawing.Size(174, 80);
            this.ViewReviewsButton.TabIndex = 3;
            this.ViewReviewsButton.Text = "View Reviews";
            this.ViewReviewsButton.UseVisualStyleBackColor = false;
            this.ViewReviewsButton.Click += new System.EventHandler(this.ViewReviewsButton_Click);
            // 
            // GenerateReportsButton
            // 
            this.GenerateReportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GenerateReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.GenerateReportsButton.Location = new System.Drawing.Point(20, 470);
            this.GenerateReportsButton.Name = "GenerateReportsButton";
            this.GenerateReportsButton.Size = new System.Drawing.Size(174, 80);
            this.GenerateReportsButton.TabIndex = 4;
            this.GenerateReportsButton.Text = "Generate Reports";
            this.GenerateReportsButton.UseVisualStyleBackColor = false;
            this.GenerateReportsButton.Click += new System.EventHandler(this.GenerateReportsButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.TopPanel.Controls.Add(this.LogoPictureBox);
            this.TopPanel.Controls.Add(this.NameLabel);
            this.TopPanel.Controls.Add(this.LogoutButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(655, 90);
            this.TopPanel.TabIndex = 1;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::WindowsFormsApp1.Properties.Resources.download_4;
            this.LogoPictureBox.Location = new System.Drawing.Point(365, 7);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(100, 73);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(20, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(279, 27);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "WellPoint Specialty Center";
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Gainsboro;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.Location = new System.Drawing.Point(486, 10);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(120, 70);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(200, 90);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(655, 610);
            this.MainContentPanel.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 700);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.AdminButtonsPanel);
            this.Name = "AdminDashboardForm";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.AdminButtonsPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminButtonsPanel;
        private System.Windows.Forms.Button ManageDoctorsButton;
        private System.Windows.Forms.Button AllAppointmentsButton;
        private System.Windows.Forms.Button ViewPaymentsButton;
        private System.Windows.Forms.Button ViewReviewsButton;
        private System.Windows.Forms.Button GenerateReportsButton;

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;

        private System.Windows.Forms.Panel MainContentPanel;
    }
}
