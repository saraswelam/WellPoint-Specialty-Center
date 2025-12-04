namespace WindowsFormsApp1.Forms.Admin
{
    partial class ViewPaymentsForm
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
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.AllPaymentsLabel = new System.Windows.Forms.Label();
            this.PaymentsGrid = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            this.MainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.AllPaymentsLabel);
            this.TopPanel.Controls.Add(this.FilterComboBox);
            this.TopPanel.Controls.Add(this.FilterLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(854, 68);
            this.TopPanel.TabIndex = 0;
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Controls.Add(this.PaymentsGrid);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 68);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(854, 486);
            this.MainContentPanel.TabIndex = 1;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FilterLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLabel.Location = new System.Drawing.Point(383, 30);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(141, 21);
            this.FilterLabel.TabIndex = 0;
            this.FilterLabel.Text = "Filter by status";
            this.FilterLabel.Click += new System.EventHandler(this.FilterLabel_Click);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Location = new System.Drawing.Point(662, 27);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(121, 24);
            this.FilterComboBox.TabIndex = 1;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // AllPaymentsLabel
            // 
            this.AllPaymentsLabel.AutoSize = true;
            this.AllPaymentsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AllPaymentsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPaymentsLabel.Location = new System.Drawing.Point(68, 21);
            this.AllPaymentsLabel.Name = "AllPaymentsLabel";
            this.AllPaymentsLabel.Size = new System.Drawing.Size(189, 27);
            this.AllPaymentsLabel.TabIndex = 2;
            this.AllPaymentsLabel.Text = "ALL PAYMENTS";
            this.AllPaymentsLabel.Click += new System.EventHandler(this.AllPaymentsLabel_Click);
            // 
            // PaymentsGrid
            // 
            this.PaymentsGrid.AllowUserToAddRows = false;
            this.PaymentsGrid.AllowUserToDeleteRows = false;
            this.PaymentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PaymentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentsGrid.Location = new System.Drawing.Point(0, 0);
            this.PaymentsGrid.Name = "PaymentsGrid";
            this.PaymentsGrid.ReadOnly = true;
            this.PaymentsGrid.RowHeadersWidth = 51;
            this.PaymentsGrid.RowTemplate.Height = 24;
            this.PaymentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaymentsGrid.Size = new System.Drawing.Size(854, 486);
            this.PaymentsGrid.TabIndex = 0;
            this.PaymentsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PaymentsGrid_CellContentClick);
            // 
            // ViewPaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 554);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.TopPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewPaymentsForm";
            this.Text = "View Payments";
            this.Load += new System.EventHandler(this.ViewPaymentsForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Label AllPaymentsLabel;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.DataGridView PaymentsGrid;
    }
}