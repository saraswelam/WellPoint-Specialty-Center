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

        // =============================================
        // INITIALIZE COMPONENT
        // =============================================
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // ================================
            // MAIN FORM
            // ================================
            this.ClientSize = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Doctor Profile";
            this.BackColor = Color.WhiteSmoke;

            // ================================
            // HEADER
            // ================================
            panelHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(52, 152, 219),
                Padding = new Padding(15, 10, 0, 10)
            };

            lblHeader = new Label
            {
                Text = "Doctor Profile",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true
            };

            panelHeader.Controls.Add(lblHeader);
            this.Controls.Add(panelHeader);

            // ================================
            // MAIN TABLE
            // ================================
            var mainTable = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1
            };

            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 450));   // Left fixed panel
            mainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));    // Right flexible panel

            this.Controls.Add(mainTable);

            // ================================
            // LEFT – DOCTOR INFO (Auto Layout)
            // ================================
            var leftPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(20),
            };

            lblDrName = new Label { Font = new Font("Segoe UI", 18, FontStyle.Bold), AutoSize = true };
            lblSpecialization = new Label { Font = new Font("Segoe UI", 12), AutoSize = true };
            lblClinic = new Label { Font = new Font("Segoe UI", 12), AutoSize = true };
            lblDepartment = new Label { Font = new Font("Segoe UI", 12), AutoSize = true };
            lblPhone = new Label { Font = new Font("Segoe UI", 12), AutoSize = true };
            lblFee = new Label { Font = new Font("Segoe UI", 12), AutoSize = true };
            lblRating = new Label { Font = new Font("Segoe UI", 12), AutoSize = true };

            lblCerts = new Label
            {
                Font = new Font("Segoe UI", 11),
                AutoSize = true,
                MaximumSize = new Size(400, 0)
            };

            leftPanel.Controls.Add(lblDrName);
            leftPanel.Controls.Add(lblSpecialization);
            leftPanel.Controls.Add(lblClinic);
            leftPanel.Controls.Add(lblDepartment);
            leftPanel.Controls.Add(lblPhone);
            leftPanel.Controls.Add(lblFee);
            leftPanel.Controls.Add(lblRating);
            leftPanel.Controls.Add(lblCerts);

            mainTable.Controls.Add(leftPanel, 0, 0);

            // ================================
            // RIGHT SIDE (Reviews + Booking)
            // ================================
            var rightPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                BackColor = Color.White,
                Padding = new Padding(20),
                WrapContents = false
            };

            mainTable.Controls.Add(rightPanel, 1, 0);

            // ================================
            // REVIEWS
            // ================================
            lblReviewsTitle = new Label
            {
                Text = "Recent Reviews",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 10)
            };

            flpReviews = new FlowLayoutPanel
            {
                AutoSize = false,
                Height = 200,
                Width = 500,
                AutoScroll = true,
                BackColor = Color.WhiteSmoke,
                Margin = new Padding(0, 0, 0, 20)
            };

            rightPanel.Controls.Add(lblReviewsTitle);
            rightPanel.Controls.Add(flpReviews);

            // ================================
            // BOOKING PANEL (Responsive)
            // ================================
            bookingPanel = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,
                AutoSize = true,
                Width = 500,
                BackColor = Color.WhiteSmoke,
                Padding = new Padding(15),
                WrapContents = false,
            };

            monthCalendar = new MonthCalendar { Margin = new Padding(0, 0, 0, 10) };

            flpTimeSlots = new FlowLayoutPanel
            {
                AutoSize = false,
                Height = 150,
                Width = 460,
                BackColor = Color.White,
                AutoScroll = true,
                Margin = new Padding(0, 0, 0, 10)
            };

            btnProceedPayment = new Button
            {
                Text = "Proceed to Payment",
                Height = 45,
                Width = 220,
                BackColor = Color.FromArgb(41, 128, 185),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            bookingPanel.Controls.Add(monthCalendar);
            bookingPanel.Controls.Add(flpTimeSlots);
            bookingPanel.Controls.Add(btnProceedPayment);

            rightPanel.Controls.Add(bookingPanel);

            // Load event
            this.Load += ViewDrProfileForm_Load;

            this.ResumeLayout(false);
        }

    }
}
