// Forms/Patient/ViewDrProfileForm.Designer.cs
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1.Forms.Patient
{
    partial class ViewDrProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelHeader;
        private Label lblHeader;

        private Panel panelMain;
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
        private FlowLayoutPanel flpReviews;
        private Label lblReviewsTitle;

        // Booking UI
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
            this.components = new System.ComponentModel.Container();

            // TOP HEADER
            this.panelHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 56,
                BackColor = Color.FromArgb(52, 152, 219)
            };

            this.lblHeader = new Label
            {
                Text = "Doctor Profile",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(12, 0, 0, 0)
            };

            panelHeader.Controls.Add(lblHeader);

            // MAIN PANEL
            this.panelMain = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke
            };

            // LEFT: INFO PANEL
            this.panelInfo = new Panel
            {
                Dock = DockStyle.Left,
                Width = 360,
                Padding = new Padding(16),
                BackColor = Color.White
            };

            lblDrName = new Label
            {
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(12, 8),
                AutoSize = true
            };

            lblSpecialization = new Label
            {
                Font = new Font("Segoe UI", 10),
                Location = new Point(12, 40),
                AutoSize = true
            };

            lblClinic = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(12, 70),
                AutoSize = true
            };

            lblDepartment = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(12, 92),
                AutoSize = true
            };

            lblFee = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(12, 114),
                AutoSize = true
            };

            lblRating = new Label
            {
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(12, 136),
                AutoSize = true
            };

            lblCerts = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(12, 160),
                AutoSize = true,
                MaximumSize = new Size(320, 0)
            };

            lblPhone = new Label
            {
                Font = new Font("Segoe UI", 9),
                Location = new Point(12, 188),
                AutoSize = true
            };

            panelInfo.Controls.Add(lblDrName);
            panelInfo.Controls.Add(lblSpecialization);
            panelInfo.Controls.Add(lblClinic);
            panelInfo.Controls.Add(lblDepartment);
            panelInfo.Controls.Add(lblFee);
            panelInfo.Controls.Add(lblRating);
            panelInfo.Controls.Add(lblCerts);
            panelInfo.Controls.Add(lblPhone);

            // RIGHT PANEL (Reviews + Booking)
            panelRight = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(16)
            };

            lblReviewsTitle = new Label
            {
                Text = "Recent Reviews",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Dock = DockStyle.Top,
                AutoSize = true
            };

            flpReviews = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 160,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };

            // BOOKING PANEL
            bookingPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(8),
                BackColor = Color.WhiteSmoke
            };

            // Calendar
            monthCalendar = new MonthCalendar
            {
                MaxSelectionCount = 1,
                Dock = DockStyle.Top,
                Margin = new Padding(0, 0, 0, 12)
            };

            // Time slots listing (radio buttons)
            flpTimeSlots = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 160,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(4)
            };

            btnProceedPayment = new Button
            {
                Text = "Proceed to Payment",
                Height = 40,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(41, 128, 185),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnProceedPayment.FlatAppearance.BorderSize = 0;

            // Add booking components
            bookingPanel.Controls.Add(btnProceedPayment);
            bookingPanel.Controls.Add(flpTimeSlots);
            bookingPanel.Controls.Add(monthCalendar);

            // Add all to right panel
            panelRight.Controls.Add(bookingPanel);
            panelRight.Controls.Add(flpReviews);
            panelRight.Controls.Add(lblReviewsTitle);

            // Compose main
            panelMain.Controls.Add(panelRight);
            panelMain.Controls.Add(panelInfo);

            // Form
            this.ClientSize = new Size(1100, 680);
            this.Controls.Add(panelMain);
            this.Controls.Add(panelHeader);
            this.Text = "Doctor Profile";
            this.Load += new System.EventHandler(this.ViewDrProfileForm_Load);
        }
    }
}
