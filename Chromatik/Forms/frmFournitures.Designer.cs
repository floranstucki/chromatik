namespace Chromatik.Forms
{
    partial class frmFournitures
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
            this.dgvFournitures = new System.Windows.Forms.DataGridView();
            this.lblFourniture = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournitures)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFournitures
            // 
            this.dgvFournitures.AllowUserToAddRows = false;
            this.dgvFournitures.AllowUserToDeleteRows = false;
            this.dgvFournitures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFournitures.Location = new System.Drawing.Point(140, 124);
            this.dgvFournitures.Name = "dgvFournitures";
            this.dgvFournitures.ReadOnly = true;
            this.dgvFournitures.Size = new System.Drawing.Size(519, 332);
            this.dgvFournitures.TabIndex = 0;
            this.dgvFournitures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFournitures_CellContentClick);
            // 
            // lblFourniture
            // 
            this.lblFourniture.AutoSize = true;
            this.lblFourniture.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourniture.Location = new System.Drawing.Point(216, 20);
            this.lblFourniture.Name = "lblFourniture";
            this.lblFourniture.Size = new System.Drawing.Size(334, 45);
            this.lblFourniture.TabIndex = 1;
            this.lblFourniture.Text = "Toutes les fournitures ";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(517, 95);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(142, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter du stock";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Visible = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // frmFournitures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblFourniture);
            this.Controls.Add(this.dgvFournitures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFournitures";
            this.Text = "Fournitures";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFournitures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFournitures;
        private System.Windows.Forms.Label lblFourniture;
        private System.Windows.Forms.Button btnAjouter;
    }
}