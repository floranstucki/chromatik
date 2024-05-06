namespace Chromatik.Forms
{
    partial class frmFavoris
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
            this.lblFavoris = new System.Windows.Forms.Label();
            this.lvwFavoris = new System.Windows.Forms.ListView();
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblFavoris
            // 
            this.lblFavoris.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFavoris.AutoSize = true;
            this.lblFavoris.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoris.Location = new System.Drawing.Point(294, 9);
            this.lblFavoris.Name = "lblFavoris";
            this.lblFavoris.Size = new System.Drawing.Size(178, 45);
            this.lblFavoris.TabIndex = 0;
            this.lblFavoris.Text = "Vos Favoris";
            // 
            // lvwFavoris
            // 
            this.lvwFavoris.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFavoris.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chType,
            this.chNom,
            this.chDate});
            this.lvwFavoris.HideSelection = false;
            this.lvwFavoris.Location = new System.Drawing.Point(155, 89);
            this.lvwFavoris.Name = "lvwFavoris";
            this.lvwFavoris.Size = new System.Drawing.Size(535, 325);
            this.lvwFavoris.TabIndex = 2;
            this.lvwFavoris.UseCompatibleStateImageBehavior = false;
            this.lvwFavoris.View = System.Windows.Forms.View.Details;
            this.lvwFavoris.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwFavoris_ColumnClick);
            // 
            // chType
            // 
            this.chType.Text = "Type Fourniture";
            this.chType.Width = 98;
            // 
            // chNom
            // 
            this.chNom.Text = "Nom Fourniture";
            this.chNom.Width = 106;
            // 
            // chDate
            // 
            this.chDate.Text = "Date de mise en favori";
            this.chDate.Width = 140;
            // 
            // frmFavoris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwFavoris);
            this.Controls.Add(this.lblFavoris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFavoris";
            this.Text = "Favoris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFavoris;
        private System.Windows.Forms.ListView lvwFavoris;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chNom;
        private System.Windows.Forms.ColumnHeader chDate;
    }
}