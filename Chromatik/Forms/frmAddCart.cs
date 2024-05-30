using Chromatik.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chromatik
{
    public partial class frmAddCart : Form
    {
        public frmAddCart()
        {
            InitializeComponent();
            addType();
        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            Stock stock = Stock.loadStock().Find(s => s.Supply == cmbSupply.Text);
            Cart cart = Cart.loadCarts().Find(c => c.Stock_id == stock.Stock_id);
            if (cart == null)
            {
                if (Cart.storeCart(stock.Stock_id, (int)nudQuantity.Value))
                {
                    MessageBox.Show("Added to cart","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add to cart", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Cart.updateCart(cart.Cart_id, (int)nudQuantity.Value))
                {
                    MessageBox.Show("Added to cart", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to added to cart", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Stock> stocks = Stock.loadStock().FindAll(x => x.Type == cmbType.Text);
            cmbSupply.Items.Clear();
            foreach (Stock stock in stocks)
            {
                cmbSupply.Items.Add(stock.Supply);
            }
        }

        private void addType()
        {
            List<Stock> stocks = Stock.loadStock();
            foreach (Stock stock in stocks)
            {
                if (!cmbType.Items.Contains(stock.Type))
                {
                    cmbType.Items.Add(stock.Type);
                }
            }
        }

        private void cmbSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stock stock = Stock.loadStock().Find(s => s.Supply == cmbSupply.Text);
            nudQuantity.Maximum = stock.Quantity;
        }
    }
}
