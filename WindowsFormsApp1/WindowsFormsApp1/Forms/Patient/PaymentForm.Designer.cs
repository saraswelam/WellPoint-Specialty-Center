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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblAppt = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(90, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Confirm Appointment";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDoctor.Location = new System.Drawing.Point(30, 80);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(0, 28);
            this.lblDoctor.TabIndex = 1;
            // 
            // lblAppt
            // 
            this.lblAppt.AutoSize = true;
            this.lblAppt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAppt.Location = new System.Drawing.Point(30, 115);
            this.lblAppt.Name = "lblAppt";
            this.lblAppt.Size = new System.Drawing.Size(0, 28);
            this.lblAppt.TabIndex = 2;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFee.Location = new System.Drawing.Point(30, 150);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(0, 28);
            this.lblFee.TabIndex = 3;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMethod.Location = new System.Drawing.Point(30, 195);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(166, 28);
            this.lblMethod.TabIndex = 4;
            this.lblMethod.Text = "Payment Method:";
            // 
            // cmbMethod
            // 
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbMethod.Items.AddRange(new object[] {
            "cash",
            "credit card",
            "insurance"});
            this.cmbMethod.Location = new System.Drawing.Point(282, 190);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(180, 33);
            this.cmbMethod.TabIndex = 5;
            // 
            // btnPayNow
            // 
            this.btnPayNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPayNow.FlatAppearance.BorderSize = 0;
            this.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(190, 305);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(200, 45);
            this.btnPayNow.TabIndex = 6;
            this.btnPayNow.Text = "Pay & Book";
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // PaymentForm
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(656, 476);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblAppt);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.btnPayNow);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
