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

namespace FoodApp.app.check_out
{
    public partial class CheckOutForm : Form
    {
        public CheckOutForm()
        {
            InitializeComponent();
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            loadPaymentItemTable();
            PaymentHelper.GetAllPaymementMethods().ForEach(m =>
            {
                PayMethodComboBox.Items.Add(m);
            });
            PayMethodComboBox.SelectedIndex = 0;
        }
        private void loadPaymentItemTable()
        {
            DataTable itemPaymentTable = new DataTable();
            itemPaymentTable.Columns.Add("Name", typeof(string));
            itemPaymentTable.Columns.Add("Price", typeof(string));
            itemPaymentTable.Columns.Add("Quantity", typeof(int));
            itemPaymentTable.Columns.Add("Amount", typeof(string));

            for (int i = 0; i < 10; i++)
            {
                itemPaymentTable.Rows.Add("Checken Rice", "$2.2", 2, "$4.4");

            }
            // Initialize DataGridView
            ItemPaymemtDataGridView.DataSource = itemPaymentTable;
            ItemPaymemtDataGridView.Dock = DockStyle.Fill;
            ItemPaymemtDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemPaymemtDataGridView.RowTemplate.Height = 30;

            


        }
    }
}
