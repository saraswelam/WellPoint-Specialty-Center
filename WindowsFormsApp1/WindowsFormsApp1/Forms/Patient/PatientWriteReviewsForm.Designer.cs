using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    partial class PatientWriteReviewsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelCard;
        private Label lblTitle;
        private Label lblSelectAppointment;
        private ComboBox cmbAppointments;
        private Label lblRating;
        private NumericUpDown numRating;
        private Label lblComment;
        private TextBox txtReview;
        private Button btnSubmit;
        private Button btnBack;
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblSelectAppointment = new System.Windows.Forms.Label();
            this.cmbAppointments = new System.Windows.Forms.ComboBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
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
            this.headerPanel.Size = new System.Drawing.Size(1200, 75);
            this.headerPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(130, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(257, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Write a Review";
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelCard.Controls.Add(this.lblSelectAppointment);
            this.panelCard.Controls.Add(this.cmbAppointments);
            this.panelCard.Controls.Add(this.lblRating);
            this.panelCard.Controls.Add(this.numRating);
            this.panelCard.Controls.Add(this.lblComment);
            this.panelCard.Controls.Add(this.txtReview);
            this.panelCard.Controls.Add(this.btnSubmit);
            this.panelCard.Location = new System.Drawing.Point(250, 120);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(30);
            this.panelCard.Size = new System.Drawing.Size(700, 500);
            this.panelCard.TabIndex = 1;
            this.panelCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCard_Paint);
            // 
            // lblSelectAppointment
            // 
            this.lblSelectAppointment.AutoSize = true;
            this.lblSelectAppointment.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSelectAppointment.Location = new System.Drawing.Point(10, 20);
            this.lblSelectAppointment.Name = "lblSelectAppointment";
            this.lblSelectAppointment.Size = new System.Drawing.Size(278, 25);
            this.lblSelectAppointment.TabIndex = 0;
            this.lblSelectAppointment.Text = "Select Completed Appointment:";
            // 
            // cmbAppointments
            // 
            this.cmbAppointments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAppointments.Location = new System.Drawing.Point(14, 50);
            this.cmbAppointments.Name = "cmbAppointments";
            this.cmbAppointments.Size = new System.Drawing.Size(640, 31);
            this.cmbAppointments.TabIndex = 1;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblRating.Location = new System.Drawing.Point(10, 100);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(117, 25);
            this.lblRating.TabIndex = 2;
            this.lblRating.Text = "Rating (1–5):";
            // 
            // numRating
            // 
            this.numRating.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numRating.Location = new System.Drawing.Point(14, 130);
            this.numRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRating.Name = "numRating";
            this.numRating.Size = new System.Drawing.Size(80, 30);
            this.numRating.TabIndex = 3;
            this.numRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblComment.Location = new System.Drawing.Point(10, 180);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(186, 25);
            this.lblComment.TabIndex = 4;
            this.lblComment.Text = "Write your feedback:";
            // 
            // txtReview
            // 
            this.txtReview.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtReview.Location = new System.Drawing.Point(14, 210);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReview.Size = new System.Drawing.Size(640, 200);
            this.txtReview.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(14, 425);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 40);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit Review";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // PatientWriteReviewsForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panelCard);
            this.Name = "PatientWriteReviewsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PatientWriteReviewsForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
