namespace Chromatik.Forms
{
    partial class frmOrderDetails
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
            this.lblDate = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lvwOrder = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(281, 34);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(234, 50);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "Order details";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(186, 111);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(65, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Order Date :";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(189, 415);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(475, 23);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate PDF of the order";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(184, 361);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(140, 25);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Total Price :";
            // 
            // lvwOrder
            // 
            this.lvwOrder.HideSelection = false;
            this.lvwOrder.Location = new System.Drawing.Point(189, 170);
            this.lvwOrder.Name = "lvwOrder";
            this.lvwOrder.Size = new System.Drawing.Size(475, 131);
            this.lvwOrder.TabIndex = 5;
            this.lvwOrder.UseCompatibleStateImageBehavior = false;
            // 
            // frmOrderDetails
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwOrder);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderDetails";
            this.Text = "Detail de la commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ListView lvwOrder;
    }
}