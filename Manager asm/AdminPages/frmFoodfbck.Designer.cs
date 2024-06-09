using System.Drawing;
using System.Windows.Forms;
using System;

namespace Manager_asm.AdminPages
{
    partial class frmFoodfbck
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvFeedbackFood;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvFeedbackFood = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbackFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedbackFood
            // 
            this.dgvFeedbackFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFeedbackFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedbackFood.Location = new System.Drawing.Point(12, 12);
            this.dgvFeedbackFood.Name = "dgvFeedbackFood";
            this.dgvFeedbackFood.Size = new System.Drawing.Size(760, 437);
            this.dgvFeedbackFood.TabIndex = 0;
            // 
            // frmFoodfbck
            // 
            this.Controls.Add(this.dgvFeedbackFood);
            this.Name = "frmFoodfbck";
            this.Size = new System.Drawing.Size(784, 461);
            this.Load += new System.EventHandler(this.frmFoodfbck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbackFood)).EndInit();
            this.ResumeLayout(false);

        }
    }
}