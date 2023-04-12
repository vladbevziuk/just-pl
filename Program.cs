using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace just_pl
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
            SplashForm splashForm = new SplashForm();
            splashForm.Show();
            Application.DoEvents();
            System.Threading.Thread.Sleep(5000);
            LoginForm loginForm = new LoginForm(); 
            splashForm.Close();
            loginForm.Show();
            Application.Run();
        }
    }
}
