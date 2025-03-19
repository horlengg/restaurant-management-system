using FoodApp.app;
using FoodApp.app.authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool isAuthenticated = false;
            if (isAuthenticated)
            {
                Application.Run(new AppLayout());
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}
