// Forms/Patient/PaymentForm.Designer.cs
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblDoctor;
        private Label lblAppt;
        private Label lblFee;
        private ComboBox cmbMethod;
        private Button btnPayNow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDoctor = new Label { Location = new Point(16, 16), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold) };
            this.lblAppt = new Label { Location = new Point(16, 44), AutoSize = true };
            this.lblFee = new Label { Location = new Point(16, 72), AutoSize = true };
            this.cmbMethod = new ComboBox { Location = new Point(16, 110), Width = 220 };
            cmbMethod.Items.AddRange(new string[] { "credit card", "cash", "insurance" });
            cmbMethod.SelectedIndex = 0;
            this.btnPayNow = new Button { Text = "Pay Now / Confirm", Location = new Point(16, 150), Width = 220, Height = 34, BackColor = Color.FromArgb(41, 128, 185), ForeColor = Color.White };

            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);

            this.ClientSize = new Size(380, 220);
            this.Controls.Add(lblDoctor);
            this.Controls.Add(lblAppt);
            this.Controls.Add(lblFee);
            this.Controls.Add(cmbMethod);
            this.Controls.Add(btnPayNow);
            this.Text = "Payment";
        }
    }
}
