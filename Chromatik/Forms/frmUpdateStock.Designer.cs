namespace Chromatik.Forms
{
    partial class frmUpdateStock
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
            this.tbxMarque = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.cmbCouleur = new System.Windows.Forms.ComboBox();
            this.cmbFournisseur = new System.Windows.Forms.ComboBox();
            this.cmbTypeFourniture = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxMarque
            // 
            this.tbxMarque.Location = new System.Drawing.Point(190, 187);
            this.tbxMarque.Name = "tbxMarque";
            this.tbxMarque.Size = new System.Drawing.Size(121, 20);
            this.tbxMarque.TabIndex = 2;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(190, 116);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(121, 20);
            this.tbxNom.TabIndex = 1;
            // 
            // nudPrix
            // 
            this.nudPrix.DecimalPlaces = 1;
            this.nudPrix.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrix.Location = new System.Drawing.Point(536, 180);
            this.nudPrix.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrix.Name = "nudPrix";
            this.nudPrix.Size = new System.Drawing.Size(119, 20);
            this.nudPrix.TabIndex = 5;
            this.nudPrix.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbCouleur
            // 
            this.cmbCouleur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCouleur.FormattingEnabled = true;
            this.cmbCouleur.IntegralHeight = false;
            this.cmbCouleur.Location = new System.Drawing.Point(536, 117);
            this.cmbCouleur.MaxDropDownItems = 10;
            this.cmbCouleur.Name = "cmbCouleur";
            this.cmbCouleur.Size = new System.Drawing.Size(120, 21);
            this.cmbCouleur.TabIndex = 4;
            // 
            // cmbFournisseur
            // 
            this.cmbFournisseur.FormattingEnabled = true;
            this.cmbFournisseur.Location = new System.Drawing.Point(536, 54);
            this.cmbFournisseur.Name = "cmbFournisseur";
            this.cmbFournisseur.Size = new System.Drawing.Size(121, 21);
            this.cmbFournisseur.TabIndex = 3;
            // 
            // cmbTypeFourniture
            // 
            this.cmbTypeFourniture.FormattingEnabled = true;
            this.cmbTypeFourniture.Location = new System.Drawing.Point(190, 54);
            this.cmbTypeFourniture.Name = "cmbTypeFourniture";
            this.cmbTypeFourniture.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeFourniture.TabIndex = 0;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(425, 250);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(252, 57);
            this.btnModifier.TabIndex = 7;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Location = new System.Drawing.Point(402, 57);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(61, 13);
            this.lblFournisseur.TabIndex = 21;
            this.lblFournisseur.Text = "Fournisseur";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(413, 187);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(69, 13);
            this.lblPrix.TabIndex = 17;
            this.lblPrix.Text = "Prix Unitaire :";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(410, 120);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(49, 13);
            this.lblCouleur.TabIndex = 15;
            this.lblCouleur.Text = "Couleur :";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(56, 187);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(52, 13);
            this.lblMarque.TabIndex = 13;
            this.lblMarque.Text = "Marque : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(56, 124);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(79, 13);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Nom Fourniture";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(53, 57);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(102, 13);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type de Fourniture :";
            // 
            // frmUpdateStock
            // 
            this.AcceptButton = this.btnModifier;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 345);
            this.Controls.Add(this.tbxMarque);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.nudPrix);
            this.Controls.Add(this.cmbCouleur);
            this.Controls.Add(this.cmbFournisseur);
            this.Controls.Add(this.cmbTypeFourniture);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdateStock";
            this.Text = "Modification de stock";
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMarque;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.ComboBox cmbCouleur;
        private System.Windows.Forms.ComboBox cmbFournisseur;
        private System.Windows.Forms.ComboBox cmbTypeFourniture;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblType;
    }
}