using FoodApp.app.dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp.app
{
    class RouteManager
    {
        static AppLayout app;
        public static void NavigateToHome()
        {
            app = new AppLayout();
            app.Show();
        }
        public static void SetAppLayout(AppLayout appLayout)
        {
            app = appLayout;
        }

        public static void OpenApplicationLayout(Form currentForm)
        {
            currentForm.Hide();
            AppLayout appLayout = new AppLayout(new DashboardControl());
            appLayout.Show();
        }
        public static void OpenCheckIn(Form currentForm)
        {
            // currentForm.Close();
            // AppLayout appLayout = new AppLayout(new CheckInControll());
            // appLayout.Show();
        }
        public static void OpenScreenFoodManagement()
        {
            app.OpenFoodManagemet();
        }
        public static void OpenScreenUserMangement()
        {
            app.OpenUserManagement();
        }
        public static void OpenScreenCheckIn()
        {
            app.OpenCheckIn();
        }
        public static void OpenScreenCheckOut()
        {
            app.OpenCheckOut();
        }
        public static void OpenScreenReport()
        {
            app.OpenReport();
        }
    }
}
