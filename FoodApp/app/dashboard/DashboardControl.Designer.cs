
namespace FoodApp.app.dashboard
{
    partial class DashboardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FunctionListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckInMenu = new System.Windows.Forms.Panel();
            this.CheckInItemLabel = new System.Windows.Forms.Label();
            this.CheckInPicBox = new System.Windows.Forms.PictureBox();
            this.CheckoutMenu = new System.Windows.Forms.Panel();
            this.CheckOutItemLabel = new System.Windows.Forms.Label();
            this.CheckOutItemPic = new System.Windows.Forms.PictureBox();
            this.FoodsMenu = new System.Windows.Forms.Panel();
            this.FoodItemLabel = new System.Windows.Forms.Label();
            this.FoodItemPic = new System.Windows.Forms.PictureBox();
            this.ReportMenu = new System.Windows.Forms.Panel();
            this.ReportItemLabel = new System.Windows.Forms.Label();
            this.ReportItemPic = new System.Windows.Forms.PictureBox();
            this.UserManagementMenu = new System.Windows.Forms.Panel();
            this.UserItemLabel = new System.Windows.Forms.Label();
            this.UserItemPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.FunctionListPanel.SuspendLayout();
            this.CheckInMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckInPicBox)).BeginInit();
            this.CheckoutMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutItemPic)).BeginInit();
            this.FoodsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodItemPic)).BeginInit();
            this.ReportMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportItemPic)).BeginInit();
            this.UserManagementMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserItemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 557);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 60);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dashboard ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FunctionListPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 497);
            this.panel3.TabIndex = 9;
            // 
            // FunctionListPanel
            // 
            this.FunctionListPanel.Controls.Add(this.CheckInMenu);
            this.FunctionListPanel.Controls.Add(this.CheckoutMenu);
            this.FunctionListPanel.Controls.Add(this.FoodsMenu);
            this.FunctionListPanel.Controls.Add(this.ReportMenu);
            this.FunctionListPanel.Controls.Add(this.UserManagementMenu);
            this.FunctionListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FunctionListPanel.Location = new System.Drawing.Point(0, 0);
            this.FunctionListPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FunctionListPanel.Name = "FunctionListPanel";
            this.FunctionListPanel.Size = new System.Drawing.Size(820, 497);
            this.FunctionListPanel.TabIndex = 8;
            // 
            // CheckInMenu
            // 
            this.CheckInMenu.BackColor = System.Drawing.Color.White;
            this.CheckInMenu.Controls.Add(this.CheckInItemLabel);
            this.CheckInMenu.Controls.Add(this.CheckInPicBox);
            this.CheckInMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckInMenu.Location = new System.Drawing.Point(3, 4);
            this.CheckInMenu.Margin = new System.Windows.Forms.Padding(3, 4, 20, 4);
            this.CheckInMenu.Name = "CheckInMenu";
            this.CheckInMenu.Size = new System.Drawing.Size(209, 177);
            this.CheckInMenu.TabIndex = 5;
            // 
            // CheckInItemLabel
            // 
            this.CheckInItemLabel.AutoSize = true;
            this.CheckInItemLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInItemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.CheckInItemLabel.Location = new System.Drawing.Point(62, 121);
            this.CheckInItemLabel.Name = "CheckInItemLabel";
            this.CheckInItemLabel.Size = new System.Drawing.Size(92, 24);
            this.CheckInItemLabel.TabIndex = 1;
            this.CheckInItemLabel.Text = "Check In";
            this.CheckInItemLabel.Click += new System.EventHandler(this.CheckInItemLabel_Click);
            // 
            // CheckInPicBox
            // 
            this.CheckInPicBox.Image = global::FoodApp.Properties.Resources.cash_desk_07;
            this.CheckInPicBox.Location = new System.Drawing.Point(56, 18);
            this.CheckInPicBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckInPicBox.Name = "CheckInPicBox";
            this.CheckInPicBox.Size = new System.Drawing.Size(100, 79);
            this.CheckInPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckInPicBox.TabIndex = 0;
            this.CheckInPicBox.TabStop = false;
            this.CheckInPicBox.Click += new System.EventHandler(this.CheckInPicBox_Click);
            // 
            // CheckoutMenu
            // 
            this.CheckoutMenu.BackColor = System.Drawing.Color.White;
            this.CheckoutMenu.Controls.Add(this.CheckOutItemLabel);
            this.CheckoutMenu.Controls.Add(this.CheckOutItemPic);
            this.CheckoutMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckoutMenu.Location = new System.Drawing.Point(235, 4);
            this.CheckoutMenu.Margin = new System.Windows.Forms.Padding(3, 4, 20, 4);
            this.CheckoutMenu.Name = "CheckoutMenu";
            this.CheckoutMenu.Size = new System.Drawing.Size(209, 177);
            this.CheckoutMenu.TabIndex = 7;
            // 
            // CheckOutItemLabel
            // 
            this.CheckOutItemLabel.AutoSize = true;
            this.CheckOutItemLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutItemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.CheckOutItemLabel.Location = new System.Drawing.Point(51, 121);
            this.CheckOutItemLabel.Name = "CheckOutItemLabel";
            this.CheckOutItemLabel.Size = new System.Drawing.Size(110, 24);
            this.CheckOutItemLabel.TabIndex = 1;
            this.CheckOutItemLabel.Text = "Check Out";
            this.CheckOutItemLabel.Click += new System.EventHandler(this.CheckOutItemLabel_Click);
            // 
            // CheckOutItemPic
            // 
            this.CheckOutItemPic.Image = global::FoodApp.Properties.Resources.payment;
            this.CheckOutItemPic.Location = new System.Drawing.Point(56, 18);
            this.CheckOutItemPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckOutItemPic.Name = "CheckOutItemPic";
            this.CheckOutItemPic.Size = new System.Drawing.Size(100, 79);
            this.CheckOutItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckOutItemPic.TabIndex = 0;
            this.CheckOutItemPic.TabStop = false;
            this.CheckOutItemPic.Click += new System.EventHandler(this.CheckOutItemPic_Click);
            // 
            // FoodsMenu
            // 
            this.FoodsMenu.BackColor = System.Drawing.Color.White;
            this.FoodsMenu.Controls.Add(this.FoodItemLabel);
            this.FoodsMenu.Controls.Add(this.FoodItemPic);
            this.FoodsMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodsMenu.Location = new System.Drawing.Point(467, 4);
            this.FoodsMenu.Margin = new System.Windows.Forms.Padding(3, 4, 20, 4);
            this.FoodsMenu.Name = "FoodsMenu";
            this.FoodsMenu.Size = new System.Drawing.Size(209, 177);
            this.FoodsMenu.TabIndex = 9;
            // 
            // FoodItemLabel
            // 
            this.FoodItemLabel.AutoSize = true;
            this.FoodItemLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodItemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.FoodItemLabel.Location = new System.Drawing.Point(69, 121);
            this.FoodItemLabel.Name = "FoodItemLabel";
            this.FoodItemLabel.Size = new System.Drawing.Size(69, 24);
            this.FoodItemLabel.TabIndex = 1;
            this.FoodItemLabel.Text = "Foods";
            this.FoodItemLabel.Click += new System.EventHandler(this.FoodItemLabel_Click);
            // 
            // FoodItemPic
            // 
            this.FoodItemPic.Image = global::FoodApp.Properties.Resources.app_logo_image;
            this.FoodItemPic.Location = new System.Drawing.Point(54, 18);
            this.FoodItemPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FoodItemPic.Name = "FoodItemPic";
            this.FoodItemPic.Size = new System.Drawing.Size(100, 79);
            this.FoodItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FoodItemPic.TabIndex = 0;
            this.FoodItemPic.TabStop = false;
            this.FoodItemPic.Click += new System.EventHandler(this.FoodItemPic_Click);
            // 
            // ReportMenu
            // 
            this.ReportMenu.BackColor = System.Drawing.Color.White;
            this.ReportMenu.Controls.Add(this.ReportItemLabel);
            this.ReportMenu.Controls.Add(this.ReportItemPic);
            this.ReportMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportMenu.Location = new System.Drawing.Point(3, 189);
            this.ReportMenu.Margin = new System.Windows.Forms.Padding(3, 4, 20, 4);
            this.ReportMenu.Name = "ReportMenu";
            this.ReportMenu.Size = new System.Drawing.Size(209, 177);
            this.ReportMenu.TabIndex = 10;
            // 
            // ReportItemLabel
            // 
            this.ReportItemLabel.AutoSize = true;
            this.ReportItemLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportItemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.ReportItemLabel.Location = new System.Drawing.Point(70, 121);
            this.ReportItemLabel.Name = "ReportItemLabel";
            this.ReportItemLabel.Size = new System.Drawing.Size(74, 24);
            this.ReportItemLabel.TabIndex = 1;
            this.ReportItemLabel.Text = "Report";
            this.ReportItemLabel.Click += new System.EventHandler(this.ReportItemLabel_Click);
            // 
            // ReportItemPic
            // 
            this.ReportItemPic.Image = global::FoodApp.Properties.Resources.report_image;
            this.ReportItemPic.Location = new System.Drawing.Point(56, 18);
            this.ReportItemPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportItemPic.Name = "ReportItemPic";
            this.ReportItemPic.Size = new System.Drawing.Size(100, 79);
            this.ReportItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReportItemPic.TabIndex = 0;
            this.ReportItemPic.TabStop = false;
            this.ReportItemPic.Click += new System.EventHandler(this.ReportItemPic_Click);
            // 
            // UserManagementMenu
            // 
            this.UserManagementMenu.BackColor = System.Drawing.Color.White;
            this.UserManagementMenu.Controls.Add(this.UserItemLabel);
            this.UserManagementMenu.Controls.Add(this.UserItemPic);
            this.UserManagementMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserManagementMenu.Location = new System.Drawing.Point(235, 189);
            this.UserManagementMenu.Margin = new System.Windows.Forms.Padding(3, 4, 20, 4);
            this.UserManagementMenu.Name = "UserManagementMenu";
            this.UserManagementMenu.Size = new System.Drawing.Size(209, 177);
            this.UserManagementMenu.TabIndex = 11;
            // 
            // UserItemLabel
            // 
            this.UserItemLabel.AutoSize = true;
            this.UserItemLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserItemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.UserItemLabel.Location = new System.Drawing.Point(15, 121);
            this.UserItemLabel.Name = "UserItemLabel";
            this.UserItemLabel.Size = new System.Drawing.Size(181, 24);
            this.UserItemLabel.TabIndex = 1;
            this.UserItemLabel.Text = "User Management";
            this.UserItemLabel.Click += new System.EventHandler(this.UserItemLabel_Click);
            // 
            // UserItemPic
            // 
            this.UserItemPic.Image = global::FoodApp.Properties.Resources.users;
            this.UserItemPic.Location = new System.Drawing.Point(56, 18);
            this.UserItemPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserItemPic.Name = "UserItemPic";
            this.UserItemPic.Size = new System.Drawing.Size(100, 79);
            this.UserItemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserItemPic.TabIndex = 0;
            this.UserItemPic.TabStop = false;
            this.UserItemPic.Click += new System.EventHandler(this.UserItemPic_Click);
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(820, 557);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.FunctionListPanel.ResumeLayout(false);
            this.CheckInMenu.ResumeLayout(false);
            this.CheckInMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckInPicBox)).EndInit();
            this.CheckoutMenu.ResumeLayout(false);
            this.CheckoutMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckOutItemPic)).EndInit();
            this.FoodsMenu.ResumeLayout(false);
            this.FoodsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodItemPic)).EndInit();
            this.ReportMenu.ResumeLayout(false);
            this.ReportMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportItemPic)).EndInit();
            this.UserManagementMenu.ResumeLayout(false);
            this.UserManagementMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserItemPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel FunctionListPanel;
        private System.Windows.Forms.Panel CheckInMenu;
        private System.Windows.Forms.Label CheckInItemLabel;
        private System.Windows.Forms.PictureBox CheckInPicBox;
        private System.Windows.Forms.Panel CheckoutMenu;
        private System.Windows.Forms.Label CheckOutItemLabel;
        private System.Windows.Forms.PictureBox CheckOutItemPic;
        private System.Windows.Forms.Panel FoodsMenu;
        private System.Windows.Forms.Label FoodItemLabel;
        private System.Windows.Forms.PictureBox FoodItemPic;
        private System.Windows.Forms.Panel ReportMenu;
        private System.Windows.Forms.Label ReportItemLabel;
        private System.Windows.Forms.PictureBox ReportItemPic;
        private System.Windows.Forms.Panel UserManagementMenu;
        private System.Windows.Forms.Label UserItemLabel;
        private System.Windows.Forms.PictureBox UserItemPic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}
