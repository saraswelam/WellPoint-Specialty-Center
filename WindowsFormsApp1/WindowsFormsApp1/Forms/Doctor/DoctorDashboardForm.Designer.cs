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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Red;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.Black;
            this.LogoutButton.Location = new System.Drawing.Point(1029, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(120, 44);
            this.LogoutButton.TabIndex = 3;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DoctorDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 450);
            this.Controls.Add(this.LogoutButton);
            this.Name = "DoctorDashboardForm";
            this.Text = "Doctor Dashboard";
            this.Load += new System.EventHandler(this.DoctorDashboardForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button LogoutButton;
    }
}
