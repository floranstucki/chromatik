namespace Chromatik.Forms
{
    partial class frmListCommandes
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
            this.lblCommande = new System.Windows.Forms.Label();
            this.dgvCommande = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommande.Location = new System.Drawing.Point(244, 22);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(297, 50);
            this.lblCommande.TabIndex = 0;
            this.lblCommande.Text = "Vos Commandes";
            // 
            // dgvCommande
            // 
            this.dgvCommande.AllowUserToAddRows = false;
            this.dgvCommande.AllowUserToDeleteRows = false;
            this.dgvCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommande.Location = new System.Drawing.Point(147, 126);
            this.dgvCommande.Name = "dgvCommande";
            this.dgvCommande.ReadOnly = true;
            this.dgvCommande.Size = new System.Drawing.Size(491, 249);
            this.dgvCommande.TabIndex = 1;
            this.dgvCommande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommande_CellContentClick);
            this.dgvCommande.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCommande_ColumnHeaderMouseClick);
            // 
            // frmListCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCommande);
            this.Controls.Add(this.lblCommande);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListCommandes";
            this.Text = "Commandes";
            this.Load += new System.EventHandler(this.frmListCommandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.DataGridView dgvCommande;
    }
}