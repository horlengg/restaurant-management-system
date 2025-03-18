
namespace FoodApp.app.user_management
{
    partial class UserManagementControl
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
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCreateUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UserDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 640);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.UserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Location = new System.Drawing.Point(17, 157);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.RowHeadersWidth = 51;
            this.UserDataGridView.RowTemplate.Height = 24;
            this.UserDataGridView.Size = new System.Drawing.Size(927, 327);
            this.UserDataGridView.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 60);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnCreateUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(795, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 60);
            this.panel3.TabIndex = 2;
            // 
            // BtnCreateUser
            // 
            this.BtnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.BtnCreateUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateUser.ForeColor = System.Drawing.Color.White;
            this.BtnCreateUser.Location = new System.Drawing.Point(25, 10);
            this.BtnCreateUser.Name = "BtnCreateUser";
            this.BtnCreateUser.Size = new System.Drawing.Size(136, 40);
            this.BtnCreateUser.TabIndex = 1;
            this.BtnCreateUser.Text = "Create User";
            this.BtnCreateUser.UseVisualStyleBackColor = false;
            this.BtnCreateUser.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(27, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Management";
            // 
            // UserManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "UserManagementControl";
            this.Size = new System.Drawing.Size(961, 640);
            this.Load += new System.EventHandler(this.UserManagementControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.Button BtnCreateUser;
        private System.Windows.Forms.Panel panel3;
    }
}
