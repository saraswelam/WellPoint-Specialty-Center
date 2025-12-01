namespace WindowsFormsApp1.Forms.Patient
{
    partial class ViewDrProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblDrName;
        private System.Windows.Forms.Label lblSpecialization;

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
            this.lblDrName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDrName
            // 
            this.lblDrName.AutoSize = true;
            this.lblDrName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDrName.Location = new System.Drawing.Point(30, 30);
            this.lblDrName.Name = "lblDrName";
            this.lblDrName.Size = new System.Drawing.Size(130, 24);
            this.lblDrName.TabIndex = 0;
            this.lblDrName.Text = "Doctor Name";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Font = new System.Drawing.Font("Arial", 10F);
            this.lblSpecialization.Location = new System.Drawing.Point(30, 70);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(115, 19);
            this.lblSpecialization.TabIndex = 1;
            this.lblSpecialization.Text = "Specialization";
            // 
            // ViewDrProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDrName);
            this.Controls.Add(this.lblSpecialization);
            this.Name = "ViewDrProfileForm";
            this.Text = "Doctor Profile";
            this.Load += new System.EventHandler(this.ViewDrProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
