namespace Chromatik.Forms
{
    partial class frmStock
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
            this.lblType = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cmbTypeFourniture = new System.Windows.Forms.ComboBox();
            this.cmbFournisseur = new System.Windows.Forms.ComboBox();
            this.cmbCouleur = new System.Windows.Forms.ComboBox();
            this.nudNombre = new System.Windows.Forms.NumericUpDown();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxMarque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(82, 72);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(102, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type de Fourniture :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(85, 139);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(79, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom Fourniture";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Location = new System.Drawing.Point(85, 202);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(52, 13);
            this.lblMarque.TabIndex = 2;
            this.lblMarque.Text = "Marque : ";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(451, 202);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(94, 13);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "Nombre à ajouter :";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(451, 139);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(69, 13);
            this.lblPrix.TabIndex = 4;
            this.lblPrix.Text = "Prix Unitaire :";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(448, 72);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(49, 13);
            this.lblCouleur.TabIndex = 3;
            this.lblCouleur.Text = "Couleur :";
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Location = new System.Drawing.Point(85, 265);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(61, 13);
            this.lblFournisseur.TabIndex = 6;
            this.lblFournisseur.Text = "Fournisseur";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(454, 265);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(252, 57);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cmbTypeFourniture
            // 
            this.cmbTypeFourniture.FormattingEnabled = true;
            this.cmbTypeFourniture.Location = new System.Drawing.Point(219, 69);
            this.cmbTypeFourniture.Name = "cmbTypeFourniture";
            this.cmbTypeFourniture.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeFourniture.TabIndex = 0;
            // 
            // cmbFournisseur
            // 
            this.cmbFournisseur.FormattingEnabled = true;
            this.cmbFournisseur.Location = new System.Drawing.Point(219, 262);
            this.cmbFournisseur.Name = "cmbFournisseur";
            this.cmbFournisseur.Size = new System.Drawing.Size(121, 21);
            this.cmbFournisseur.TabIndex = 3;
            // 
            // cmbCouleur
            // 
            this.cmbCouleur.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCouleur.FormattingEnabled = true;
            this.cmbCouleur.IntegralHeight = false;
            this.cmbCouleur.Location = new System.Drawing.Point(574, 69);
            this.cmbCouleur.MaxDropDownItems = 10;
            this.cmbCouleur.Name = "cmbCouleur";
            this.cmbCouleur.Size = new System.Drawing.Size(120, 21);
            this.cmbCouleur.TabIndex = 4;
            this.cmbCouleur.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbCouleur_DrawItem);
            // 
            // nudNombre
            // 
            this.nudNombre.Location = new System.Drawing.Point(574, 200);
            this.nudNombre.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNombre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNombre.Name = "nudNombre";
            this.nudNombre.Size = new System.Drawing.Size(120, 20);
            this.nudNombre.TabIndex = 6;
            this.nudNombre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrix
            // 
            this.nudPrix.DecimalPlaces = 1;
            this.nudPrix.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrix.Location = new System.Drawing.Point(574, 132);
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
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(219, 131);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(121, 20);
            this.tbxNom.TabIndex = 1;
            // 
            // tbxMarque
            // 
            this.tbxMarque.Location = new System.Drawing.Point(219, 202);
            this.tbxMarque.Name = "tbxMarque";
            this.tbxMarque.Size = new System.Drawing.Size(121, 20);
            this.tbxMarque.TabIndex = 2;
            // 
            // frmStock
            // 
            this.AcceptButton = this.btnAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 377);
            this.Controls.Add(this.tbxMarque);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.nudPrix);
            this.Controls.Add(this.nudNombre);
            this.Controls.Add(this.cmbCouleur);
            this.Controls.Add(this.cmbFournisseur);
            this.Controls.Add(this.cmbTypeFourniture);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblMarque);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStock";
            this.Text = "Ajout de Stock";
            ((System.ComponentModel.ISupportInitialize)(this.nudNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ComboBox cmbTypeFourniture;
        private System.Windows.Forms.ComboBox cmbFournisseur;
        private System.Windows.Forms.ComboBox cmbCouleur;
        private System.Windows.Forms.NumericUpDown nudNombre;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxMarque;
    }
}