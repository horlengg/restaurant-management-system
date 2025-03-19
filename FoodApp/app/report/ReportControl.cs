using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodApp.app.report
{
    public partial class ReportControl : UserControl
    {
        private List<string> listFilterReportPeriod = new List<string> {
            "Today",
            "This Week",
            "Last Week",
            "This Month",
            "Last Month"
        };
        public ReportControl()
        {
            InitializeComponent();
        }

        private void ReportControl_Load(object sender, EventArgs e)
        {
            loadReportTable();
            listFilterReportPeriod.ForEach(item =>
            {
                ComboBoxFilterPeriod.Items.Add(item);
            });
        }
        private void loadReportTable(int row = 10)
        {
            DataTable studentTable = new DataTable();

            // Define columns
            studentTable.Columns.Add("No", typeof(int));
            studentTable.Columns.Add("CheckIn No", typeof(string));
            studentTable.Columns.Add("CheckIn By", typeof(string));
            studentTable.Columns.Add("Checkout By", typeof(string));
            studentTable.Columns.Add("Total Amount", typeof(string));
            studentTable.Columns.Add("Date", typeof(string));


            for (int t = 0; t < row; t++)
            {
                studentTable.Rows.Add(t+1, String.Format("NO0928828{0}",t), "Sok Channy", "Rout Chandara", "$22.5", "12-02-2020");
            }

            // Initialize DataGridView
            ReportDataGridView.DataSource = studentTable;
            ReportDataGridView.Dock = DockStyle.Fill;
            ReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ReportDataGridView.RowTemplate.Height = 30;

            // Add "Action" column
            DataGridViewTextBoxColumn actionColumn = new DataGridViewTextBoxColumn
            {
                Name = "View",
                HeaderText = "View",
                ReadOnly = true
            };
            ReportDataGridView.Columns.Add(actionColumn);

            // Attach event to paint custom buttons
           // ReportDataGridView.CellPainting += UserDataGridView_CellPainting;
            //ReportDataGridView.CellClick += UserDataGridView_CellClick;
        }

    }
}
