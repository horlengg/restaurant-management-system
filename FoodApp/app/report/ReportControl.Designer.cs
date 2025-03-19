
namespace FoodApp.app.report
{
    partial class ReportControl
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ReportDataGridView = new System.Windows.Forms.DataGridView();
            this.CheckinNoPanel = new System.Windows.Forms.Panel();
            this.TxtFilterCheckinNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDatePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DatePickerFilterFromDate = new System.Windows.Forms.DateTimePicker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ToDatePanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DatePickerFilterToDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.StaticDatePanel = new System.Windows.Forms.Panel();
            this.ComboBoxFilterPeriod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).BeginInit();
            this.CheckinNoPanel.SuspendLayout();
            this.FromDatePanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.ToDatePanel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.StaticDatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 616);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1099, 71);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(30, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Query Report";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1099, 545);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnQuery);
            this.panel4.Controls.Add(this.StaticDatePanel);
            this.panel4.Controls.Add(this.ToDatePanel);
            this.panel4.Controls.Add(this.FromDatePanel);
            this.panel4.Controls.Add(this.CheckinNoPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1099, 119);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ReportDataGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 119);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1099, 426);
            this.panel5.TabIndex = 1;
            // 
            // ReportDataGridView
            // 
            this.ReportDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ReportDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ReportDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReportDataGridView.Name = "ReportDataGridView";
            this.ReportDataGridView.RowHeadersWidth = 51;
            this.ReportDataGridView.RowTemplate.Height = 24;
            this.ReportDataGridView.Size = new System.Drawing.Size(1099, 426);
            this.ReportDataGridView.TabIndex = 10;
            // 
            // CheckinNoPanel
            // 
            this.CheckinNoPanel.Controls.Add(this.label1);
            this.CheckinNoPanel.Controls.Add(this.TxtFilterCheckinNo);
            this.CheckinNoPanel.Location = new System.Drawing.Point(0, 29);
            this.CheckinNoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckinNoPanel.Name = "CheckinNoPanel";
            this.CheckinNoPanel.Size = new System.Drawing.Size(163, 73);
            this.CheckinNoPanel.TabIndex = 8;
            // 
            // TxtFilterCheckinNo
            // 
            this.TxtFilterCheckinNo.BackColor = System.Drawing.Color.White;
            this.TxtFilterCheckinNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFilterCheckinNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFilterCheckinNo.Location = new System.Drawing.Point(4, 36);
            this.TxtFilterCheckinNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtFilterCheckinNo.Name = "TxtFilterCheckinNo";
            this.TxtFilterCheckinNo.Size = new System.Drawing.Size(150, 30);
            this.TxtFilterCheckinNo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "CheckIn No";
            // 
            // FromDatePanel
            // 
            this.FromDatePanel.Controls.Add(this.panel9);
            this.FromDatePanel.Controls.Add(this.DatePickerFilterFromDate);
            this.FromDatePanel.Controls.Add(this.label2);
            this.FromDatePanel.Location = new System.Drawing.Point(181, 29);
            this.FromDatePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FromDatePanel.Name = "FromDatePanel";
            this.FromDatePanel.Size = new System.Drawing.Size(169, 73);
            this.FromDatePanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "From Date";
            // 
            // DatePickerFilterFromDate
            // 
            this.DatePickerFilterFromDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerFilterFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerFilterFromDate.Location = new System.Drawing.Point(8, 36);
            this.DatePickerFilterFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePickerFilterFromDate.Name = "DatePickerFilterFromDate";
            this.DatePickerFilterFromDate.Size = new System.Drawing.Size(150, 30);
            this.DatePickerFilterFromDate.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dateTimePicker1);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(258, 6);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(268, 73);
            this.panel9.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 30);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "CheckIn No";
            // 
            // ToDatePanel
            // 
            this.ToDatePanel.Controls.Add(this.panel11);
            this.ToDatePanel.Controls.Add(this.DatePickerFilterToDate);
            this.ToDatePanel.Controls.Add(this.label7);
            this.ToDatePanel.Location = new System.Drawing.Point(367, 31);
            this.ToDatePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToDatePanel.Name = "ToDatePanel";
            this.ToDatePanel.Size = new System.Drawing.Size(171, 73);
            this.ToDatePanel.TabIndex = 12;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.dateTimePicker2);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Location = new System.Drawing.Point(258, 6);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(268, 73);
            this.panel11.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(8, 36);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(253, 30);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "CheckIn No";
            // 
            // DatePickerFilterToDate
            // 
            this.DatePickerFilterToDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePickerFilterToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerFilterToDate.Location = new System.Drawing.Point(8, 36);
            this.DatePickerFilterToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatePickerFilterToDate.Name = "DatePickerFilterToDate";
            this.DatePickerFilterToDate.Size = new System.Drawing.Size(150, 30);
            this.DatePickerFilterToDate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "To Date";
            // 
            // StaticDatePanel
            // 
            this.StaticDatePanel.Controls.Add(this.ComboBoxFilterPeriod);
            this.StaticDatePanel.Controls.Add(this.label4);
            this.StaticDatePanel.Location = new System.Drawing.Point(556, 31);
            this.StaticDatePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StaticDatePanel.Name = "StaticDatePanel";
            this.StaticDatePanel.Size = new System.Drawing.Size(168, 73);
            this.StaticDatePanel.TabIndex = 13;
            // 
            // ComboBoxFilterPeriod
            // 
            this.ComboBoxFilterPeriod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxFilterPeriod.FormattingEnabled = true;
            this.ComboBoxFilterPeriod.Location = new System.Drawing.Point(8, 35);
            this.ComboBoxFilterPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxFilterPeriod.Name = "ComboBoxFilterPeriod";
            this.ComboBoxFilterPeriod.Size = new System.Drawing.Size(150, 31);
            this.ComboBoxFilterPeriod.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Report Period";
            // 
            // BtnQuery
            // 
            this.BtnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.BtnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuery.ForeColor = System.Drawing.Color.White;
            this.BtnQuery.Location = new System.Drawing.Point(758, 64);
            this.BtnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(100, 31);
            this.BtnQuery.TabIndex = 14;
            this.BtnQuery.Text = "Query";
            this.BtnQuery.UseVisualStyleBackColor = false;
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(1099, 616);
            this.Load += new System.EventHandler(this.ReportControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).EndInit();
            this.CheckinNoPanel.ResumeLayout(false);
            this.CheckinNoPanel.PerformLayout();
            this.FromDatePanel.ResumeLayout(false);
            this.FromDatePanel.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ToDatePanel.ResumeLayout(false);
            this.ToDatePanel.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.StaticDatePanel.ResumeLayout(false);
            this.StaticDatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView ReportDataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel StaticDatePanel;
        private System.Windows.Forms.ComboBox ComboBoxFilterPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel ToDatePanel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DatePickerFilterToDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel FromDatePanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DatePickerFilterFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel CheckinNoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFilterCheckinNo;
        private System.Windows.Forms.Button BtnQuery;
    }
}
