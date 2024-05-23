namespace Chromatik
{
    partial class frmForgotPassword
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
            this.tbxConfirmation = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxConfirmation
            // 
            this.tbxConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxConfirmation.Location = new System.Drawing.Point(164, 131);
            this.tbxConfirmation.Name = "tbxConfirmation";
            this.tbxConfirmation.Size = new System.Drawing.Size(100, 20);
            this.tbxConfirmation.TabIndex = 2;
            this.tbxConfirmation.UseSystemPasswordChar = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPassword.Location = new System.Drawing.Point(164, 82);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxUsername.Location = new System.Drawing.Point(164, 36);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(100, 20);
            this.tbxUsername.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Username :";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(164, 200);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset Password";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(158, 173);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(106, 13);
            this.lblWarning.TabIndex = 17;
            this.lblWarning.Text = "Under construction !!\r\n";
            // 
            // frmForgotPassword
            // 
            this.AcceptButton = this.btnReset;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 254);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxConfirmation);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForgotPassword";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxConfirmation;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWarning;
    }
}