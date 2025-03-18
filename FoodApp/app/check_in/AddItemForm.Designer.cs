
namespace FoodApp.app.check_in
{
    partial class AddItemForm
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
            this.ListFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ListFlowLayoutPanel
            // 
            this.ListFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ListFlowLayoutPanel.Name = "ListFlowLayoutPanel";
            this.ListFlowLayoutPanel.Padding = new System.Windows.Forms.Padding(20, 20, 20, 40);
            this.ListFlowLayoutPanel.Size = new System.Drawing.Size(773, 521);
            this.ListFlowLayoutPanel.TabIndex = 0;
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 521);
            this.Controls.Add(this.ListFlowLayoutPanel);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ListFlowLayoutPanel;
    }
}