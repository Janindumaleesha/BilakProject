using BilakProject.Views.Employee;
using BilakProject.Views.Header;
using BilakProject.Views.Home;
using BilakProject.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilakProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new RegisterForm());
            Application.Run(new HomeForm());
            //Application.Run(new AccessRecoveryPasswordForm());
            //Application.Run(new RecoveryPasswordForm());
            //Application.Run(new HeaderForm());
            //Application.Run(new ViewEmployeeForm());
        }
    }
}
