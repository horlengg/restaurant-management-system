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

namespace FoodApp.app.check_in
{
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
            this.Text = "CheckIn Form";
        }
        public CheckInForm(bool isUpdate)
        {
            InitializeComponent();
            if (isUpdate)
            {
                this.Text = "Update CheckIn Transaction";
            }
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            loadCheckInProgressData(5);
            LoadTableList();
        }
        private void LoadTableList()
        {
            TableHelper.GetTableList().ForEach(table =>
            {
                TableComboBox.Items.Add(table);
            });
        }

        private void loadCheckInProgressData(int row)
        {
            DataTable itemTable = new DataTable();

            // Define columns
            itemTable.Columns.Add("No", typeof(int));
            itemTable.Columns.Add("Item Code", typeof(string));
            itemTable.Columns.Add("Item Name", typeof(string));
            itemTable.Columns.Add("Item Price", typeof(string));
            itemTable.Columns.Add("Item Quantity", typeof(int));

            for (int i = 0; i < row; i++)
            {
                itemTable.Rows.Add(i + 1, "FOOD01010", "Chicken Wing", "$2.1",2);

            }
            // Initialize DataGridView
            ItemDataGridView.DataSource = itemTable;
            ItemDataGridView.Dock = DockStyle.Fill;
            ItemDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemDataGridView.RowTemplate.Height = 30;

            // Add "Action" column
            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Action",
                HeaderText = "Action",
                Text = "Delete", // Button text
                UseColumnTextForButtonValue = true // Ensures button displays text
            };

            ItemDataGridView.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == ItemDataGridView.Columns["Action"].Index && e.RowIndex >= 0)
                {
                    // Handle button click event here
                    MessageBox.Show("Button clicked for row " + (e.RowIndex + 1));
                }
            };


            ItemDataGridView.Columns.Add(actionColumn);


        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.Show();
        }
    }
}
