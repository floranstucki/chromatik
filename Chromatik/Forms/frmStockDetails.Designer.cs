namespace Chromatik.Forms
{
    partial class frmStockDetails
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
            this.btnFavorites = new System.Windows.Forms.Button();
            this.lvwStockDetails = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(177, 52);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(150, 32);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "Stock Details";
            // 
            // btnFavorites
            // 
            this.btnFavorites.Location = new System.Drawing.Point(412, 119);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(138, 23);
            this.btnFavorites.TabIndex = 4;
            this.btnFavorites.Text = "Add to Favorites";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // lvwStockDetails
            // 
            this.lvwStockDetails.HideSelection = false;
            this.lvwStockDetails.Location = new System.Drawing.Point(75, 148);
            this.lvwStockDetails.Name = "lvwStockDetails";
            this.lvwStockDetails.Size = new System.Drawing.Size(475, 131);
            this.lvwStockDetails.TabIndex = 6;
            this.lvwStockDetails.UseCompatibleStateImageBehavior = false;
            // 
            // frmStockDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 346);
            this.Controls.Add(this.lvwStockDetails);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.lblDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockDetails";
            this.Text = "Détails de fourniture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.ListView lvwStockDetails;
    }
}