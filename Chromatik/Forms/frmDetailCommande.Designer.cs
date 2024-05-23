namespace Chromatik.Forms
{
    partial class frmDetailCommande
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
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblDateCommande = new System.Windows.Forms.Label();
            this.tbxCommande = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(180, 38);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(410, 50);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "Détail de la commande ";
            // 
            // lblDateCommande
            // 
            this.lblDateCommande.AutoSize = true;
            this.lblDateCommande.Location = new System.Drawing.Point(304, 117);
            this.lblDateCommande.Name = "lblDateCommande";
            this.lblDateCommande.Size = new System.Drawing.Size(117, 13);
            this.lblDateCommande.TabIndex = 1;
            this.lblDateCommande.Text = "Commande passée le : ";
            // 
            // tbxCommande
            // 
            this.tbxCommande.Location = new System.Drawing.Point(189, 166);
            this.tbxCommande.Multiline = true;
            this.tbxCommande.Name = "tbxCommande";
            this.tbxCommande.ReadOnly = true;
            this.tbxCommande.Size = new System.Drawing.Size(401, 252);
            this.tbxCommande.TabIndex = 2;
            this.tbxCommande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(189, 424);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(401, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Générer le PDF de la commande";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmDetailCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbxCommande);
            this.Controls.Add(this.lblDateCommande);
            this.Controls.Add(this.lblDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailCommande";
            this.Text = "Detail de la commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblDateCommande;
        private System.Windows.Forms.TextBox tbxCommande;
        private System.Windows.Forms.Button btnGenerate;
    }
}