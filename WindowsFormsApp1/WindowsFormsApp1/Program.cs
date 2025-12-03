using System;
using System.Windows.Forms;

namespace ClinicalBookingSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new WindowsFormsApp1.Forms.Patient.PatientHomePageForm());
            
            Application.Run(new WindowsFormsApp1.Forms.Auth.LoginForm());


        }
    }
}
