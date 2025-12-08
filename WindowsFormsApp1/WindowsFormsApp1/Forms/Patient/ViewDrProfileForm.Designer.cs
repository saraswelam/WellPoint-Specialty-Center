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

            // ================================================
            // HEADER PANEL
            // ================================================
            this.panelHeader.BackColor = Color.SteelBlue;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 70;

            // BACK BUTTON
            this.btnBack.Text = "← Back";
            this.btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnBack.BackColor = Color.White;
            this.btnBack.ForeColor = Color.SteelBlue;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Location = new Point(20, 18);
            this.btnBack.Size = new Size(90, 35);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // HEADER LABEL
            this.lblHeader.Text = "Doctor Profile";
            this.lblHeader.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Location = new Point(130, 15);
            this.lblHeader.AutoSize = true;

            // ================================================
            // LEFT DOCTOR INFO PANEL
            // ================================================
            this.panelInfo.BackColor = Color.White;
            this.panelInfo.Location = new Point(20, 90);
            this.panelInfo.Size = new Size(380, 350);
            this.panelInfo.Padding = new Padding(15);

            // Doctor fields
            this.lblDrName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblDrName.Location = new Point(10, 10);
            this.lblDrName.AutoSize = true;

            this.lblSpecialization.Font = new Font("Segoe UI", 11F);
            this.lblSpecialization.Location = new Point(10, 60);
            this.lblSpecialization.AutoSize = true;

            this.lblClinic.Font = new Font("Segoe UI", 11F);
            this.lblClinic.Location = new Point(10, 90);
            this.lblClinic.AutoSize = true;

            this.lblDepartment.Font = new Font("Segoe UI", 11F);
            this.lblDepartment.Location = new Point(10, 120);
            this.lblDepartment.AutoSize = true;

            this.lblFee.Font = new Font("Segoe UI", 11F);
            this.lblFee.Location = new Point(10, 150);
            this.lblFee.AutoSize = true;

            this.lblRating.Font = new Font("Segoe UI", 11F);
            this.lblRating.Location = new Point(10, 180);
            this.lblRating.AutoSize = true;

            this.lblCerts.Font = new Font("Segoe UI", 11F);
            this.lblCerts.Location = new Point(10, 210);
            this.lblCerts.AutoSize = true;

            this.lblPhone.Font = new Font("Segoe UI", 11F);
            this.lblPhone.Location = new Point(10, 240);
            this.lblPhone.AutoSize = true;

            this.panelInfo.Controls.Add(this.lblDrName);
            this.panelInfo.Controls.Add(this.lblSpecialization);
            this.panelInfo.Controls.Add(this.lblClinic);
            this.panelInfo.Controls.Add(this.lblDepartment);
            this.panelInfo.Controls.Add(this.lblFee);
            this.panelInfo.Controls.Add(this.lblRating);
            this.panelInfo.Controls.Add(this.lblCerts);
            this.panelInfo.Controls.Add(this.lblPhone);

            // ================================================
            // RIGHT REVIEWS PANEL
            // ================================================
            this.panelRight.BackColor = Color.WhiteSmoke;
            this.panelRight.Location = new Point(420, 90);
            this.panelRight.Size = new Size(440, 350);
            this.panelRight.Padding = new Padding(10);

            this.lblReviewsTitle.Text = "Recent Reviews";
            this.lblReviewsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblReviewsTitle.Location = new Point(10, 10);
            this.lblReviewsTitle.AutoSize = true;

            this.flpReviews.AutoScroll = true;
            this.flpReviews.Location = new Point(10, 50);
            this.flpReviews.Size = new Size(420, 280);

            this.panelRight.Controls.Add(this.lblReviewsTitle);
            this.panelRight.Controls.Add(this.flpReviews);

            // ================================================
            // BOOKING PANEL
            // ================================================
            this.bookingPanel.BackColor = Color.White;
            this.bookingPanel.Location = new Point(20, 460);
            this.bookingPanel.Size = new Size(380, 300);
            this.bookingPanel.Padding = new Padding(10);

            this.monthCalendar.Location = new Point(10, 10);

            this.flpTimeSlots.AutoScroll = true;
            this.flpTimeSlots.Location = new Point(250, 10);
            this.flpTimeSlots.Size = new Size(120, 200);

            this.btnProceedPayment.Text = "Proceed to Payment";
            this.btnProceedPayment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnProceedPayment.BackColor = Color.SteelBlue;
            this.btnProceedPayment.ForeColor = Color.White;
            this.btnProceedPayment.FlatStyle = FlatStyle.Flat;
            this.btnProceedPayment.FlatAppearance.BorderSize = 0;
            this.btnProceedPayment.Location = new Point(160, 230);
            this.btnProceedPayment.Size = new Size(200, 40);

            this.bookingPanel.Controls.Add(this.monthCalendar);
            this.bookingPanel.Controls.Add(this.flpTimeSlots);
            this.bookingPanel.Controls.Add(this.btnProceedPayment);

            // ================================================
            // FORM SETTINGS
            // ================================================
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(900, 800);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.bookingPanel);
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
