using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
 // if you need to reference other admin forms
   // for Admin model (constructor param)

namespace WindowsFormsApp1.Forms.Admin
{
    public partial class AdminDashboardForm : Form
    {
        // Fix: Use fully qualified type if 'Admin' is a class inside a namespace
        private readonly WindowsFormsApp1.Models.Admin _admin;

        // Keep track of the currently loaded child form
        private Form _activeChildForm = null;

        // Colors for highlighting active button (adjust to your UI palette)
        private readonly Color _activeBackColor = Color.FromArgb(255, 192, 192); // light pink
        private readonly Color _inactiveBackColor = Color.FromArgb(240, 240, 240); // default

        public AdminDashboardForm(WindowsFormsApp1.Models.Admin admin)
        {
            InitializeComponent();
            
            _admin = admin;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            // Optional: show a default view on load
            // e.g. show ManageDoctors on start
            try
            {
                // If you want default page, call its handler or directly load the child form:
                ManageDoctorsButton.PerformClick();
            }
            catch { /* ignore designer-time calls */ }
        }

        // ---------------------------
        // Generic loader for child forms
        // ---------------------------
        private void LoadChildForm(Form child, Button sourceButton)
        {
            try
            {
                // close & dispose any active child
                if (_activeChildForm != null)
                {
                    _activeChildForm.Close();
                    _activeChildForm.Dispose();
                    _activeChildForm = null;
                }

                _activeChildForm = child;

                // configure child form to appear inside panel
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

        // ---------------------------
        // Visual highlight for active menu button
        // ---------------------------
        private void HighlightButton(Button active)
        {
            // gather sidebar buttons (update list if names differ)
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
                if (b == null) continue; // in case designer hasn't wired
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

        // ---------------------------
        // Button handlers
        // ---------------------------

        private void ManageDoctorsButton_Click(object sender, EventArgs e)
        {
            // If your ManageDoctorsForm has constructor accepting Admin or services, pass them
            var form = new ManageDoctorsForm(); // or new ManageDoctorsForm(_admin)
            LoadChildForm(form, ManageDoctorsButton);
        }

        private void AllAppointmentsButton_Click(object sender, EventArgs e)
        {
            var form = new AllAppointmentsForm(); // or pass services if required
            LoadChildForm(form, AllAppointmentsButton);
        }

        private void ViewPaymentsButton_Click(object sender, EventArgs e)
        {
            var form = new ViewPaymentsForm(); // optionally pass admin or DB service
            LoadChildForm(form, ViewPaymentsButton);
        }

        private void ViewReviewsButton_Click(object sender, EventArgs e)
        {
            var form = new ViewReviewsForm();
            LoadChildForm(form, ViewReviewsButton);
        }

        private void GenerateReportsButton_Click(object sender, EventArgs e)
        {
            // Load the Reports form (you called it GenerateReportsForm in project)
            var form = new GenerateReportsForm(); // this will host your 4 pipelines UI
            LoadChildForm(form, GenerateReportsButton);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Close dashboard and return to login
            try
            {
                // Optionally confirm logout
                var res = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res != DialogResult.Yes) return;

                // Close and dispose child form first
                if (_activeChildForm != null)
                {
                    _activeChildForm.Close();
                    _activeChildForm.Dispose();
                    _activeChildForm = null;
                }

                // Show login
                var login = new WindowsFormsApp1.Forms.Auth.LoginForm();
                login.Show();

                // Close dashboard
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
    }
}
