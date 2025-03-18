
namespace FoodApp.app.check_in
{
    partial class CheckInControl
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DataGridViewCheckInList = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnCheckIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCheckInList)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 604);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 544);
            this.panel3.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DataGridViewCheckInList);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(819, 477);
            this.panel6.TabIndex = 3;
            // 
            // DataGridViewCheckInList
            // 
            this.DataGridViewCheckInList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.DataGridViewCheckInList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewCheckInList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCheckInList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewCheckInList.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewCheckInList.Name = "DataGridViewCheckInList";
            this.DataGridViewCheckInList.RowHeadersWidth = 51;
            this.DataGridViewCheckInList.RowTemplate.Height = 24;
            this.DataGridViewCheckInList.Size = new System.Drawing.Size(819, 477);
            this.DataGridViewCheckInList.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(819, 67);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "In Progress";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 60);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnCheckIn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(653, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 60);
            this.panel5.TabIndex = 4;
            // 
            // BtnCheckIn
            // 
            this.BtnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.BtnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCheckIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckIn.ForeColor = System.Drawing.Color.White;
            this.BtnCheckIn.Location = new System.Drawing.Point(25, 10);
            this.BtnCheckIn.Name = "BtnCheckIn";
            this.BtnCheckIn.Size = new System.Drawing.Size(136, 40);
            this.BtnCheckIn.TabIndex = 1;
            this.BtnCheckIn.Text = "Check In";
            this.BtnCheckIn.UseVisualStyleBackColor = false;
            this.BtnCheckIn.Click += new System.EventHandler(this.BtnCheckIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(27, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer Check In";
            // 
            // CheckInControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "CheckInControl";
            this.Size = new System.Drawing.Size(819, 604);
            this.Load += new System.EventHandler(this.CheckInControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCheckInList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnCheckIn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView DataGridViewCheckInList;
    }
}
