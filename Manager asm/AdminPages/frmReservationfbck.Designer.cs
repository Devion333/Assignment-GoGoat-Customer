namespace Manager_asm.AdminPages
{
    partial class frmReservationfbck
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
            this.dgvFeedbackReservation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbackReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedbackReservation
            // 
            this.dgvFeedbackReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvFeedbackReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedbackReservation.Location = new System.Drawing.Point(20, 7);
            this.dgvFeedbackReservation.Name = "dgvFeedbackReservation";
            this.dgvFeedbackReservation.Size = new System.Drawing.Size(760, 437);
            this.dgvFeedbackReservation.TabIndex = 1;
            // 
            // frmReservationfbck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFeedbackReservation);
            this.Name = "frmReservationfbck";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbackReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeedbackReservation;
    }
}