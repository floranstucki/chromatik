﻿using Chromatik.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmUpdateStock : Form
    {
        
        private int id;
        public frmUpdateStock(int id)
        {
            InitializeComponent();
            init(id);
            
        }
      

        private void frmUpdateStock_Load(object sender, EventArgs e)
        {
            

            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            if (Stock.updateStock(id,new Stock(tbxSupply.Text, tbxBrand.Text, cmbStockType.Text, Convert.ToDouble(nudPrice.Value), Convert.ToInt32(nudQuantity.Value), Supplier.loadSupplierById(cmbSupplier.SelectedIndex + 1).Supplier_id))) { 
                
                MessageBox.Show("Stock Updated","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            this.Close();
        }

        private void init(int stock_id) {
            
            cmbStockType.Items.Add("Pen");
            cmbStockType.Items.Add("Pencil");
            cmbStockType.Items.Add("Paint");
            cmbStockType.Items.Add("Canvas");
            cmbStockType.Items.Add("Brush");
            id = stock_id;
            Stock stock = Stock.loadStockById(id);
            List<Supplier> suppliers = Supplier.loadSuppliers();
            tbxBrand.Text = stock.Brand;
            nudPrice.Text = stock.Price.ToString();
            nudQuantity.Text = stock.Quantity.ToString();
            tbxSupply.Text = stock.Supply;
            cmbStockType.Text = stock.Type;
            Supplier supplier = Supplier.loadSupplierById(stock.Supplier_id);
            cmbSupplier.Text = supplier.Name;
            foreach (Supplier supp in suppliers)
            {
                cmbSupplier.Items.Add(supp.Name);
            }
            if (cmbSupplier.Items.Count > 0 && supplier.Supplier_id > 0 && supplier.Supplier_id <= cmbSupplier.Items.Count)
            {
                cmbSupplier.SelectedIndex = supplier.Supplier_id - 1;
                Console.WriteLine(cmbSupplier.SelectedIndex);
            }
        }
    }
}
