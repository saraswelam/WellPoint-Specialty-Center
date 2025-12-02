using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblDoctor;
        private Label lblAppt;
        private Label lblFee;

        private Label lblMethod;
        private ComboBox cmbMethod;

        private Button btnPayNow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            this.Text = "Payment";
            this.StartPosition = FormStartPosition.CenterParent;
            this.ClientSize = new Size(460, 380);
            this.BackColor = Color.WhiteSmoke;

            // ===========================
            // Title
            // ===========================
            lblTitle = new Label();
            lblTitle.Text = "Confirm Appointment";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(90, 20);

            // ===========================
            // Doctor label
            // ===========================
            lblDoctor = new Label();
            lblDoctor.Font = new Font("Segoe UI", 12);
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(30, 80);

            // ===========================
            // Appointment summary
            // ===========================
            lblAppt = new Label();
            lblAppt.Font = new Font("Segoe UI", 12);
            lblAppt.AutoSize = true;
            lblAppt.Location = new Point(30, 115);

            // ===========================
            // Fee Label
            // ===========================
            lblFee = new Label();
            lblFee.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblFee.AutoSize = true;
            lblFee.Location = new Point(30, 150);

            // ===========================
            // Payment method selector
            // ===========================
            lblMethod = new Label();
            lblMethod.Text = "Payment Method:";
            lblMethod.Font = new Font("Segoe UI", 12);
            lblMethod.AutoSize = true;
            lblMethod.Location = new Point(30, 195);

            cmbMethod = new ComboBox();
            cmbMethod.Font = new Font("Segoe UI", 11);
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethod.Items.AddRange(new object[] { "cash", "credit card", "insurance" });
            cmbMethod.SelectedIndex = 0;
            cmbMethod.Location = new Point(180, 195);
            cmbMethod.Size = new Size(180, 30);

            // ===========================
            // Pay button
            // ===========================
            btnPayNow = new Button();
            btnPayNow.Text = "Pay & Book";
            btnPayNow.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnPayNow.Size = new Size(200, 45);
            btnPayNow.Location = new Point(120, 260);
            btnPayNow.BackColor = Color.FromArgb(41, 128, 185);
            btnPayNow.ForeColor = Color.White;
            btnPayNow.FlatStyle = FlatStyle.Flat;
            btnPayNow.FlatAppearance.BorderSize = 0;
            btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);

            // ===========================
            // Add Controls
            // ===========================
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblDoctor);
            this.Controls.Add(lblAppt);
            this.Controls.Add(lblFee);
            this.Controls.Add(lblMethod);
            this.Controls.Add(cmbMethod);
            this.Controls.Add(btnPayNow);

            this.Load += new System.EventHandler(this.PaymentForm_Load);
        }
    }
}
