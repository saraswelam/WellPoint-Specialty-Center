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

            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();

            // -------------------------------
            // HEADER PANEL (matches Appointments screen)
            // -------------------------------
            this.headerPanel.BackColor = Color.SteelBlue;
            this.headerPanel.Controls.Add(this.btnBack);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Location = new Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new Size(1200, 75);

            // BACK BUTTON
            this.btnBack.BackColor = Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnBack.ForeColor = Color.SteelBlue;
            this.btnBack.Location = new Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new Size(90, 35);
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // TITLE
            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Location = new Point(130, 17);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Text = "Write a Review";

            // -------------------------------
            // MAIN CARD PANEL
            // -------------------------------
            this.panelCard.BackColor = Color.White;
            this.panelCard.Location = new Point(250, 120);   // visually centered
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new Size(700, 500);
            this.panelCard.Padding = new Padding(30);

            // SELECT APPOINTMENT LABEL
            this.lblSelectAppointment.AutoSize = true;
            this.lblSelectAppointment.Font = new Font("Segoe UI", 11F);
            this.lblSelectAppointment.Location = new Point(10, 20);
            this.lblSelectAppointment.Text = "Select Completed Appointment:";

            // COMBOBOX
            this.cmbAppointments.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbAppointments.Font = new Font("Segoe UI", 10F);
            this.cmbAppointments.Location = new Point(14, 50);
            this.cmbAppointments.Size = new Size(640, 28);

            // RATING LABEL
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new Font("Segoe UI", 11F);
            this.lblRating.Location = new Point(10, 100);
            this.lblRating.Text = "Rating (1–5):";

            // RATING CONTROL
            this.numRating.Font = new Font("Segoe UI", 10F);
            this.numRating.Location = new Point(14, 130);
            this.numRating.Minimum = 1;
            this.numRating.Maximum = 5;
            this.numRating.Value = 5;
            this.numRating.Size = new Size(80, 27);

            // COMMENT LABEL
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new Font("Segoe UI", 11F);
            this.lblComment.Location = new Point(10, 180);
            this.lblComment.Text = "Write your feedback:";

            // COMMENT TEXTBOX
            this.txtReview.Font = new Font("Segoe UI", 10F);
            this.txtReview.Location = new Point(14, 210);
            this.txtReview.Multiline = true;
            this.txtReview.ScrollBars = ScrollBars.Vertical;
            this.txtReview.Size = new Size(640, 200);

            // SUBMIT BUTTON
            this.btnSubmit.BackColor = Color.FromArgb(52, 152, 219);
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = FlatStyle.Flat;
            this.btnSubmit.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnSubmit.ForeColor = Color.White;
            this.btnSubmit.Location = new Point(14, 425);
            this.btnSubmit.Size = new Size(200, 40);
            this.btnSubmit.Text = "Submit Review";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // -------------------------------
            // ADDING CONTROLS
            // -------------------------------
            this.panelCard.Controls.Add(this.lblSelectAppointment);
            this.panelCard.Controls.Add(this.cmbAppointments);
            this.panelCard.Controls.Add(this.lblRating);
            this.panelCard.Controls.Add(this.numRating);
            this.panelCard.Controls.Add(this.lblComment);
            this.panelCard.Controls.Add(this.txtReview);
            this.panelCard.Controls.Add(this.btnSubmit);

            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panelCard);

            // -------------------------------
            // FORM SETTINGS
            // -------------------------------
            this.BackColor = Color.WhiteSmoke;
            this.ClientSize = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PatientWriteReviewsForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
