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
    public partial class CheckInControl : UserControl
    {
        public CheckInControl()
        {
            InitializeComponent();
        }
        private void CheckInControl_Load(object sender, EventArgs e)
        {
            this.loadCheckInProgressData();

        }

        private void BtnCheckIn_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm();
            checkInForm.Show();
        }
        private void loadCheckInProgressData()
        {
            DataTable checkinProgressDataTable = new DataTable();

            // Define columns
            checkinProgressDataTable.Columns.Add("No", typeof(int));
            checkinProgressDataTable.Columns.Add("CheckIn No", typeof(string));
            checkinProgressDataTable.Columns.Add("Table No", typeof(string));
            checkinProgressDataTable.Columns.Add("CheckIn Date", typeof(string));
            checkinProgressDataTable.Columns.Add("Status", typeof(string));
            checkinProgressDataTable.Columns.Add("CheckIn By", typeof(string));

            for(int i = 0; i < 10; i++)
            {
                checkinProgressDataTable.Rows.Add(i+1, "NO98872772", "101", "15-03-2025 11:30AM", "In Progress", "Mr Channy");

            }
            // Initialize DataGridView
            DataGridViewCheckInList.DataSource = checkinProgressDataTable;
            DataGridViewCheckInList.Dock = DockStyle.Fill;
            DataGridViewCheckInList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCheckInList.RowTemplate.Height = 30;

            // Add "Action" column
            DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn
            {
                Name = "Action",
                HeaderText = "Action",
                Text = "Edit", // Button text
                UseColumnTextForButtonValue = true // Ensures button displays text
            };

            DataGridViewCheckInList.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == DataGridViewCheckInList.Columns["Action"].Index && e.RowIndex >= 0)
                {
                    CheckInForm checkInForm = new CheckInForm(true);
                    checkInForm.Show();
                }
            };


            DataGridViewCheckInList.Columns.Add(actionColumn);


        }
    }
}
