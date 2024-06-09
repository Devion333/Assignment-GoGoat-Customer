namespace Manager_asm.CustomerPages
{
    partial class Page_ProfileCus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_ProfileCus));
            this.btn_Password = new System.Windows.Forms.Button();
            this.btn_PI = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Password
            // 
            this.btn_Password.Location = new System.Drawing.Point(202, 464);
            this.btn_Password.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Password.Name = "btn_Password";
            this.btn_Password.Size = new System.Drawing.Size(221, 56);
            this.btn_Password.TabIndex = 19;
            this.btn_Password.Text = "Login Details";
            this.btn_Password.UseVisualStyleBackColor = true;
            this.btn_Password.Click += new System.EventHandler(this.btn_Password_Click);
            // 
            // btn_PI
            // 
            this.btn_PI.Location = new System.Drawing.Point(202, 329);
            this.btn_PI.Margin = new System.Windows.Forms.Padding(2);
            this.btn_PI.Name = "btn_PI";
            this.btn_PI.Size = new System.Drawing.Size(221, 63);
            this.btn_PI.TabIndex = 18;
            this.btn_PI.Text = "Personal Information";
            this.btn_PI.UseVisualStyleBackColor = true;
            this.btn_PI.Click += new System.EventHandler(this.btn_PI_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2045, 138);
            this.panel5.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(934, 33);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelProfile
            // 
            this.panelProfile.Location = new System.Drawing.Point(878, 329);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(2);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(906, 737);
            this.panelProfile.TabIndex = 17;
            // 
            // Page_ProfileCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Password);
            this.Controls.Add(this.btn_PI);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelProfile);
            this.Name = "Page_ProfileCus";
            this.Size = new System.Drawing.Size(2045, 979);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Password;
        private System.Windows.Forms.Button btn_PI;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelProfile;
    }
}
