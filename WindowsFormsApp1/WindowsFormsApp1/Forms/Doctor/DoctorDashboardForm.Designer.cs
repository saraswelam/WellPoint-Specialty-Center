namespace WindowsFormsApp1.Forms.Doctor
{
    partial class DoctorDashboardForm
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DoctorDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "DoctorDashboardForm";
            this.Load += new System.EventHandler(this.DoctorDashboardForm_Load_1);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button LogoutButton;
    }
}
