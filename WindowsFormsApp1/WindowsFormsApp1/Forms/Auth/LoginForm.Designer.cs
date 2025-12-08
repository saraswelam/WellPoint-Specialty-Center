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
            // LoginForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.Add(this.panelContainer);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Text = "LoginPage";
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContainer.Size = new System.Drawing.Size(500, 500);
            this.panelContainer.Location = new System.Drawing.Point(
                (this.ClientSize.Width - 500) / 2,
                (this.ClientSize.Height - 500) / 2);
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContainer.Controls.Add(this.EmailTextBox);
            this.panelContainer.Controls.Add(this.PasswordTextBox);
            this.panelContainer.Controls.Add(this.LoginButton);
            this.panelContainer.Controls.Add(this.EmailLabel);
            this.panelContainer.Controls.Add(this.PasswordLabel);
            this.panelContainer.Controls.Add(this.LoginToyourAccountLabel);
            this.panelContainer.Controls.Add(this.SignUpLinkLabel);
            this.panelContainer.Controls.Add(this.WellPointSpecialtyCenterLabel);
            // 
            // EmailLabel
            // 
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmailLabel.Location = new System.Drawing.Point(50, 140);
            this.EmailLabel.AutoSize = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(50, 170);
            this.EmailTextBox.Size = new System.Drawing.Size(380, 28);
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordLabel.Location = new System.Drawing.Point(50, 230);
            this.PasswordLabel.AutoSize = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(50, 260);
            this.PasswordTextBox.Size = new System.Drawing.Size(380, 28);
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LoginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Size = new System.Drawing.Size(380, 45);
            this.LoginButton.Location = new System.Drawing.Point(50, 330);
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginToyourAccountLabel
            // 
            this.LoginToyourAccountLabel.Text = "Login to your Account";
            this.LoginToyourAccountLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.LoginToyourAccountLabel.Location = new System.Drawing.Point(120, 70);
            this.LoginToyourAccountLabel.AutoSize = true;
            // 
            // WellPointSpecialtyCenterLabel
            // 
            this.WellPointSpecialtyCenterLabel.Text = "WellPoint Specialty Center";
            this.WellPointSpecialtyCenterLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.WellPointSpecialtyCenterLabel.AutoSize = true;
            this.WellPointSpecialtyCenterLabel.Location = new System.Drawing.Point(70, 10);
            // 
            // SignUpLinkLabel
            // 
            this.SignUpLinkLabel.Text = "Don't have an account? Click to signup";
            this.SignUpLinkLabel.Location = new System.Drawing.Point(145, 400);
            this.SignUpLinkLabel.AutoSize = true;
            this.SignUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Finalize Layout
            // 
            this.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
        }
    }
}
