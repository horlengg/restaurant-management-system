using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp.app.dashboard
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
        }

        private void CheckInMenu_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenCheckIn();
        }

        private void CheckoutMenu_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenCheckOut();

        }

        private void FoodsMenu_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenFoodManagement();

        }

        private void ReportMenu_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenReport();
        }

        private void FunctionListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserManagementMenu_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenUserMangement();

        }

        private void CheckInPicBox_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenCheckIn();
        }

        private void CheckInItemLabel_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenCheckIn();
        }

        private void CheckOutItemPic_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenCheckOut();
        }

        private void CheckOutItemLabel_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenCheckOut();
        }

        private void FoodItemPic_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenFoodManagement();
        }

        private void FoodItemLabel_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenFoodManagement();
        }

        private void ReportItemPic_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenReport();
        }

        private void ReportItemLabel_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenReport();

        }

        private void UserItemPic_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenUserMangement();

        }

        private void UserItemLabel_Click(object sender, EventArgs e)
        {
            RouteManager.OpenScreenUserMangement();
        }
    }
}
