using ClinicalBookingSystem.Services;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms.Admin
{
    public partial class ViewPaymentsForm : Form
    {
        private readonly MongoDBService _db;

        public ViewPaymentsForm()
        {
            InitializeComponent();
            _db = new MongoDBService();
        }

       
        private void ViewPaymentsForm_Load(object sender, EventArgs e)
        {
            LoadStatuses();
            LoadPayments();
        }

     
        private void LoadPayments(string statusFilter = "All")
        {
            var paymentsCollection = _db.GetCollection<Payment>("payments");

            var payments = paymentsCollection.AsQueryable().ToList();

            if (statusFilter != "All")
            {
                payments = payments.Where(p => p.Status == statusFilter).ToList();
            }

            // Shape for DataGridView
            var result = payments.Select(p => new
            {
                PaymentId = p.Id,
                p.AppointmentId,
                p.Amount,
                p.Method,
                p.Status,
                PaymentDate = p.PaymentDate
            }).ToList();

            PaymentsGrid.DataSource = result;
        }

       
        private void LoadStatuses()
        {
            var payments = _db.GetCollection<Payment>("payments")
                              .AsQueryable()
                              .Select(p => p.Status)
                              .Distinct()
                              .ToList();

            FilterComboBox.Items.Clear();
            FilterComboBox.Items.Add("All");
            FilterComboBox.Items.AddRange(payments.ToArray());

            FilterComboBox.SelectedIndex = 0;
        }

       
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = FilterComboBox.SelectedItem?.ToString() ?? "All";
            LoadPayments(selectedStatus);
        }

        
        private void PaymentsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void FilterLabel_Click(object sender, EventArgs e) { }
        private void AllPaymentsLabel_Click(object sender, EventArgs e) { }
    }
}
