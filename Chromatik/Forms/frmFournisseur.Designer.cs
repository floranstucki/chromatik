namespace Chromatik.Forms
{
    partial class frmFournisseur
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
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNPA = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tbxFournisseur = new System.Windows.Forms.TextBox();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.tbxNPA = new System.Windows.Forms.TextBox();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Location = new System.Drawing.Point(90, 68);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(104, 13);
            this.lblFournisseur.TabIndex = 0;
            this.lblFournisseur.Text = "Nom du fournisseur :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(90, 149);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 1;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblNPA
            // 
            this.lblNPA.AutoSize = true;
            this.lblNPA.Location = new System.Drawing.Point(90, 221);
            this.lblNPA.Name = "lblNPA";
            this.lblNPA.Size = new System.Drawing.Size(70, 13);
            this.lblNPA.TabIndex = 2;
            this.lblNPA.Text = "Code Postal :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(422, 68);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 3;
            this.lblVille.Text = "Ville :";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(422, 149);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(64, 13);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Téléphone :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(271, 291);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(239, 23);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // tbxFournisseur
            // 
            this.tbxFournisseur.Location = new System.Drawing.Point(232, 65);
            this.tbxFournisseur.Name = "tbxFournisseur";
            this.tbxFournisseur.Size = new System.Drawing.Size(144, 20);
            this.tbxFournisseur.TabIndex = 0;
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.Location = new System.Drawing.Point(232, 149);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(144, 20);
            this.tbxAdresse.TabIndex = 1;
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
            // tbxVille
            // 
            this.tbxVille.Location = new System.Drawing.Point(520, 65);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(144, 20);
            this.tbxVille.TabIndex = 3;
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Location = new System.Drawing.Point(520, 142);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(144, 20);
            this.tbxTelephone.TabIndex = 4;
            this.tbxTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTelephone_KeyPress);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(520, 218);
            this.tbxEmail.MaxLength = 5;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(144, 20);
            this.tbxEmail.TabIndex = 6;
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
            // frmFournisseur
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 393);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.tbxVille);
            this.Controls.Add(this.tbxNPA);
            this.Controls.Add(this.tbxAdresse);
            this.Controls.Add(this.tbxFournisseur);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblNPA);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFournisseur";
            this.Text = "Ajout d\'un nouveau fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNPA;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox tbxFournisseur;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.TextBox tbxNPA;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}