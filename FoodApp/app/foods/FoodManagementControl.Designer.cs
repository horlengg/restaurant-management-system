
namespace FoodApp.app.foods
{
    partial class FoodManagementControl
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
            this.FoodListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAddFood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FoodListPanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 653);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FoodListPanel
            // 
            this.FoodListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoodListPanel.Location = new System.Drawing.Point(0, 60);
            this.FoodListPanel.Name = "FoodListPanel";
            this.FoodListPanel.Size = new System.Drawing.Size(991, 593);
            this.FoodListPanel.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 60);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnAddFood);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(825, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 60);
            this.panel3.TabIndex = 3;
            // 
            // BtnAddFood
            // 
            this.BtnAddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.BtnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddFood.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddFood.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddFood.ForeColor = System.Drawing.Color.White;
            this.BtnAddFood.Location = new System.Drawing.Point(25, 10);
            this.BtnAddFood.Name = "BtnAddFood";
            this.BtnAddFood.Size = new System.Drawing.Size(136, 40);
            this.BtnAddFood.TabIndex = 1;
            this.BtnAddFood.Text = "Add Food";
            this.BtnAddFood.UseVisualStyleBackColor = false;
            this.BtnAddFood.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(127)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(27, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Food Manegment";
            // 
            // FoodManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "FoodManagementControl";
            this.Size = new System.Drawing.Size(991, 653);
            this.Load += new System.EventHandler(this.FoodManagementControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel FoodListPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnAddFood;
    }
}
