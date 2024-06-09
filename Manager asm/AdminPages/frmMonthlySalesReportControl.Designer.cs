namespace Manager_asm.AdminPages
{
    partial class frmMonthlySalesReportControl
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
            this.components = new System.ComponentModel.Container();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbChef = new System.Windows.Forms.ComboBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.goDB1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._GoDB__1_DataSet = new Manager_asm._GoDB__1_DataSet();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblchef = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goDB1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._GoDB__1_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(223, 334);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 0;
            // 
            // cmbChef
            // 
            this.cmbChef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbChef.FormattingEnabled = true;
            this.cmbChef.Location = new System.Drawing.Point(223, 390);
            this.cmbChef.Name = "cmbChef";
            this.cmbChef.Size = new System.Drawing.Size(121, 21);
            this.cmbChef.TabIndex = 1;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.Chocolate;
            this.btnGenerateReport.Location = new System.Drawing.Point(375, 350);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(138, 48);
            this.btnGenerateReport.TabIndex = 14;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSalesReport.AutoGenerateColumns = false;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.DataSource = this.goDB1DataSetBindingSource;
            this.dgvSalesReport.Location = new System.Drawing.Point(61, 28);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.Size = new System.Drawing.Size(640, 210);
            this.dgvSalesReport.TabIndex = 15;
            // 
            // goDB1DataSetBindingSource
            // 
            this.goDB1DataSetBindingSource.DataSource = this._GoDB__1_DataSet;
            this.goDB1DataSetBindingSource.Position = 0;
            // 
            // _GoDB__1_DataSet
            // 
            this._GoDB__1_DataSet.DataSetName = "_GoDB__1_DataSet";
            this._GoDB__1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMonth
            // 
            this.lblMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(223, 315);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 16;
            this.lblMonth.Text = "Month";
            // 
            // lblchef
            // 
            this.lblchef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblchef.AutoSize = true;
            this.lblchef.Location = new System.Drawing.Point(223, 374);
            this.lblchef.Name = "lblchef";
            this.lblchef.Size = new System.Drawing.Size(29, 13);
            this.lblchef.TabIndex = 17;
            this.lblchef.Text = "Chef";
            // 
            // frmMonthlySalesReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblchef);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.cmbChef);
            this.Controls.Add(this.cmbMonth);
            this.Name = "frmMonthlySalesReportControl";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goDB1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._GoDB__1_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbChef;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.BindingSource goDB1DataSetBindingSource;
        private _GoDB__1_DataSet _GoDB__1_DataSet;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblchef;
    }
}