using ClinicalBookingSystem.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms.Admin
{
    public partial class EditDoctorForm : Form
    {
        private readonly MongoDBService _db;
        private readonly string _doctorId;
        private WindowsFormsApp1.Models.Doctor _doctorData;

        public EditDoctorForm(string doctorId)
        {
            InitializeComponent();
            _db = new MongoDBService();
            _doctorId = doctorId;

            LoadDoctorData();
            LoadClinics();
            LoadAvailableDays();
        }

        
        private void LoadDoctorData()
        {
            var doctorCol = _db.GetCollection<WindowsFormsApp1.Models.Doctor>("doctors");
            _doctorData = doctorCol.Find(d => d.Id == _doctorId).FirstOrDefault();

            if (_doctorData == null)
            {
                MessageBox.Show("Doctor not found.");
                this.Close();
                return;
            }

           
            FirstNameTextBox.Text = _doctorData.FirstName;
            LastNameTextBox.Text = _doctorData.LastName;
            PhoneTextBox.Text = _doctorData.PhoneNumber;
            ConsultationFeeTextBox.Text = _doctorData.ConsultationFee?.ToString();

            
            if (_doctorData.WorkingHours != null)
            {
                StartDatePicker.Value = DateTime.Parse(_doctorData.WorkingHours.StartTime);
                EndDatePicker.Value = DateTime.Parse(_doctorData.WorkingHours.EndTime);
            }
        }

      
        private void LoadClinics()
        {
            var clinics = _db.GetCollection<Clinic>("clinics").Find(_ => true).ToList();

            ClinicComboBox.DataSource = clinics;
            ClinicComboBox.DisplayMember = "ClinicName";
            ClinicComboBox.ValueMember = "Id";

            ClinicComboBox.SelectedValue = _doctorData.ClinicId;
        }

        
        private void LoadAvailableDays()
        {
            string[] days =
            {
                "Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"
            };

            AvailableDaysCheckList.Items.AddRange(days);

            if (_doctorData.Schedule?.AvailableDays != null)
            {
                for (int i = 0; i < AvailableDaysCheckList.Items.Count; i++)
                {
                    string day = AvailableDaysCheckList.Items[i].ToString();
                    if (_doctorData.Schedule.AvailableDays.Contains(day))
                        AvailableDaysCheckList.SetItemChecked(i, true);
                }
            }
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var doctorCol = _db.GetCollection<WindowsFormsApp1.Models.Doctor>("doctors");
            var builder = Builders<WindowsFormsApp1.Models.Doctor>.Update;
            var updates = new List<UpdateDefinition<WindowsFormsApp1.Models.Doctor>>();

           
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
                updates.Add(builder.Set(d => d.FirstName, FirstNameTextBox.Text.Trim()));

           
            if (!string.IsNullOrWhiteSpace(LastNameTextBox.Text))
                updates.Add(builder.Set(d => d.LastName, LastNameTextBox.Text.Trim()));

            
            if (!string.IsNullOrWhiteSpace(PhoneTextBox.Text))
                updates.Add(builder.Set(d => d.PhoneNumber, PhoneTextBox.Text.Trim()));

           
            if (!string.IsNullOrWhiteSpace(ConsultationFeeTextBox.Text))
            {
                if (double.TryParse(ConsultationFeeTextBox.Text, out double fee))
                    updates.Add(builder.Set(d => d.ConsultationFee, fee));
                else
                {
                    MessageBox.Show("Consultation fee must be a number.");
                    return;
                }
            }

            if (ClinicComboBox.SelectedItem != null)
                updates.Add(builder.Set(d => d.ClinicId, ClinicComboBox.SelectedValue.ToString()));

            if (AvailableDaysCheckList.CheckedItems.Count > 0)
            {
                var days = AvailableDaysCheckList.CheckedItems.Cast<string>().ToList();
                updates.Add(builder.Set(d => d.Schedule.AvailableDays, days));
            }

          
            bool startChanged = StartDatePicker.Tag == null || StartDatePicker.Value.ToString("HH:mm") != StartDatePicker.Tag.ToString();
            bool endChanged = EndDatePicker.Tag == null || EndDatePicker.Value.ToString("HH:mm") != EndDatePicker.Tag.ToString();

            if (startChanged)
            {
                updates.Add(builder.Set("working_hours.start_time", StartDatePicker.Value.ToString("HH:mm")));
            }

            if (endChanged)
            {
                updates.Add(builder.Set("working_hours.end_time", EndDatePicker.Value.ToString("HH:mm")));
            }

            
            if (updates.Count == 0)
            {
                MessageBox.Show("No fields were updated. Please modify at least one value.");
                return;
            }

            
            var finalUpdate = builder.Combine(updates);
            doctorCol.UpdateOne(d => d.Id == _doctorId, finalUpdate);

            MessageBox.Show("Doctor updated successfully!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        private void StartTimeLabel_Click(object sender, EventArgs e) { }
        private void FirstNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void ClinicComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void LastNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void ConsultationFeeTextBox_TextChanged(object sender, EventArgs e) { }
        private void PhoneTextBox_TextChanged(object sender, EventArgs e) { }
        private void AvailableDaysCheckList_SelectedIndexChanged(object sender, EventArgs e) { }
        private void StartDatePicker_ValueChanged(object sender, EventArgs e) { }
        private void EndDatePicker_ValueChanged(object sender, EventArgs e) { }
    }
}
