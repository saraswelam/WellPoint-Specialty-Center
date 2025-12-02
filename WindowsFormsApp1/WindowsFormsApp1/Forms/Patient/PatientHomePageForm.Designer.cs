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
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.btnMyAppointments);
            this.panelHeader.Controls.Add(this.btnWriteReview);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10);
            this.panelHeader.Size = new System.Drawing.Size(1395, 70);
            this.panelHeader.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 32);
            this.txtSearch.TabIndex = 0;
            // 
            // btnMyAppointments
            // 
            this.btnMyAppointments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMyAppointments.Location = new System.Drawing.Point(330, 18);
            this.btnMyAppointments.Name = "btnMyAppointments";
            this.btnMyAppointments.Size = new System.Drawing.Size(150, 32);
            this.btnMyAppointments.TabIndex = 1;
            this.btnMyAppointments.Text = "My Appointments";
            // 
            // btnWriteReview
            // 
            this.btnWriteReview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnWriteReview.Location = new System.Drawing.Point(490, 18);
            this.btnWriteReview.Name = "btnWriteReview";
            this.btnWriteReview.Size = new System.Drawing.Size(140, 32);
            this.btnWriteReview.TabIndex = 2;
            this.btnWriteReview.Text = "Write Review";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(640, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panelFilters.Controls.Add(this.lblSpec);
            this.panelFilters.Controls.Add(this.cmbSpecialization);
            this.panelFilters.Controls.Add(this.lblClinic);
            this.panelFilters.Controls.Add(this.cmbClinic);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFilters.Location = new System.Drawing.Point(0, 70);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            this.panelFilters.Size = new System.Drawing.Size(260, 407);
            this.panelFilters.TabIndex = 1;
            this.panelFilters.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFilters_Paint);
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSpec.Location = new System.Drawing.Point(10, 10);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(134, 25);
            this.lblSpec.TabIndex = 0;
            this.lblSpec.Text = "Specialization";
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSpecialization.Location = new System.Drawing.Point(10, 40);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(220, 31);
            this.cmbSpecialization.TabIndex = 1;
            // 
            // lblClinic
            // 
            this.lblClinic.AutoSize = true;
            this.lblClinic.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblClinic.Location = new System.Drawing.Point(10, 90);
            this.lblClinic.Name = "lblClinic";
            this.lblClinic.Size = new System.Drawing.Size(60, 25);
            this.lblClinic.TabIndex = 2;
            this.lblClinic.Text = "Clinic";
            // 
            // cmbClinic
            // 
            this.cmbClinic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClinic.Location = new System.Drawing.Point(10, 120);
            this.cmbClinic.Name = "cmbClinic";
            this.cmbClinic.Size = new System.Drawing.Size(220, 31);
            this.cmbClinic.TabIndex = 3;
            // 
            // panelDoctorsList
            // 
            this.panelDoctorsList.AutoScroll = true;
            this.panelDoctorsList.BackColor = System.Drawing.Color.White;
            this.panelDoctorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoctorsList.Location = new System.Drawing.Point(260, 70);
            this.panelDoctorsList.Name = "panelDoctorsList";
            this.panelDoctorsList.Padding = new System.Windows.Forms.Padding(20);
            this.panelDoctorsList.Size = new System.Drawing.Size(1135, 407);
            this.panelDoctorsList.TabIndex = 0;
            this.panelDoctorsList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDoctorsList_Paint_1);
            // 
            // PatientHomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 477);
            this.Controls.Add(this.panelDoctorsList);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelHeader);
            this.Name = "PatientHomePageForm";
            this.Text = "Patient Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
