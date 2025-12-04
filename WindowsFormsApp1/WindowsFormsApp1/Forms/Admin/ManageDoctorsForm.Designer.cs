namespace WindowsFormsApp1.Forms.Admin
{
    partial class ManageDoctorsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox SearchTextBox;

        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.ComboBox FilterSpecializationComboBox;

        private System.Windows.Forms.Button AddDoctorButton;

        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button EditDoctorButton;
        private System.Windows.Forms.Button DeleteDoctorButton;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterSpecializationComboBox = new System.Windows.Forms.ComboBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.AddDoctorButton = new System.Windows.Forms.Button();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.EditDoctorButton = new System.Windows.Forms.Button();
            this.DeleteDoctorButton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.MainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.TopPanel.Controls.Add(this.FilterLabel);
            this.TopPanel.Controls.Add(this.FilterSpecializationComboBox);
            this.TopPanel.Controls.Add(this.SearchLabel);
            this.TopPanel.Controls.Add(this.SearchTextBox);
            this.TopPanel.Controls.Add(this.AddDoctorButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(933, 60);
            this.TopPanel.TabIndex = 2;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.FilterLabel.Location = new System.Drawing.Point(330, 20);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(202, 20);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Filter by Specialization";
            // 
            // FilterSpecializationComboBox
            // 
            this.FilterSpecializationComboBox.Location = new System.Drawing.Point(538, 20);
            this.FilterSpecializationComboBox.Name = "FilterSpecializationComboBox";
            this.FilterSpecializationComboBox.Size = new System.Drawing.Size(160, 24);
            this.FilterSpecializationComboBox.TabIndex = 1;
            this.FilterSpecializationComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterSpecializationComboBox_SelectedIndexChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SearchLabel.Location = new System.Drawing.Point(20, 20);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(68, 20);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(100, 18);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(200, 22);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // AddDoctorButton
            // 
            this.AddDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.AddDoctorButton.Location = new System.Drawing.Point(720, 12);
            this.AddDoctorButton.Name = "AddDoctorButton";
            this.AddDoctorButton.Size = new System.Drawing.Size(160, 35);
            this.AddDoctorButton.TabIndex = 4;
            this.AddDoctorButton.Text = "Add Doctor";
            this.AddDoctorButton.UseVisualStyleBackColor = false;
            this.AddDoctorButton.Click += new System.EventHandler(this.AddDoctorButton_Click);
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Controls.Add(this.dataGridView1);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 60);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(933, 437);
            this.MainContentPanel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(933, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.EditDoctorButton);
            this.BottomPanel.Controls.Add(this.DeleteDoctorButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 497);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(933, 80);
            this.BottomPanel.TabIndex = 1;
            // 
            // EditDoctorButton
            // 
            this.EditDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EditDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.EditDoctorButton.Location = new System.Drawing.Point(200, 25);
            this.EditDoctorButton.Name = "EditDoctorButton";
            this.EditDoctorButton.Size = new System.Drawing.Size(190, 35);
            this.EditDoctorButton.TabIndex = 0;
            this.EditDoctorButton.Text = "Edit selected doctor";
            this.EditDoctorButton.UseVisualStyleBackColor = false;
            this.EditDoctorButton.Click += new System.EventHandler(this.EditDoctorButton_Click);
            // 
            // DeleteDoctorButton
            // 
            this.DeleteDoctorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.DeleteDoctorButton.Location = new System.Drawing.Point(430, 25);
            this.DeleteDoctorButton.Name = "DeleteDoctorButton";
            this.DeleteDoctorButton.Size = new System.Drawing.Size(240, 35);
            this.DeleteDoctorButton.TabIndex = 1;
            this.DeleteDoctorButton.Text = "Delete selected doctor";
            this.DeleteDoctorButton.UseVisualStyleBackColor = false;
            this.DeleteDoctorButton.Click += new System.EventHandler(this.DeleteDoctorButton_Click);
            // 
            // ManageDoctorsForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 577);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageDoctorsForm";
            this.Text = "ManageDoctors";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
