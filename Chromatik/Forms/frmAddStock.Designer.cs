namespace Chromatik.Forms
{
    partial class frmAddStock
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.cmbSupplyType = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxBrand = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(82, 72);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(85, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Supply Name :";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(85, 202);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(41, 13);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(451, 202);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(86, 13);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Number to add : ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(451, 139);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Unit Price :";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(451, 69);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(54, 13);
            this.lblSupplier.TabIndex = 6;
            this.lblSupplier.Text = "Supplier : ";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(454, 265);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(252, 57);
            this.btnAddStock.TabIndex = 7;
            this.btnAddStock.Text = "Add to Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // cmbSupplyType
            // 
            this.cmbSupplyType.FormattingEnabled = true;
            this.cmbSupplyType.Location = new System.Drawing.Point(219, 69);
            this.cmbSupplyType.Name = "cmbSupplyType";
            this.cmbSupplyType.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplyType.TabIndex = 0;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(572, 66);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplier.TabIndex = 3;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(574, 200);
            this.nudNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 20);
            this.nudNumber.TabIndex = 6;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrice
            // 
            this.nudPrice.DecimalPlaces = 1;
            this.nudPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudPrice.Location = new System.Drawing.Point(574, 132);
            this.nudPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(119, 20);
            this.nudPrice.TabIndex = 5;
            this.nudPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(219, 131);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(121, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxBrand
            // 
            this.tbxBrand.Location = new System.Drawing.Point(219, 202);
            this.tbxBrand.Name = "tbxBrand";
            this.tbxBrand.Size = new System.Drawing.Size(121, 20);
            this.tbxBrand.TabIndex = 2;
            // 
            // frmAddStock
            // 
            this.AcceptButton = this.btnAddStock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 377);
            this.Controls.Add(this.tbxBrand);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbSupplyType);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStock";
            this.Text = "Stock to Add";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.ComboBox cmbSupplyType;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxBrand;
    }
}