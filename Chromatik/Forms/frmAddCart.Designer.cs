namespace Chromatik
{
    partial class frmAddCart
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblSupply = new System.Windows.Forms.Label();
            this.cmbSupply = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(177, 34);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(69, 42);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type :";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(177, 144);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 2;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(69, 151);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(176, 189);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(121, 23);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblSupply
            // 
            this.lblSupply.AutoSize = true;
            this.lblSupply.Location = new System.Drawing.Point(69, 93);
            this.lblSupply.Name = "lblSupply";
            this.lblSupply.Size = new System.Drawing.Size(45, 13);
            this.lblSupply.TabIndex = 6;
            this.lblSupply.Text = "Supply :";
            // 
            // cmbSupply
            // 
            this.cmbSupply.FormattingEnabled = true;
            this.cmbSupply.Location = new System.Drawing.Point(177, 85);
            this.cmbSupply.Name = "cmbSupply";
            this.cmbSupply.Size = new System.Drawing.Size(121, 21);
            this.cmbSupply.TabIndex = 1;
            this.cmbSupply.SelectedIndexChanged += new System.EventHandler(this.cmbSupply_SelectedIndexChanged);
            // 
            // frmAddCart
            // 
            this.AcceptButton = this.btnAddToCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 237);
            this.Controls.Add(this.lblSupply);
            this.Controls.Add(this.cmbSupply);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddCart";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblSupply;
        private System.Windows.Forms.ComboBox cmbSupply;
    }
}