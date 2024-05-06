namespace Chromatik
{
    partial class frmCommande
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
            this.cmbTypeFourniture = new System.Windows.Forms.ComboBox();
            this.lblTypeFourniture = new System.Windows.Forms.Label();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAjoutPanier = new System.Windows.Forms.Button();
            this.lblFourniture = new System.Windows.Forms.Label();
            this.cmbFourniture = new System.Windows.Forms.ComboBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.cmbCouleur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTypeFourniture
            // 
            this.cmbTypeFourniture.FormattingEnabled = true;
            this.cmbTypeFourniture.Location = new System.Drawing.Point(177, 34);
            this.cmbTypeFourniture.Name = "cmbTypeFourniture";
            this.cmbTypeFourniture.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeFourniture.TabIndex = 0;
            this.cmbTypeFourniture.SelectedIndexChanged += new System.EventHandler(this.cmbTypeFourniture_SelectedIndexChanged);
            // 
            // lblTypeFourniture
            // 
            this.lblTypeFourniture.AutoSize = true;
            this.lblTypeFourniture.Location = new System.Drawing.Point(69, 37);
            this.lblTypeFourniture.Name = "lblTypeFourniture";
            this.lblTypeFourniture.Size = new System.Drawing.Size(93, 13);
            this.lblTypeFourniture.TabIndex = 1;
            this.lblTypeFourniture.Text = "Type de fourniture";
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(178, 211);
            this.nudQuantite.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuantite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(120, 20);
            this.nudQuantite.TabIndex = 3;
            this.nudQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 218);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre :";
            // 
            // btnAjoutPanier
            // 
            this.btnAjoutPanier.Location = new System.Drawing.Point(177, 256);
            this.btnAjoutPanier.Name = "btnAjoutPanier";
            this.btnAjoutPanier.Size = new System.Drawing.Size(121, 23);
            this.btnAjoutPanier.TabIndex = 4;
            this.btnAjoutPanier.Text = "Ajouter au panier";
            this.btnAjoutPanier.UseVisualStyleBackColor = true;
            this.btnAjoutPanier.Click += new System.EventHandler(this.btnAjoutPanier_Click);
            // 
            // lblFourniture
            // 
            this.lblFourniture.AutoSize = true;
            this.lblFourniture.Location = new System.Drawing.Point(69, 88);
            this.lblFourniture.Name = "lblFourniture";
            this.lblFourniture.Size = new System.Drawing.Size(54, 13);
            this.lblFourniture.TabIndex = 6;
            this.lblFourniture.Text = "Fourniture";
            // 
            // cmbFourniture
            // 
            this.cmbFourniture.FormattingEnabled = true;
            this.cmbFourniture.Location = new System.Drawing.Point(177, 85);
            this.cmbFourniture.Name = "cmbFourniture";
            this.cmbFourniture.Size = new System.Drawing.Size(121, 21);
            this.cmbFourniture.TabIndex = 1;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(70, 148);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(49, 13);
            this.lblCouleur.TabIndex = 7;
            this.lblCouleur.Text = "Couleur :";
            // 
            // cmbCouleur
            // 
            this.cmbCouleur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCouleur.FormattingEnabled = true;
            this.cmbCouleur.Location = new System.Drawing.Point(177, 139);
            this.cmbCouleur.Name = "cmbCouleur";
            this.cmbCouleur.Size = new System.Drawing.Size(121, 21);
            this.cmbCouleur.TabIndex = 2;
            this.cmbCouleur.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbCouleur_DrawItem);
            // 
            // frmCommande
            // 
            this.AcceptButton = this.btnAjoutPanier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 305);
            this.Controls.Add(this.cmbCouleur);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblFourniture);
            this.Controls.Add(this.cmbFourniture);
            this.Controls.Add(this.btnAjoutPanier);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.lblTypeFourniture);
            this.Controls.Add(this.cmbTypeFourniture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCommande";
            this.Text = "Commande";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTypeFourniture;
        private System.Windows.Forms.Label lblTypeFourniture;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAjoutPanier;
        private System.Windows.Forms.Label lblFourniture;
        private System.Windows.Forms.ComboBox cmbFourniture;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.ComboBox cmbCouleur;
    }
}