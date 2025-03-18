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

namespace FoodApp.app.foods
{
    public partial class FoodManagementControl : UserControl
    {
        public FoodManagementControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FoodManagementControl_Load(object sender, EventArgs e)
        {
            FoodListPanel.Padding = new Padding(0,40,0,0);
            this.Font = new Font("Arial", 10);
            FoodListPanel.AutoScroll = true;
            FoodListPanel.WrapContents = true;
            FoodListPanel.FlowDirection = FlowDirection.LeftToRight;
            for (int i = 0; i < 20; i++)
            {
                Panel FoodPanelItem = new Panel();
                FoodPanelItem.Padding = new Padding(20);
                FoodPanelItem.BackColor = Color.White;
                FoodPanelItem.Size = new Size(150, 100);
                FoodPanelItem.Cursor = Cursors.Hand;
                FoodPanelItem.Click += FoodPanelItem_Click;

                PictureBox pictureBox = new PictureBox();
                pictureBox.LoadAsync("https://res.cloudinary.com/decme1qrv/image/upload/v1742001612/restaurant-management/image-removebg-preview_2_akfifs.png");
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point((FoodPanelItem.Width - pictureBox.Width) / 2, 10);
                pictureBox.Click += FoodPanelItem_Click;

                Label label = new Label();
                label.Text = string.Format("{0} - Fried Rice", i+1);
                FoodPanelItem.Controls.Add(label);
                FoodPanelItem.Controls.Add(pictureBox);
                label.Location = new Point((FoodPanelItem.Width - label.PreferredWidth) / 2, pictureBox.Bottom + 5);
                label.Click += FoodPanelItem_Click;


                FoodListPanel.Controls.Add(FoodPanelItem);
                

            }
        }

        private void FoodPanelItem_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm("Food");
            foodForm.Show();
        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm("Add Food");
            foodForm.Show();
        }
    }
}
