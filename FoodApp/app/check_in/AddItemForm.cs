using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp.app.check_in
{
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            this.Font = new Font("Arial", 10);
            ListFlowLayoutPanel.AutoScroll = true;
            ListFlowLayoutPanel.WrapContents = true ;
            ListFlowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;

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
                //pictureBox.Image = Properties.Resources.app_logo_image;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point((FoodPanelItem.Width - pictureBox.Width) / 2, 10);
                pictureBox.Click += FoodPanelItem_Click;

                Label label = new Label();
                label.Text = string.Format("{0} - Fried Rice", i + 1);
                FoodPanelItem.Controls.Add(label);
                FoodPanelItem.Controls.Add(pictureBox);
                label.Location = new Point((FoodPanelItem.Width - label.PreferredWidth) / 2, pictureBox.Bottom + 5);
                label.Click += FoodPanelItem_Click;


                ListFlowLayoutPanel.Controls.Add(FoodPanelItem);


            }

            
        }
        private void FoodPanelItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
