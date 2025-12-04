namespace WindowsFormsApp1.Forms.Admin
{
    partial class ViewReviewsForm
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
            this.ReviewsLabel = new System.Windows.Forms.Label();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.ReviewsGrid = new System.Windows.Forms.DataGridView();
            this.TopPanel.SuspendLayout();
            this.MainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.ReviewsLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 67);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TopPanel_Paint);
            // 
            // ReviewsLabel
            // 
            this.ReviewsLabel.AutoSize = true;
            this.ReviewsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ReviewsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewsLabel.Location = new System.Drawing.Point(310, 17);
            this.ReviewsLabel.Name = "ReviewsLabel";
            this.ReviewsLabel.Size = new System.Drawing.Size(206, 32);
            this.ReviewsLabel.TabIndex = 0;
            this.ReviewsLabel.Text = "ALL REVIEWS";
            this.ReviewsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Controls.Add(this.ReviewsGrid);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 67);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(800, 499);
            this.MainContentPanel.TabIndex = 1;
            // 
            // ReviewsGrid
            // 
            this.ReviewsGrid.AllowUserToAddRows = false;
            this.ReviewsGrid.AllowUserToDeleteRows = false;
            this.ReviewsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReviewsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReviewsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewsGrid.Location = new System.Drawing.Point(0, 0);
            this.ReviewsGrid.Name = "ReviewsGrid";
            this.ReviewsGrid.ReadOnly = true;
            this.ReviewsGrid.RowHeadersWidth = 51;
            this.ReviewsGrid.RowTemplate.Height = 24;
            this.ReviewsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReviewsGrid.Size = new System.Drawing.Size(800, 499);
            this.ReviewsGrid.TabIndex = 0;
            this.ReviewsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReviewsGrid_CellContentClick);
            // 
            // ViewReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.TopPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewReviewsForm";
            this.Text = "View Reviews";
            this.Load += new System.EventHandler(this.ViewReviewsForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReviewsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label ReviewsLabel;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.DataGridView ReviewsGrid;
    }
}