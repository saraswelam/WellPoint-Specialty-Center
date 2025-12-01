using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Fix namespace conflict
using DoctorModel = global::Doctor;

namespace WindowsFormsApp1.Forms.Patient
{
    public partial class ViewDrProfileForm : Form
    {
        private DoctorModel _doctor;

        public ViewDrProfileForm(DoctorModel doctor)
        {
            InitializeComponent();
            _doctor = doctor;
        }

        private void ViewDrProfileForm_Load(object sender, EventArgs e)
        {
            DisplayDoctorInfo();
        }

        private void DisplayDoctorInfo()
        {
            lblDrName.Text = $"{_doctor.FirstName} {_doctor.LastName}";
            lblSpecialization.Text = $"Specialization: {_doctor.Specialization}";
        }
    }
}
