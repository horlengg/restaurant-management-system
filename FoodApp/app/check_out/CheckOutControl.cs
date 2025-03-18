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
    public partial class CheckOutControl : UserControl
    {
        public CheckOutControl()
        {
            InitializeComponent();
        }

        private void CheckOutControl_Load(object sender, EventArgs e)
        {
            loadCheckInProgressData();
        }
        private void loadCheckInProgressData()
        {
            DataTable checkinProgressTable = new DataTable();

            // Define columns
            checkinProgressTable.Columns.Add("No", typeof(int));
            checkinProgressTable.Columns.Add("CheckIn No", typeof(string));
            checkinProgressTable.Columns.Add("Table No", typeof(string));
            checkinProgressTable.Columns.Add("CheckIn Date", typeof(string));
            checkinProgressTable.Columns.Add("Status", typeof(string));
            checkinProgressTable.Columns.Add("CheckIn By", typeof(string));

            for (int i = 0; i < 10; i++)
            {
                checkinProgressTable.Rows.Add(i + 1, "NO98872772", "101", "15-03-2025 11:30AM", "In Progress", "Mr Channy");

            }
            // Initialize DataGridView
            DataGridViewCheckInList.DataSource = checkinProgressTable;
            DataGridViewCheckInList.Dock = DockStyle.Fill;
            DataGridViewCheckInList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCheckInList.RowTemplate.Height = 30;

            // Add "Action" column
            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Action",
                HeaderText = "Action",
                Text = "Check out", // Button text
                UseColumnTextForButtonValue = true // Ensures button displays text
            };

            DataGridViewCheckInList.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == DataGridViewCheckInList.Columns["Action"].Index && e.RowIndex >= 0)
                {
                    CheckOutForm checkOutForm = new CheckOutForm();
                    checkOutForm.Show();
                }
            };


            DataGridViewCheckInList.Columns.Add(actionColumn);


        }
    }
}
