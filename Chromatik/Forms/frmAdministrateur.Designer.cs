﻿namespace Chromatik.Forms
{
    partial class frmAdministrateur
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtVente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvCommandes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chtVente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // chtVente
            // 
            chartArea1.Name = "ChartArea1";
            this.chtVente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtVente.Legends.Add(legend1);
            this.chtVente.Location = new System.Drawing.Point(12, 12);
            this.chtVente.Name = "chtVente";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtVente.Series.Add(series1);
            this.chtVente.Size = new System.Drawing.Size(564, 332);
            this.chtVente.TabIndex = 0;
            this.chtVente.Text = "chart1";
            // 
            // dgvCommandes
            // 
            this.dgvCommandes.AllowUserToAddRows = false;
            this.dgvCommandes.AllowUserToDeleteRows = false;
            this.dgvCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandes.Location = new System.Drawing.Point(593, 12);
            this.dgvCommandes.Name = "dgvCommandes";
            this.dgvCommandes.ReadOnly = true;
            this.dgvCommandes.Size = new System.Drawing.Size(575, 332);
            this.dgvCommandes.TabIndex = 1;
            this.dgvCommandes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommandes_CellContentClick);
            // 
            // frmAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 632);
            this.Controls.Add(this.dgvCommandes);
            this.Controls.Add(this.chtVente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdministrateur";
            this.Text = "Interface Administrateur";
            ((System.ComponentModel.ISupportInitialize)(this.chtVente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtVente;
        private System.Windows.Forms.DataGridView dgvCommandes;
    }
}