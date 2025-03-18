using FoodApp.app.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp.app.user_management
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            RoleHelper.roles.ForEach(role => CBRole.Items.Add(role));
            CBRole.Text = Role.Administrator.ToString();
        }
    }
}
