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
    public partial class FoodForm : Form
    {
        public FoodForm(string title)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = title;

        }
        public FoodForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            CategoryHelper.GetCategories().ForEach(category =>
            {
                ComboBoxCategory.Items.Add(category);
            });
            
        }
    }
}
