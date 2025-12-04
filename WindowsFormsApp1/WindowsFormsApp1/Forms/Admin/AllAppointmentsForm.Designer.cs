namespace WindowsFormsApp1.Forms.Admin
{
    partial class AllAppointmentsForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentsGrid = new System.Windows.Forms.DataGridView();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.MainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.FilterLabel);
            this.TopPanel.Controls.Add(this.FilterComboBox);
            this.TopPanel.Controls.Add(this.SearchTextBox);
            this.TopPanel.Controls.Add(this.SearchLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 84);
            this.TopPanel.TabIndex = 0;
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Controls.Add(this.AppointmentsGrid);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 84);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(800, 493);
            this.MainContentPanel.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(49, 29);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(81, 25);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "Search";
            this.SearchLabel.Click += new System.EventHandler(this.SearchLabel_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(182, 32);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(197, 22);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(595, 29);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(121, 24);
            this.FilterComboBox.TabIndex = 3;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // AppointmentsGrid
            // 
            this.AppointmentsGrid.AllowUserToAddRows = false;
            this.AppointmentsGrid.AllowUserToDeleteRows = false;
            this.AppointmentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsGrid.Location = new System.Drawing.Point(12, 15);
            this.AppointmentsGrid.Name = "AppointmentsGrid";
            this.AppointmentsGrid.ReadOnly = true;
            this.AppointmentsGrid.RowHeadersWidth = 51;
            this.AppointmentsGrid.RowTemplate.Height = 24;
            this.AppointmentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsGrid.Size = new System.Drawing.Size(785, 466);
            this.AppointmentsGrid.TabIndex = 0;
            this.AppointmentsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsGrid_CellContentClick);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLabel.Location = new System.Drawing.Point(426, 28);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(153, 25);
            this.FilterLabel.TabIndex = 4;
            this.FilterLabel.Text = "Filter by status";
            this.FilterLabel.Click += new System.EventHandler(this.FilterLabel_Click);
            // 
            // AllAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.TopPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllAppointmentsForm";
            this.Text = "All Appointments";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.DataGridView AppointmentsGrid;
        private System.Windows.Forms.Label FilterLabel;
    }
}