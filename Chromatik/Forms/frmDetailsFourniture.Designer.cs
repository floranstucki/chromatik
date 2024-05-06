namespace Chromatik.Forms
{
    partial class frmDetailsFourniture
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
            this.lblDetail = new System.Windows.Forms.Label();
            this.tbxFourniture = new System.Windows.Forms.TextBox();
            this.btnFavoris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(177, 52);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(105, 32);
            this.lblDetail.TabIndex = 0;
            this.lblDetail.Text = "Détails : ";
            // 
            // tbxFourniture
            // 
            this.tbxFourniture.Location = new System.Drawing.Point(183, 149);
            this.tbxFourniture.Multiline = true;
            this.tbxFourniture.Name = "tbxFourniture";
            this.tbxFourniture.ReadOnly = true;
            this.tbxFourniture.Size = new System.Drawing.Size(401, 252);
            this.tbxFourniture.TabIndex = 3;
            this.tbxFourniture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFavoris
            // 
            this.btnFavoris.Location = new System.Drawing.Point(446, 120);
            this.btnFavoris.Name = "btnFavoris";
            this.btnFavoris.Size = new System.Drawing.Size(138, 23);
            this.btnFavoris.TabIndex = 4;
            this.btnFavoris.Text = "Ajouter aux favoris";
            this.btnFavoris.UseVisualStyleBackColor = true;
            this.btnFavoris.Click += new System.EventHandler(this.btnFavoris_Click);
            // 
            // frmDetailsFourniture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFavoris);
            this.Controls.Add(this.tbxFourniture);
            this.Controls.Add(this.lblDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailsFourniture";
            this.Text = "Détails de fourniture";
            this.Load += new System.EventHandler(this.frmDetailsFourniture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TextBox tbxFourniture;
        private System.Windows.Forms.Button btnFavoris;
    }
}