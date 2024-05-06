namespace Chromatik.Forms
{
    partial class frmPanier
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
            this.lblPanier = new System.Windows.Forms.Label();
            this.lvwPanier = new System.Windows.Forms.ListView();
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPrix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCommande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPanier
            // 
            this.lblPanier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPanier.AutoSize = true;
            this.lblPanier.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanier.Location = new System.Drawing.Point(274, 37);
            this.lblPanier.Name = "lblPanier";
            this.lblPanier.Size = new System.Drawing.Size(221, 50);
            this.lblPanier.TabIndex = 0;
            this.lblPanier.Text = "Votre Panier";
            // 
            // lvwPanier
            // 
            this.lvwPanier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwPanier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chType,
            this.chNom,
            this.chNombre,
            this.chPrix});
            this.lvwPanier.HideSelection = false;
            this.lvwPanier.Location = new System.Drawing.Point(180, 107);
            this.lvwPanier.Name = "lvwPanier";
            this.lvwPanier.Size = new System.Drawing.Size(472, 285);
            this.lvwPanier.TabIndex = 1;
            this.lvwPanier.UseCompatibleStateImageBehavior = false;
            this.lvwPanier.View = System.Windows.Forms.View.Details;
            this.lvwPanier.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwPanier_ColumnClick);
            // 
            // chType
            // 
            this.chType.Text = "Type fourniture";
            this.chType.Width = 108;
            // 
            // chNom
            // 
            this.chNom.Text = "Nom ";
            this.chNom.Width = 135;
            // 
            // chNombre
            // 
            this.chNombre.Text = "Nombre de pièces";
            // 
            // chPrix
            // 
            this.chPrix.Text = "Prix Unitaire";
            // 
            // btnCommande
            // 
            this.btnCommande.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCommande.Location = new System.Drawing.Point(180, 415);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(472, 23);
            this.btnCommande.TabIndex = 2;
            this.btnCommande.Text = "Commander";
            this.btnCommande.UseVisualStyleBackColor = true;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // frmPanier
            // 
            this.AcceptButton = this.btnCommande;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCommande);
            this.Controls.Add(this.lvwPanier);
            this.Controls.Add(this.lblPanier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPanier";
            this.Text = "Panier";
            this.Load += new System.EventHandler(this.frmPanier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPanier;
        private System.Windows.Forms.ListView lvwPanier;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chNom;
        private System.Windows.Forms.ColumnHeader chNombre;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.ColumnHeader chPrix;
    }
}