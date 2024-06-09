namespace Manager_asm.AdminPages
{
    partial class frmUpdateProfileAdmin
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCurrPass = new System.Windows.Forms.TextBox();
            this.txtCurrUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.Location = new System.Drawing.Point(324, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(138, 48);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCurrPass
            // 
            this.txtCurrPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrPass.Location = new System.Drawing.Point(55, 160);
            this.txtCurrPass.Name = "txtCurrPass";
            this.txtCurrPass.ReadOnly = true;
            this.txtCurrPass.Size = new System.Drawing.Size(202, 20);
            this.txtCurrPass.TabIndex = 15;
            // 
            // txtCurrUser
            // 
            this.txtCurrUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrUser.Location = new System.Drawing.Point(55, 94);
            this.txtCurrUser.Name = "txtCurrUser";
            this.txtCurrUser.ReadOnly = true;
            this.txtCurrUser.Size = new System.Drawing.Size(202, 20);
            this.txtCurrUser.TabIndex = 14;
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(52, 144);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(93, 13);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Current Password:";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(52, 78);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(95, 13);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "Current Username:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass.Location = new System.Drawing.Point(518, 160);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(202, 20);
            this.txtNewPass.TabIndex = 19;
            // 
            // txtNewUser
            // 
            this.txtNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewUser.Location = new System.Drawing.Point(518, 94);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(202, 20);
            this.txtNewUser.TabIndex = 18;
            // 
            // lblNewPass
            // 
            this.lblNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(515, 144);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(81, 13);
            this.lblNewPass.TabIndex = 17;
            this.lblNewPass.Text = "New Password:";
            // 
            // lblNewUser
            // 
            this.lblNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Location = new System.Drawing.Point(515, 78);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(83, 13);
            this.lblNewUser.TabIndex = 16;
            this.lblNewUser.Text = "New Username:";
            // 
            // frmUpdateProfileAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.txtCurrPass);
            this.Controls.Add(this.txtCurrUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmUpdateProfileAdmin";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCurrPass;
        private System.Windows.Forms.TextBox txtCurrUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblNewUser;
    }
}