using Chromatik.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmAddStock : Form
    {
        public frmAddStock()
        {
            InitializeComponent();
        }

        private void clear()
        {
            tbxName.Text = "";
            tbxBrand.Text = "";
            cmbSupplyType.SelectedIndex = -1;
            cmbSupplier.SelectedIndex = -1;
            nudNumber.Value = 1;
            nudPrice.Value = 1;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (Stock.storeStock(new Stock(tbxName.Text, tbxBrand.Text, cmbSupplyType.Text, Convert.ToDouble(nudPrice.Value), Convert.ToInt32(nudNumber.Value), Supplier.loadSupplierById(cmbSupplier.SelectedIndex + 1).Supplier_id))) { 
                MessageBox.Show("Stock added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show("Stock not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            cmbSupplyType.Items.Add("Pen");
            cmbSupplyType.Items.Add("Pencil");
            cmbSupplyType.Items.Add("Paint");
            cmbSupplyType.Items.Add("Canvas");
            cmbSupplyType.Items.Add("Brush");
            List<Supplier> supplier = Supplier.loadSuppliers();
            foreach (Supplier suppliers in supplier)
            {
                cmbSupplier.Items.Add(suppliers.Name);
            }
        }
    }
}
