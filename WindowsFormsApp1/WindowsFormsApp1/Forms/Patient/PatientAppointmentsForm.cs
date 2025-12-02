using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms.Patient
{
    public partial class PatientAppointmentsForm : Form
    {
        private readonly Models.Patient _patient;
        private readonly AppointmentService _appointmentService;
        private readonly DoctorService _doctorService;

        public PatientAppointmentsForm(Models.Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            _appointmentService = new AppointmentService();
            _doctorService = new DoctorService();

            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
        }

        private void PatientAppointmentsForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            panelAppointments.Controls.Clear();

            var appts = _appointmentService.GetAppointmentsByPatient(_patient.Id);

            if (appts.Count == 0)
            {
                panelAppointments.Controls.Add(new Label
                {
                    Text = "You have no appointments yet.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Margin = new Padding(20)
                });
                return;
            }

            foreach (var appt in appts)
            {
                panelAppointments.Controls.Add(CreateAppointmentCard(appt));
            }
        }

        private Panel CreateAppointmentCard(BsonDocument appt)
        {

            var doctor = _doctorService.GetDoctorById(appt["dr_id"].AsObjectId);
            var apptId = appt.GetValue("_id").AsObjectId;


            Panel card = new Panel
            {
                Width = 650,
                Height = 150,
                BackColor = Color.White,
                Margin = new Padding(20),
               
                Padding = new Padding(15),
                BorderStyle = BorderStyle.FixedSingle
            };

            card.Region = System.Drawing.Region.FromHrgn(
                RoundedRect(card.Width, card.Height, 10)
            );

            Label lblName = new Label
            {
                Text = $"{doctor.FirstName} {doctor.LastName}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblDT = new Label
            {
                Text = $"{appt["app_date"]} at {appt["app_time"]}",
                Font = new Font("Segoe UI", 11),
                Location = new Point(10, 45),
                AutoSize = true
            };

            string status = appt["status"].AsString;

            Label lblStatus = new Label
            {
                Text = $"Status: {status}",
                Font = new Font("Segoe UI", 11, FontStyle.Italic),
                Location = new Point(10, 75),
                ForeColor = status == "scheduled" ? Color.Green : Color.Gray,
                AutoSize = true
            };

            // Cancel button only if scheduled
            if (status.ToLower() == "scheduled")
            {
                Button btnCancel = new Button
                {
                    Text = "Cancel Appointment",
                    Location = new Point(10, 105),
                    Width = 180,
                    Height = 32,
                    BackColor = Color.IndianRed,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btnCancel.FlatAppearance.BorderSize = 0;

                btnCancel.Click += (s, e) =>
                {
                    var confirm = MessageBox.Show(
                        "Are you sure you want to cancel this appointment?",
                        "Confirm Cancel",
                        MessageBoxButtons.YesNo
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        

                        bool success = _appointmentService.CancelAppointment(apptId);

                        if (success)
                        {
                            MessageBox.Show("Appointment cancelled.");
                            LoadAppointments();
                        }
                        else
                        {
                            MessageBox.Show("Error: Unable to cancel appointment.");
                        }
                    }
                };


                card.Controls.Add(btnCancel);
            }

            card.Controls.Add(lblName);
            card.Controls.Add(lblDT);
            card.Controls.Add(lblStatus);

            return card;
        }

        private IntPtr RoundedRect(int width, int height, int radius)
        {
            return CreateRoundRectRgn(0, 0, width, height, radius, radius);
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void panelAppointments_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

