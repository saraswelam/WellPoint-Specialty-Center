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
            this.lblDept = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.panelDoctorsList = new System.Windows.Forms.FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelHeader.Controls.Add(this.txtSearch);
            this.panelHeader.Controls.Add(this.btnMyAppointments);
            this.panelHeader.Controls.Add(this.btnWriteReview);
            this.panelHeader.Controls.Add(this.btnLogout);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelHeader.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // btnMyAppointments
            // 
            this.btnMyAppointments.Location = new System.Drawing.Point(300, 10);
            this.btnMyAppointments.Name = "btnMyAppointments";
            this.btnMyAppointments.Size = new System.Drawing.Size(130, 35);
            this.btnMyAppointments.TabIndex = 1;
            this.btnMyAppointments.Text = "My Appointments";
            // 
            // btnWriteReview
            // 
            this.btnWriteReview.Location = new System.Drawing.Point(450, 10);
            this.btnWriteReview.Name = "btnWriteReview";
            this.btnWriteReview.Size = new System.Drawing.Size(120, 35);
            this.btnWriteReview.TabIndex = 2;
            this.btnWriteReview.Text = "Write Review";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.Location = new System.Drawing.Point(600, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelFilters
            this.panelFilters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFilters.Controls.Add(this.lblSpec);
            this.panelFilters.Controls.Add(this.cmbSpecialization);
            this.panelFilters.Controls.Add(this.lblClinic);
            this.panelFilters.Controls.Add(this.cmbClinic);
            this.panelFilters.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFilters.Location = new System.Drawing.Point(0, 60);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(200, 540);

            // lblSpec
            this.lblSpec.Location = new System.Drawing.Point(10, 20);
            this.lblSpec.Text = "Specialization:";

            // cmbSpecialization
            this.cmbSpecialization.Location = new System.Drawing.Point(10, 45);
            this.cmbSpecialization.Size = new System.Drawing.Size(160, 24);

            // lblClinic
            this.lblClinic.Location = new System.Drawing.Point(10, 90);
            this.lblClinic.Text = "Clinic:";

            // cmbClinic
            this.cmbClinic.Location = new System.Drawing.Point(10, 115);
            this.cmbClinic.Size = new System.Drawing.Size(160, 24);
            //
            // panelDoctorsList
            // 
            this.panelDoctorsList.AutoScroll = true;
            this.panelDoctorsList.BackColor = System.Drawing.Color.White;
            this.panelDoctorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoctorsList.Location = new System.Drawing.Point(200, 60);
            this.panelDoctorsList.Name = "panelDoctorsList";
            this.panelDoctorsList.Size = new System.Drawing.Size(800, 540);
            this.panelDoctorsList.TabIndex = 0;
            this.panelDoctorsList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDoctorsList_Paint);
            // 
            // PatientHomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelDoctorsList);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.panelHeader);
            this.Name = "PatientHomePageForm";
            this.Text = "Patient Home Page";
            this.Load += new System.EventHandler(this.PatientHomePageForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnMyAppointments;
        private System.Windows.Forms.Button btnWriteReview;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.ComboBox cmbClinic;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.Label lblClinic;
        private System.Windows.Forms.Label lblDept;

        private System.Windows.Forms.FlowLayoutPanel panelDoctorsList;
    }
}
