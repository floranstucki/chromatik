﻿namespace Chromatik
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llbForgot = new System.Windows.Forms.LinkLabel();
            this.llbSignUp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(140, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email :";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(140, 102);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(59, 13);
            this.lblPwd.TabIndex = 5;
            this.lblPwd.Text = "Password :";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(247, 36);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(160, 20);
            this.tbxEmail.TabIndex = 0;
            this.tbxEmail.Text = "schneider.jaunita@example.org";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(247, 95);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(160, 20);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.Text = "password";
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(216, 221);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // llbForgot
            // 
            this.llbForgot.AutoSize = true;
            this.llbForgot.Location = new System.Drawing.Point(192, 183);
            this.llbForgot.Name = "llbForgot";
            this.llbForgot.Size = new System.Drawing.Size(95, 13);
            this.llbForgot.TabIndex = 3;
            this.llbForgot.TabStop = true;
            this.llbForgot.Text = "Forgot Password ?";
            this.llbForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbForgot_LinkClicked);
            // 
            // llbSignUp
            // 
            this.llbSignUp.AutoSize = true;
            this.llbSignUp.Location = new System.Drawing.Point(293, 183);
            this.llbSignUp.Name = "llbSignUp";
            this.llbSignUp.Size = new System.Drawing.Size(114, 13);
            this.llbSignUp.TabIndex = 6;
            this.llbSignUp.TabStop = true;
            this.llbSignUp.Text = "No Account ? Sign Up";
            this.llbSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignUp_LinkClicked);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 266);
            this.Controls.Add(this.llbSignUp);
            this.Controls.Add(this.llbForgot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llbForgot;
        private System.Windows.Forms.LinkLabel llbSignUp;
    }
}
