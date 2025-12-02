using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    partial class PatientWriteReviewsForm
    {
        private ComboBox cmbDoctors;
        private NumericUpDown numRating;
        private TextBox txtReview;
        private Button btnSubmit;

        private void InitializeComponent()
        {
            this.cmbDoctors = new System.Windows.Forms.ComboBox();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDoctors
            // 
            this.cmbDoctors.Location = new System.Drawing.Point(40, 40);
            this.cmbDoctors.Name = "cmbDoctors";
            this.cmbDoctors.Size = new System.Drawing.Size(300, 24);
            this.cmbDoctors.TabIndex = 0;
            // 
            // numRating
            // 
            this.numRating.Location = new System.Drawing.Point(40, 100);
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
            this.numRating.Size = new System.Drawing.Size(120, 22);
            this.numRating.TabIndex = 1;
            this.numRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(40, 160);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(400, 150);
            this.txtReview.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(40, 330);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Review";
            // 
            // PatientWriteReviewsForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.cmbDoctors);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.btnSubmit);
            this.Name = "PatientWriteReviewsForm";
            this.Text = "Write Review";
            this.Load += new System.EventHandler(this.PatientWriteReviewsForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
