using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp1.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
       
        private readonly WindowsFormsApp1.Models.Admin _admin;

       
        private Form _activeChildForm = null;

     
        private readonly Color _activeBackColor = Color.FromArgb(255, 192, 192); 
        private readonly Color _inactiveBackColor = Color.FromArgb(240, 240, 240); 

        public AdminDashboardForm(WindowsFormsApp1.Models.Admin admin)
        {
            InitializeComponent();
            
            _admin = admin;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            

            try
            {
                
                ManageDoctorsButton.PerformClick();
            }
            catch {  }
        }

        
        private void LoadChildForm(Form child, Button sourceButton)
        {
            try
            {
                
                if (_activeChildForm != null)
                {
                    _activeChildForm.Close();
                    _activeChildForm.Dispose();
                    _activeChildForm = null;
                }

                _activeChildForm = child;

                
                child.TopLevel = false;
                child.FormBorderStyle = FormBorderStyle.None;
                child.Dock = DockStyle.Fill;

                MainContentPanel.Controls.Clear();
                MainContentPanel.Controls.Add(child);
                MainContentPanel.Tag = child;

                child.Show();

                HighlightButton(sourceButton);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load page: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void HighlightButton(Button active)
        {
           
            var buttons = new List<Button> {
                ManageDoctorsButton,
                AllAppointmentsButton,
                ViewPaymentsButton,
                ViewReviewsButton,
                GenerateReportsButton,
                LogoutButton
            };

            foreach (var b in buttons)
            {
                if (b == null) continue; 
                if (b == active)
                {
                    b.BackColor = _activeBackColor;
                    b.FlatStyle = FlatStyle.Flat;
                    b.Font = new Font(b.Font, FontStyle.Bold);
                }
                else
                {
                    b.BackColor = _inactiveBackColor;
                    b.FlatStyle = FlatStyle.Standard;
                    b.Font = new Font(b.Font, FontStyle.Regular);
                }
            }
        }

        

        private void ManageDoctorsButton_Click(object sender, EventArgs e)
        {
            
            var form = new ManageDoctorsForm(); 
            LoadChildForm(form, ManageDoctorsButton);
        }

        private void AllAppointmentsButton_Click(object sender, EventArgs e)
        {
            var form = new AllAppointmentsForm(); 
            LoadChildForm(form, AllAppointmentsButton);
        }

        private void ViewPaymentsButton_Click(object sender, EventArgs e)
        {
            var form = new ViewPaymentsForm(); 
            LoadChildForm(form, ViewPaymentsButton);
        }

        private void ViewReviewsButton_Click(object sender, EventArgs e)
        {
            var form = new ViewReviewsForm();
            LoadChildForm(form, ViewReviewsButton);
        }

        private void GenerateReportsButton_Click(object sender, EventArgs e)
        {
            
            var form = new GenerateReportsForm(); 
            LoadChildForm(form, GenerateReportsButton);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                
                var res = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res != DialogResult.Yes) return;

                
                if (_activeChildForm != null)
                {
                    _activeChildForm.Close();
                    _activeChildForm.Dispose();
                    _activeChildForm = null;
                }

                
                var login = new WindowsFormsApp1.Forms.Auth.LoginForm();
                login.Show();

                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Logout error: " + ex.Message);
            }
        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
