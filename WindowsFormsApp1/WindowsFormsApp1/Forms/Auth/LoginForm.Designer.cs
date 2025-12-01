namespace WindowsFormsApp1.Forms.Auth
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginToyourAccountLabel = new System.Windows.Forms.Label();
            this.SignUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.WellPointSpecialtyCenterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(317, 211);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(292, 22);
            this.EmailTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(317, 301);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(292, 22);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LoginButton.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(375, 366);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(160, 49);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "LOGIN";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailLabel.Location = new System.Drawing.Point(150, 211);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(60, 25);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordLabel.Location = new System.Drawing.Point(150, 297);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(98, 25);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginToyourAccountLabel
            // 
            this.LoginToyourAccountLabel.AutoSize = true;
            this.LoginToyourAccountLabel.BackColor = System.Drawing.Color.DarkGray;
            this.LoginToyourAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoginToyourAccountLabel.Location = new System.Drawing.Point(323, 133);
            this.LoginToyourAccountLabel.Name = "LoginToyourAccountLabel";
            this.LoginToyourAccountLabel.Size = new System.Drawing.Size(276, 31);
            this.LoginToyourAccountLabel.TabIndex = 5;
            this.LoginToyourAccountLabel.Text = "Login to your Account";
            this.LoginToyourAccountLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // SignUpLinkLabel
            // 
            this.SignUpLinkLabel.AutoSize = true;
            this.SignUpLinkLabel.Location = new System.Drawing.Point(326, 446);
            this.SignUpLinkLabel.Name = "SignUpLinkLabel";
            this.SignUpLinkLabel.Size = new System.Drawing.Size(260, 16);
            this.SignUpLinkLabel.TabIndex = 6;
            this.SignUpLinkLabel.TabStop = true;
            this.SignUpLinkLabel.Text = "Don\'t have an account?click here to signup";
            this.SignUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // WellPointSpecialtyCenterLabel
            // 
            this.WellPointSpecialtyCenterLabel.AutoSize = true;
            this.WellPointSpecialtyCenterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WellPointSpecialtyCenterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.WellPointSpecialtyCenterLabel.Location = new System.Drawing.Point(246, 21);
            this.WellPointSpecialtyCenterLabel.Name = "WellPointSpecialtyCenterLabel";
            this.WellPointSpecialtyCenterLabel.Size = new System.Drawing.Size(421, 39);
            this.WellPointSpecialtyCenterLabel.TabIndex = 7;
            this.WellPointSpecialtyCenterLabel.Text = "WellPoint Specialty Center";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1133, 529);
            this.Controls.Add(this.WellPointSpecialtyCenterLabel);
            this.Controls.Add(this.SignUpLinkLabel);
            this.Controls.Add(this.LoginToyourAccountLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Name = "LoginForm";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginToyourAccountLabel;
        private System.Windows.Forms.LinkLabel SignUpLinkLabel;
        private System.Windows.Forms.Label WellPointSpecialtyCenterLabel;
    }
}