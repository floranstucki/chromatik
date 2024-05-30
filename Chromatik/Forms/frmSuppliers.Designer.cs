namespace Chromatik.Forms
{
    partial class frmSuppliers
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNPA = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxSupplier = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxNPA = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(90, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Supplier Name :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(90, 149);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address :";
            // 
            // lblNPA
            // 
            this.lblNPA.AutoSize = true;
            this.lblNPA.Location = new System.Drawing.Point(90, 221);
            this.lblNPA.Name = "lblNPA";
            this.lblNPA.Size = new System.Drawing.Size(35, 13);
            this.lblNPA.TabIndex = 2;
            this.lblNPA.Text = "NPA :";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(422, 68);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City : ";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(422, 149);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(87, 13);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number : ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(425, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(271, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add a supplier";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxSupplier
            // 
            this.tbxSupplier.Location = new System.Drawing.Point(232, 65);
            this.tbxSupplier.Name = "tbxSupplier";
            this.tbxSupplier.Size = new System.Drawing.Size(144, 20);
            this.tbxSupplier.TabIndex = 0;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(232, 149);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(144, 20);
            this.tbxAddress.TabIndex = 1;
            // 
            // tbxNPA
            // 
            this.tbxNPA.Location = new System.Drawing.Point(232, 218);
            this.tbxNPA.MaxLength = 5;
            this.tbxNPA.Name = "tbxNPA";
            this.tbxNPA.Size = new System.Drawing.Size(144, 20);
            this.tbxNPA.TabIndex = 2;
            this.tbxNPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNPA_KeyPress);
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(552, 68);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(144, 20);
            this.tbxCity.TabIndex = 3;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(552, 145);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(144, 20);
            this.tbPhone.TabIndex = 4;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhoneNumber_KeyPress);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(552, 221);
            this.tbxEmail.MaxLength = 50;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(144, 20);
            this.tbxEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(422, 221);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email :";
            // 
            // frmSuppliers
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxNPA);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxSupplier);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblNPA);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuppliers";
            this.Text = "Add a new Supplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNPA;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxSupplier;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxNPA;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}