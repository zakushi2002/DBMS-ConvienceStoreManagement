using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvienceStore
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            loadapp();
        }
        public static void loadapp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            if (loginForm.DialogResult == DialogResult.OK && loginForm.radioManagerButton.Checked)
            {
                Application.Run(new ManagerMainForm());
            }
            else if(loginForm.DialogResult == DialogResult.OK && loginForm.radioEmployeeButton.Checked)
            {
                Application.Run(new EmployeeMainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
