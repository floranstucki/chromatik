namespace Chromatik.Forms
{
    partial class frmFavorites
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
            this.lblFavorites = new System.Windows.Forms.Label();
            this.dgvFavorites = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFavorites
            // 
            this.lblFavorites.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFavorites.AutoSize = true;
            this.lblFavorites.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorites.Location = new System.Drawing.Point(294, 9);
            this.lblFavorites.Name = "lblFavorites";
            this.lblFavorites.Size = new System.Drawing.Size(218, 45);
            this.lblFavorites.TabIndex = 0;
            this.lblFavorites.Text = "Your Favorites";
            // 
            // dgvFavorites
            // 
            this.dgvFavorites.AllowUserToAddRows = false;
            this.dgvFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavorites.Location = new System.Drawing.Point(91, 78);
            this.dgvFavorites.Name = "dgvFavorites";
            this.dgvFavorites.Size = new System.Drawing.Size(600, 331);
            this.dgvFavorites.TabIndex = 1;
            this.dgvFavorites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFavorites_CellContentClick);
            // 
            // frmFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFavorites);
            this.Controls.Add(this.lblFavorites);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFavorites";
            this.Text = "Favorites";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFavorites;
        private System.Windows.Forms.DataGridView dgvFavorites;
    }
}