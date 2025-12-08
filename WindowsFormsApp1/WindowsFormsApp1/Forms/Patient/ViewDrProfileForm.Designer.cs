using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1.Forms.Patient
{
    partial class ViewDrProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Button btnBack;
        private Label lblHeader;

        private Panel panelInfo;
        private Label lblDrName;
        private Label lblSpecialization;
        private Label lblClinic;
        private Label lblDepartment;
        private Label lblFee;
        private Label lblRating;
        private Label lblCerts;
        private Label lblPhone;

        private Panel panelRight;
        private Label lblReviewsTitle;
        private FlowLayoutPanel flpReviews;

        private Panel bookingPanel;
        private MonthCalendar monthCalendar;
        private FlowLayoutPanel flpTimeSlots;
        private Button btnProceedPayment;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblDrName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.lblClinic = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblCerts = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.lblReviewsTitle = new System.Windows.Forms.Label();
            this.flpReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.bookingPanel = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.flpTimeSlots = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProceedPayment = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.bookingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Location = new System.Drawing.Point(20, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(130, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(268, 50);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Doctor Profile";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelInfo.Controls.Add(this.lblDrName);
            this.panelInfo.Controls.Add(this.lblSpecialization);
            this.panelInfo.Controls.Add(this.lblClinic);
            this.panelInfo.Controls.Add(this.lblDepartment);
            this.panelInfo.Controls.Add(this.lblFee);
            this.panelInfo.Controls.Add(this.lblRating);
            this.panelInfo.Controls.Add(this.lblCerts);
            this.panelInfo.Controls.Add(this.lblPhone);
            this.panelInfo.Location = new System.Drawing.Point(20, 90);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Padding = new System.Windows.Forms.Padding(15);
            this.panelInfo.Size = new System.Drawing.Size(380, 350);
            this.panelInfo.TabIndex = 1;
            // 
            // lblDrName
            // 
            this.lblDrName.AutoSize = true;
            this.lblDrName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDrName.Location = new System.Drawing.Point(10, 10);
            this.lblDrName.Name = "lblDrName";
            this.lblDrName.Size = new System.Drawing.Size(0, 41);
            this.lblDrName.TabIndex = 0;
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSpecialization.Location = new System.Drawing.Point(10, 60);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(0, 25);
            this.lblSpecialization.TabIndex = 1;
            // 
            // lblClinic
            // 
            this.lblClinic.AutoSize = true;
            this.lblClinic.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblClinic.Location = new System.Drawing.Point(10, 90);
            this.lblClinic.Name = "lblClinic";
            this.lblClinic.Size = new System.Drawing.Size(0, 25);
            this.lblClinic.TabIndex = 2;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDepartment.Location = new System.Drawing.Point(10, 120);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(0, 25);
            this.lblDepartment.TabIndex = 3;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFee.Location = new System.Drawing.Point(10, 150);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(0, 25);
            this.lblFee.TabIndex = 4;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRating.Location = new System.Drawing.Point(10, 180);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(0, 25);
            this.lblRating.TabIndex = 5;
            // 
            // lblCerts
            // 
            this.lblCerts.AutoSize = true;
            this.lblCerts.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCerts.Location = new System.Drawing.Point(10, 210);
            this.lblCerts.Name = "lblCerts";
            this.lblCerts.Size = new System.Drawing.Size(0, 25);
            this.lblCerts.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPhone.Location = new System.Drawing.Point(10, 240);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 25);
            this.lblPhone.TabIndex = 7;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelRight.Controls.Add(this.lblReviewsTitle);
            this.panelRight.Controls.Add(this.flpReviews);
            this.panelRight.Location = new System.Drawing.Point(420, 90);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(440, 350);
            this.panelRight.TabIndex = 2;
            // 
            // lblReviewsTitle
            // 
            this.lblReviewsTitle.AutoSize = true;
            this.lblReviewsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReviewsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblReviewsTitle.Name = "lblReviewsTitle";
            this.lblReviewsTitle.Size = new System.Drawing.Size(189, 32);
            this.lblReviewsTitle.TabIndex = 0;
            this.lblReviewsTitle.Text = "Recent Reviews";
            // 
            // flpReviews
            // 
            this.flpReviews.AutoScroll = true;
            this.flpReviews.BackColor = System.Drawing.Color.LightSlateGray;
            this.flpReviews.Location = new System.Drawing.Point(10, 50);
            this.flpReviews.Name = "flpReviews";
            this.flpReviews.Size = new System.Drawing.Size(420, 280);
            this.flpReviews.TabIndex = 1;
            // 
            // bookingPanel
            // 
            this.bookingPanel.BackColor = System.Drawing.Color.LightSlateGray;
            this.bookingPanel.Controls.Add(this.monthCalendar);
            this.bookingPanel.Controls.Add(this.flpTimeSlots);
            this.bookingPanel.Controls.Add(this.btnProceedPayment);
            this.bookingPanel.Location = new System.Drawing.Point(20, 460);
            this.bookingPanel.Name = "bookingPanel";
            this.bookingPanel.Padding = new System.Windows.Forms.Padding(10);
            this.bookingPanel.Size = new System.Drawing.Size(380, 300);
            this.bookingPanel.TabIndex = 3;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(10, 10);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            // 
            // flpTimeSlots
            // 
            this.flpTimeSlots.AutoScroll = true;
            this.flpTimeSlots.Location = new System.Drawing.Point(250, 10);
            this.flpTimeSlots.Name = "flpTimeSlots";
            this.flpTimeSlots.Size = new System.Drawing.Size(120, 200);
            this.flpTimeSlots.TabIndex = 1;
            // 
            // btnProceedPayment
            // 
            this.btnProceedPayment.BackColor = System.Drawing.Color.SteelBlue;
            this.btnProceedPayment.FlatAppearance.BorderSize = 0;
            this.btnProceedPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceedPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProceedPayment.ForeColor = System.Drawing.Color.White;
            this.btnProceedPayment.Location = new System.Drawing.Point(160, 230);
            this.btnProceedPayment.Name = "btnProceedPayment";
            this.btnProceedPayment.Size = new System.Drawing.Size(200, 40);
            this.btnProceedPayment.TabIndex = 2;
            this.btnProceedPayment.Text = "Proceed to Payment";
            this.btnProceedPayment.UseVisualStyleBackColor = false;
            // 
            // ViewDrProfileForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.bookingPanel);
            this.Name = "ViewDrProfileForm";
            this.Text = "Doctor Profile";
            this.Load += new System.EventHandler(this.ViewDrProfileForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.bookingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
