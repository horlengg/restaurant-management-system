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
    public partial class UserManagementControl : UserControl
    {
        
        public UserManagementControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserManagementControl_Load(object sender, EventArgs e)
        {

            DataTable studentTable = new DataTable();

            // Define columns
            studentTable.Columns.Add("No", typeof(int));
            studentTable.Columns.Add("Name", typeof(string));
            studentTable.Columns.Add("Code", typeof(string));
            studentTable.Columns.Add("Email", typeof(string));
            studentTable.Columns.Add("Phone", typeof(string));
            studentTable.Columns.Add("Created By", typeof(string));

            // Sample Data
            studentTable.Rows.Add(1, "Ly Horleng", "A0101", "admin1234@gmail.com", "038773728", "Mr Administrator");
            studentTable.Rows.Add(2, "Sok Channy", "A0101", "admin1234@gmail.com", "038773728", "Mr Administrator");
            studentTable.Rows.Add(3, "Rout Chandara", "A0101", "admin1234@gmail.com", "038773728", "Mr Administrator");
            studentTable.Rows.Add(4, "Chomroeun Pannhavath", "A0101", "admin1234@gmail.com", "038773728", "Mr Administrator");

            // Initialize DataGridView
            UserDataGridView.DataSource = studentTable;
            UserDataGridView.Dock = DockStyle.Fill;
            UserDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UserDataGridView.RowTemplate.Height = 40;

            // Add "Action" column
            DataGridViewTextBoxColumn actionColumn = new DataGridViewTextBoxColumn
            {
                Name = "Action",
                HeaderText = "Action",
                ReadOnly = true
            };
            UserDataGridView.Columns.Add(actionColumn);

            // Attach event to paint custom buttons
            UserDataGridView.CellPainting += UserDataGridView_CellPainting;
            UserDataGridView.CellClick += UserDataGridView_CellClick;


        }
        private void UserDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == UserDataGridView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                int buttonWidth = 50;
                int buttonHeight = 25;
                int padding = 5;
                int startX = e.CellBounds.Left + padding;
                int startY = e.CellBounds.Top + (e.CellBounds.Height - buttonHeight) / 2;

                // Create View button
                Rectangle viewButtonRect = new Rectangle(startX, startY, buttonWidth, buttonHeight);
                e.Graphics.FillRectangle(Brushes.Gray, viewButtonRect);
                e.Graphics.DrawRectangle(Pens.Black, viewButtonRect);
                TextRenderer.DrawText(e.Graphics, "View", e.CellStyle.Font, viewButtonRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
               

                // Create Edit button
                Rectangle editButtonRect = new Rectangle(startX + buttonWidth + padding, startY, buttonWidth, buttonHeight);
                e.Graphics.FillRectangle(Brushes.SeaGreen, editButtonRect);
                e.Graphics.DrawRectangle(Pens.Black, editButtonRect);
                TextRenderer.DrawText(e.Graphics, "Edit", e.CellStyle.Font, editButtonRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                // Create Delete button
                Rectangle deleteButtonRect = new Rectangle(startX + (buttonWidth + padding) * 2, startY, buttonWidth, buttonHeight);
                e.Graphics.FillRectangle(Brushes.Red, deleteButtonRect);
                e.Graphics.DrawRectangle(Pens.Black, deleteButtonRect);
                TextRenderer.DrawText(e.Graphics, "Delete", e.CellStyle.Font, deleteButtonRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                e.Handled = true; // Prevent default cell rendering
            }
        }

        private void UserDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == UserDataGridView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                int buttonWidth = 50;
                int padding = 5;
                int startX = UserDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Left + padding;

                // Get the click position relative to the cell
                Point mousePos = UserDataGridView.PointToClient(Cursor.Position);
                int relativeX = mousePos.X - startX;

                if (relativeX >= 0 && relativeX < buttonWidth)
                {
                    // View button clicked
                    string userName = UserDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    MessageBox.Show($"Viewing details of {userName}", "View", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (relativeX >= buttonWidth + padding && relativeX < (buttonWidth * 2) + padding)
                {
                    // Edit button clicked
                    string userName = UserDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    MessageBox.Show($"Editing details of {userName}", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (relativeX >= (buttonWidth * 2) + (padding * 2) && relativeX < (buttonWidth * 3) + (padding * 2))
                {
                    // Delete button clicked
                    string userName = UserDataGridView.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    DialogResult confirmDelete = MessageBox.Show($"Are you sure you want to delete {userName}?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmDelete == DialogResult.Yes)
                    {
                        UserDataGridView.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }


            private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }
    }
}
