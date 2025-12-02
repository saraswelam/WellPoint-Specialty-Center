using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    partial class PatientAppointmentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel panelAppointments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelAppointments = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // panelAppointments
            this.panelAppointments.AutoScroll = true;
            this.panelAppointments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAppointments.Location = new System.Drawing.Point(40, 90);
            this.panelAppointments.Name = "panelAppointments";
            this.panelAppointments.Size = new System.Drawing.Size(1200, 750);
            this.panelAppointments.TabIndex = 0;

            // btnBack
            this.btnBack.Text = "← Back";
            this.btnBack.Font = new Font("Segoe UI", 11);
            this.btnBack.Location = new Point(20, 20);
            this.btnBack.Size = new Size(100, 35);
            this.btnBack.BackColor = Color.SteelBlue;
            this.btnBack.ForeColor = Color.White;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Click += (s, e) => this.Close();

            // lblTitle
            this.lblTitle.Text = "My Appointments";
            this.lblTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            this.lblTitle.Location = new Point(150, 18);
            this.lblTitle.AutoSize = true;

            // Form
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.panelAppointments);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Name = "PatientAppointmentsForm";
            this.Text = "My Appointments";
            this.Load += new System.EventHandler(this.PatientAppointmentsForm_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
