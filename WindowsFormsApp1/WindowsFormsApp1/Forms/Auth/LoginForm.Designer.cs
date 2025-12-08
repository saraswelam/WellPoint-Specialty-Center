namespace WindowsFormsApp1.Forms.Auth
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginToyourAccountLabel;
        private System.Windows.Forms.LinkLabel SignUpLinkLabel;
        private System.Windows.Forms.Label WellPointSpecialtyCenterLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelContainer = new System.Windows.Forms.Panel();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginToyourAccountLabel = new System.Windows.Forms.Label();
            this.SignUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.WellPointSpecialtyCenterLabel = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.EmailTextBox);
            this.panelContainer.Controls.Add(this.PasswordTextBox);
            this.panelContainer.Controls.Add(this.LoginButton);
            this.panelContainer.Controls.Add(this.EmailLabel);
            this.panelContainer.Controls.Add(this.PasswordLabel);
            this.panelContainer.Controls.Add(this.LoginToyourAccountLabel);
            this.panelContainer.Controls.Add(this.SignUpLinkLabel);
            this.panelContainer.Controls.Add(this.WellPointSpecialtyCenterLabel);
            this.panelContainer.Location = new System.Drawing.Point(326, 120);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(527, 500);
            this.panelContainer.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.EmailTextBox.Location = new System.Drawing.Point(50, 170);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(380, 32);
            this.EmailTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PasswordTextBox.Location = new System.Drawing.Point(50, 260);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(380, 32);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(50, 330);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(380, 45);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmailLabel.Location = new System.Drawing.Point(50, 140);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(59, 28);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordLabel.Location = new System.Drawing.Point(50, 230);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(93, 28);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginToyourAccountLabel
            // 
            this.LoginToyourAccountLabel.AutoSize = true;
            this.LoginToyourAccountLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginToyourAccountLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.LoginToyourAccountLabel.Location = new System.Drawing.Point(120, 70);
            this.LoginToyourAccountLabel.Name = "LoginToyourAccountLabel";
            this.LoginToyourAccountLabel.Size = new System.Drawing.Size(302, 37);
            this.LoginToyourAccountLabel.TabIndex = 5;
            this.LoginToyourAccountLabel.Text = "Login to your Account";
            // 
            // SignUpLinkLabel
            // 
            this.SignUpLinkLabel.AutoSize = true;
            this.SignUpLinkLabel.Location = new System.Drawing.Point(145, 400);
            this.SignUpLinkLabel.Name = "SignUpLinkLabel";
            this.SignUpLinkLabel.Size = new System.Drawing.Size(235, 16);
            this.SignUpLinkLabel.TabIndex = 6;
            this.SignUpLinkLabel.TabStop = true;
            this.SignUpLinkLabel.Text = "Don\'t have an account? Click to signup";
            this.SignUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // WellPointSpecialtyCenterLabel
            // 
            this.WellPointSpecialtyCenterLabel.AutoSize = true;
            this.WellPointSpecialtyCenterLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WellPointSpecialtyCenterLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.WellPointSpecialtyCenterLabel.Location = new System.Drawing.Point(70, 10);
            this.WellPointSpecialtyCenterLabel.Name = "WellPointSpecialtyCenterLabel";
            this.WellPointSpecialtyCenterLabel.Size = new System.Drawing.Size(442, 46);
            this.WellPointSpecialtyCenterLabel.TabIndex = 7;
            this.WellPointSpecialtyCenterLabel.Text = "WellPoint Specialty Center";
            // 
            // LoginForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelContainer);
            this.Name = "LoginForm";
            this.Text = "LoginPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
