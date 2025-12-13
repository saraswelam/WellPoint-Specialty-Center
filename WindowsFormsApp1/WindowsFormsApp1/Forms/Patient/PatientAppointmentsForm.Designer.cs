using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    partial class PatientAppointmentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel panelAppointments;
        private Button btnBack;
        private Label lblTitle;
        private Panel headerPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelAppointments = new System.Windows.Forms.FlowLayoutPanel();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.headerPanel.Controls.Add(this.btnBack);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1300, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Location = new System.Drawing.Point(20, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(130, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 45);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "My Appointments";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelAppointments
            // 
            this.panelAppointments.AutoScroll = true;
            this.panelAppointments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAppointments.Location = new System.Drawing.Point(0, 80);
            this.panelAppointments.Name = "panelAppointments";
            this.panelAppointments.Padding = new System.Windows.Forms.Padding(30);
            this.panelAppointments.Size = new System.Drawing.Size(1300, 820);
            this.panelAppointments.TabIndex = 1;
            this.panelAppointments.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAppointments_Paint_1);
            // 
            // PatientAppointmentsForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Controls.Add(this.panelAppointments);
            this.Controls.Add(this.headerPanel);
            this.Name = "PatientAppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Appointments";
            this.Load += new System.EventHandler(this.PatientAppointmentsForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    }
}
