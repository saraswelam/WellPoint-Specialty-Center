namespace WindowsFormsApp1.Forms.Doctor
{
    partial class EditProfileForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.BackButton.Location = new System.Drawing.Point(-1, 1);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(90, 35);
            this.BackButton.TabIndex = 40;
            this.BackButton.Text = "← Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.BackButton);
            this.Name = "EditProfileForm";
            this.Text = "Edit Profile";
            this.Load += new System.EventHandler(this.editprofile_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button BackButton;
    }
}
