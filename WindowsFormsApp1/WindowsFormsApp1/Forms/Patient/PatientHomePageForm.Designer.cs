using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    partial class PatientHomePageForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnMyAppointments = new System.Windows.Forms.Button();
            this.btnWriteReview = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();

            this.panelFilters = new System.Windows.Forms.Panel();
            this.lblSpec = new System.Windows.Forms.Label();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.lblClinic = new System.Windows.Forms.Label();
            this.cmbClinic = new System.Windows.Forms.ComboBox();

            this.panelDoctorsList = new System.Windows.Forms.FlowLayoutPanel();

            this.panelHeader.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();

            // ======================================================================
            // HEADER PANEL
            // ======================================================================
            this.panelHeader.BackColor = Color.FromArgb(52, 152, 219);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 70;
            this.panelHeader.Padding = new Padding(10);

            // SEARCH BOX
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Size = new System.Drawing.Size(280, 28);
            this.txtSearch.Font = new Font("Segoe UI", 11);

            // MY APPOINTMENTS BUTTON
            this.btnMyAppointments.Text = "My Appointments";
            this.btnMyAppointments.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnMyAppointments.Location = new System.Drawing.Point(330, 18);
            this.btnMyAppointments.Size = new System.Drawing.Size(150, 32);

            // WRITE REVIEW BUTTON
            this.btnWriteReview.Text = "Write Review";
            this.btnWriteReview.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnWriteReview.Location = new System.Drawing.Point(490, 18);
            this.btnWriteReview.Size = new System.Drawing.Size(140, 32);

            // LOGOUT BUTTON
            this.btnLogout.Text = "Logout";
            this.btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            this.btnLogout.ForeColor = Color.White;
            this.btnLogout.FlatStyle = FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(640, 18);
            this.btnLogout.Size = new System.Drawing.Size(110, 32);

            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.btnMyAppointments);
            this.panelHeader.Controls.Add(this.btnWriteReview);
            this.panelHeader.Controls.Add(this.btnLogout);

            // ======================================================================
            // FILTER PANEL (LEFT SIDEBAR)
            // ======================================================================
            this.panelFilters.BackColor = Color.FromArgb(240, 242, 245);
            this.panelFilters.Dock = DockStyle.Left;
            this.panelFilters.Width = 260;
            this.panelFilters.Padding = new Padding(15, 20, 15, 20);

            // SPECIALIZATION LABEL
            this.lblSpec.Text = "Specialization";
            this.lblSpec.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblSpec.Location = new Point(10, 10);
            this.lblSpec.AutoSize = true;

            // SPECIALIZATION COMBO
            this.cmbSpecialization.Location = new Point(10, 40);
            this.cmbSpecialization.Size = new Size(220, 28);
            this.cmbSpecialization.Font = new Font("Segoe UI", 10);

            // CLINIC LABEL
            this.lblClinic.Text = "Clinic";
            this.lblClinic.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.lblClinic.Location = new Point(10, 90);
            this.lblClinic.AutoSize = true;

            // CLINIC COMBO
            this.cmbClinic.Location = new Point(10, 120);
            this.cmbClinic.Size = new Size(220, 28);
            this.cmbClinic.Font = new Font("Segoe UI", 10);

            this.panelFilters.Controls.Add(this.lblSpec);
            this.panelFilters.Controls.Add(this.cmbSpecialization);
            this.panelFilters.Controls.Add(this.lblClinic);
            this.panelFilters.Controls.Add(this.cmbClinic);

            // ======================================================================
            // DOCTORS LIST PANEL
            // ======================================================================
            this.panelDoctorsList.Dock = DockStyle.Fill;
            this.panelDoctorsList.AutoScroll = true;
            this.panelDoctorsList.BackColor = Color.White;

            this.panelDoctorsList.FlowDirection = FlowDirection.LeftToRight;
            this.panelDoctorsList.WrapContents = true;
            this.panelDoctorsList.Padding = new Padding(20);

            // ======================================================================
            // MAIN FORM SETTINGS
            // ======================================================================
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Text = "Patient Home Page";

            this.Controls.Add(this.panelDoctorsList);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelHeader);

            this.WindowState = FormWindowState.Maximized;

            this.Load += new System.EventHandler(this.PatientHomePageForm_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private TextBox txtSearch;
        private Button btnMyAppointments;
        private Button btnWriteReview;
        private Button btnLogout;

        private Panel panelFilters;
        private ComboBox cmbSpecialization;
        private ComboBox cmbClinic;
        private Label lblSpec;
        private Label lblClinic;

        private FlowLayoutPanel panelDoctorsList;
    }
}
