
namespace FoodApp.app
{
    partial class AppLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SidebarPanel = new System.Windows.Forms.Panel();
            this.MenuListPanel = new System.Windows.Forms.Panel();
            this.BtnQueryReportMenu = new System.Windows.Forms.Button();
            this.BtnUserManagementMenu = new System.Windows.Forms.Button();
            this.BtnFoodManagement = new System.Windows.Forms.Button();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.BtnCheckInMenu = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AppContentPanel = new System.Windows.Forms.Panel();
            this.SidebarPanel.SuspendLayout();
            this.MenuListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarPanel
            // 
            this.SidebarPanel.BackColor = System.Drawing.Color.White;
            this.SidebarPanel.Controls.Add(this.MenuListPanel);
            this.SidebarPanel.Controls.Add(this.pictureBox1);
            this.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.SidebarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidebarPanel.Name = "SidebarPanel";
            this.SidebarPanel.Size = new System.Drawing.Size(300, 716);
            this.SidebarPanel.TabIndex = 0;
            // 
            // MenuListPanel
            // 
            this.MenuListPanel.Controls.Add(this.BtnQueryReportMenu);
            this.MenuListPanel.Controls.Add(this.BtnUserManagementMenu);
            this.MenuListPanel.Controls.Add(this.BtnFoodManagement);
            this.MenuListPanel.Controls.Add(this.BtnCheckOut);
            this.MenuListPanel.Controls.Add(this.BtnCheckInMenu);
            this.MenuListPanel.Controls.Add(this.BtnDashboard);
            this.MenuListPanel.Location = new System.Drawing.Point(3, 218);
            this.MenuListPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuListPanel.Name = "MenuListPanel";
            this.MenuListPanel.Size = new System.Drawing.Size(300, 407);
            this.MenuListPanel.TabIndex = 2;
            // 
            // BtnQueryReportMenu
            // 
            this.BtnQueryReportMenu.BackColor = System.Drawing.Color.White;
            this.BtnQueryReportMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnQueryReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQueryReportMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BtnQueryReportMenu.Location = new System.Drawing.Point(3, 263);
            this.BtnQueryReportMenu.Name = "BtnQueryReportMenu";
            this.BtnQueryReportMenu.Size = new System.Drawing.Size(290, 45);
            this.BtnQueryReportMenu.TabIndex = 11;
            this.BtnQueryReportMenu.Text = "Query Report";
            this.BtnQueryReportMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnQueryReportMenu.UseVisualStyleBackColor = false;
            this.BtnQueryReportMenu.Click += new System.EventHandler(this.BtnQueryReportMenu_Click);
            // 
            // BtnUserManagementMenu
            // 
            this.BtnUserManagementMenu.BackColor = System.Drawing.Color.White;
            this.BtnUserManagementMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnUserManagementMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserManagementMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BtnUserManagementMenu.Location = new System.Drawing.Point(3, 212);
            this.BtnUserManagementMenu.Name = "BtnUserManagementMenu";
            this.BtnUserManagementMenu.Size = new System.Drawing.Size(290, 45);
            this.BtnUserManagementMenu.TabIndex = 10;
            this.BtnUserManagementMenu.Text = "User Management";
            this.BtnUserManagementMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUserManagementMenu.UseVisualStyleBackColor = false;
            this.BtnUserManagementMenu.Click += new System.EventHandler(this.BtnUserManagementMenu_Click);
            // 
            // BtnFoodManagement
            // 
            this.BtnFoodManagement.BackColor = System.Drawing.Color.White;
            this.BtnFoodManagement.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnFoodManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFoodManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BtnFoodManagement.Location = new System.Drawing.Point(5, 161);
            this.BtnFoodManagement.Name = "BtnFoodManagement";
            this.BtnFoodManagement.Size = new System.Drawing.Size(290, 45);
            this.BtnFoodManagement.TabIndex = 9;
            this.BtnFoodManagement.Text = "Food Management";
            this.BtnFoodManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFoodManagement.UseVisualStyleBackColor = false;
            this.BtnFoodManagement.Click += new System.EventHandler(this.BtnFoodManagement_Click);
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.BackColor = System.Drawing.Color.White;
            this.BtnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BtnCheckOut.Location = new System.Drawing.Point(5, 109);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(290, 45);
            this.BtnCheckOut.TabIndex = 8;
            this.BtnCheckOut.Text = "Check Out";
            this.BtnCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckOut.UseVisualStyleBackColor = false;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // BtnCheckInMenu
            // 
            this.BtnCheckInMenu.BackColor = System.Drawing.Color.White;
            this.BtnCheckInMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCheckInMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckInMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BtnCheckInMenu.Location = new System.Drawing.Point(2, 63);
            this.BtnCheckInMenu.Name = "BtnCheckInMenu";
            this.BtnCheckInMenu.Size = new System.Drawing.Size(290, 45);
            this.BtnCheckInMenu.TabIndex = 7;
            this.BtnCheckInMenu.Text = "Check In";
            this.BtnCheckInMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCheckInMenu.UseVisualStyleBackColor = false;
            this.BtnCheckInMenu.Click += new System.EventHandler(this.BtnCheckInMenu_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.BtnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.ForeColor = System.Drawing.Color.White;
            this.BtnDashboard.Location = new System.Drawing.Point(3, 17);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(290, 45);
            this.BtnDashboard.TabIndex = 6;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodApp.Properties.Resources.app_logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AppContentPanel
            // 
            this.AppContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppContentPanel.Location = new System.Drawing.Point(300, 0);
            this.AppContentPanel.Name = "AppContentPanel";
            this.AppContentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.AppContentPanel.Size = new System.Drawing.Size(987, 716);
            this.AppContentPanel.TabIndex = 1;
            // 
            // AppLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1287, 716);
            this.Controls.Add(this.AppContentPanel);
            this.Controls.Add(this.SidebarPanel);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AppLayout";
            this.Text = "AppLayout";
            this.Load += new System.EventHandler(this.AppLayout_Load);
            this.SidebarPanel.ResumeLayout(false);
            this.MenuListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidebarPanel;
        private System.Windows.Forms.Panel MenuListPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCheckInMenu;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.Button BtnQueryReportMenu;
        private System.Windows.Forms.Button BtnUserManagementMenu;
        private System.Windows.Forms.Button BtnFoodManagement;
        private System.Windows.Forms.Panel AppContentPanel;
    }
}