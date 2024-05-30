namespace Chromatik.Forms
{
    partial class frmProfile
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
            this.lblProfil = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblValueName = new System.Windows.Forms.Label();
            this.lblValueFirstName = new System.Windows.Forms.Label();
            this.lblValueEmail = new System.Windows.Forms.Label();
            this.lblValuePhone = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfil.Location = new System.Drawing.Point(230, 9);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(272, 65);
            this.lblProfil.TabIndex = 0;
            this.lblProfil.Text = "Your Profile";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(220, 132);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(220, 175);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(93, 21);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(220, 227);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 21);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email :";
            // 
            // lblValueName
            // 
            this.lblValueName.AutoSize = true;
            this.lblValueName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueName.Location = new System.Drawing.Point(404, 131);
            this.lblValueName.Name = "lblValueName";
            this.lblValueName.Size = new System.Drawing.Size(51, 21);
            this.lblValueName.TabIndex = 2;
            this.lblValueName.Text = "Stucki";
            // 
            // lblValueFirstName
            // 
            this.lblValueFirstName.AutoSize = true;
            this.lblValueFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueFirstName.Location = new System.Drawing.Point(404, 175);
            this.lblValueFirstName.Name = "lblValueFirstName";
            this.lblValueFirstName.Size = new System.Drawing.Size(54, 21);
            this.lblValueFirstName.TabIndex = 3;
            this.lblValueFirstName.Text = "Floran";
            // 
            // lblValueEmail
            // 
            this.lblValueEmail.AutoSize = true;
            this.lblValueEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueEmail.Location = new System.Drawing.Point(404, 227);
            this.lblValueEmail.Name = "lblValueEmail";
            this.lblValueEmail.Size = new System.Drawing.Size(60, 21);
            this.lblValueEmail.TabIndex = 4;
            this.lblValueEmail.Text = "flo_s98";
            // 
            // lblValuePhone
            // 
            this.lblValuePhone.AutoSize = true;
            this.lblValuePhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValuePhone.Location = new System.Drawing.Point(404, 274);
            this.lblValuePhone.Name = "lblValuePhone";
            this.lblValuePhone.Size = new System.Drawing.Size(136, 21);
            this.lblValuePhone.TabIndex = 5;
            this.lblValuePhone.Text = "+41 79 422 51 88";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(220, 274);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(123, 21);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number :";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(224, 393);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(316, 23);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modify your Informations";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(224, 331);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(316, 23);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change password";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frmProfile
            // 
            this.AcceptButton = this.btnModify;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lblValuePhone);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblValueEmail);
            this.Controls.Add(this.lblValueFirstName);
            this.Controls.Add(this.lblValueName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfile";
            this.Text = "Your Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblValueName;
        private System.Windows.Forms.Label lblValueFirstName;
        private System.Windows.Forms.Label lblValueEmail;
        private System.Windows.Forms.Label lblValuePhone;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnChange;
    }
}