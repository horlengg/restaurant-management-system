using FoodApp.app.dashboard;
using FoodApp.app.foods;
using FoodApp.app.user_management;
using FoodApp.app.check_in;
using FoodApp.app.check_out;
using FoodApp.app.report;
using FoodApp.app.utils;
using System;
using System.Windows.Forms;

namespace FoodApp.app
{
    public partial class AppLayout : Form
    {
        private UserControl currentControllScreen;
        private Button ButtonMenuActive;
        public AppLayout()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            currentControllScreen = new DashboardControl();

        }
        public AppLayout(UserControl currentScreen)
        {
            InitializeComponent();
           currentControllScreen = currentScreen;

        }
        public void SetContent(UserControl newScreen)
        {
            if (newScreen != null) { 
                AppContentPanel.Controls.Clear();
                AppContentPanel.Controls.Add(newScreen);
                newScreen.Dock = DockStyle.Fill;
            }
        }


        private void AppLayout_Load(object sender, EventArgs e)
        {
            
            SetContent(currentControllScreen);
            setButtonStyle();
            RouteManager.SetAppLayout(this);
            OpenReport();
        }
        private void setButtonStyle()
        {
            foreach (Control button in MenuListPanel.Controls)
            {
                if (button is Button)
                {
                    button.Padding = new Padding(20, 0, 0, 0);
                    button.Cursor = Cursors.Hand;

                }
            }
        }
        private void highlightMenuButton(Button currentMenuButtonActive)
        {
            currentMenuButtonActive.BackColor = AppColors.ButtonMenuItemBackgroundColorActive;
            currentMenuButtonActive.ForeColor = AppColors.ButtonMenuItemColorActive;

            foreach (Control control in MenuListPanel.Controls)
            {
                if (control is Button && control != currentMenuButtonActive)
                {
                    Button button = (Button)control;
                    button.BackColor = AppColors.ButtonMenuItemBackgroundColor;
                    button.ForeColor = AppColors.ButtonMenuItemColor;
                }
            }

        }
        private void BtnCheckInMenu_Click(object sender, EventArgs e)
        {
            OpenCheckIn();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            OpenDashboard();

        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            OpenCheckOut();

        }

        private void BtnFoodManagement_Click(object sender, EventArgs e)
        {
            OpenFoodManagemet();

        }

        private void BtnUserManagementMenu_Click(object sender, EventArgs e)
        {
            OpenUserManagement();

        }

        private void BtnQueryReportMenu_Click(object sender, EventArgs e)
        {
            OpenReport();
        }
        private void OpenScreen(UserControl screen)
        {
            SetContent(screen);
            if(screen == new DashboardControl())
            {
                highlightMenuButton(BtnDashboard);
            }
            else if(screen == new FoodManagementControl())
            {
                highlightMenuButton(BtnFoodManagement);
            }
            else if (screen == new CheckInControl())
            {
                highlightMenuButton(BtnCheckInMenu);
            }
            else if (screen == new CheckOutControl())
            {
                highlightMenuButton(BtnCheckOut);
            }
            else if (screen == new UserManagementControl())
            {
                highlightMenuButton(BtnUserManagementMenu);
            }
            else if (screen == new ReportControl())
            {
                highlightMenuButton(BtnQueryReportMenu);
            }
        }
        public void OpenDashboard()
        {
            if (ButtonMenuActive == BtnDashboard) return;
            ButtonMenuActive = BtnDashboard;
            highlightMenuButton(BtnDashboard);
            OpenScreen(new DashboardControl());
        }
        public void OpenFoodManagemet()
        {
            if (ButtonMenuActive == BtnFoodManagement) return;
            ButtonMenuActive = BtnFoodManagement;
            highlightMenuButton(BtnFoodManagement);
            OpenScreen(new FoodManagementControl());
        }
        public void OpenUserManagement()
        {
            if (ButtonMenuActive == BtnUserManagementMenu) return;
            ButtonMenuActive = BtnUserManagementMenu;
            highlightMenuButton(BtnUserManagementMenu);
            OpenScreen(new UserManagementControl());
        }
        public void OpenCheckIn()
        {
            if (ButtonMenuActive == BtnCheckInMenu) return;
            ButtonMenuActive = BtnCheckInMenu;
            highlightMenuButton(BtnCheckInMenu);
            OpenScreen(new CheckInControl());
        }
        public void OpenCheckOut()
        {
            if (ButtonMenuActive == BtnCheckOut) return;
            ButtonMenuActive = BtnCheckOut;
            highlightMenuButton(BtnCheckOut);
            OpenScreen(new CheckOutControl());
        }
        public void OpenReport()
        {
            if (ButtonMenuActive == BtnQueryReportMenu) return;
            ButtonMenuActive = BtnQueryReportMenu;
            highlightMenuButton(BtnQueryReportMenu);
            OpenScreen(new ReportControl());
        }

        private void AppLayout_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
