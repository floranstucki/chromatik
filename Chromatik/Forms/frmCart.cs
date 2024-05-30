using Chromatik.Classes;
using Chromatik.Classes.Token;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
            dgvCart.Columns.Add("Type", "Type");
            dgvCart.Columns.Add("Name", "Name");
            dgvCart.Columns.Add("Quantity", "Quantity");
            dgvCart.Columns.Add("Unit Price", "Unit Price");

            DataGridViewLinkColumn detailsColumn = new DataGridViewLinkColumn();
            detailsColumn.Name = "Delete";
            detailsColumn.HeaderText = "Delete";
            detailsColumn.Text = "Delete From Cart";
            detailsColumn.UseColumnTextForLinkValue = true;
            dgvCart.Columns.Add(detailsColumn);

            autoResizeColumn();
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            init();
        }

        private void addElementDataGridView(string typeStock, string stockName, int quantities, double unitPrice)
        {
            string[] row = { typeStock, stockName, quantities.ToString(), unitPrice.ToString("F2") };
            dgvCart.Rows.Add(row);
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string status = "Pending";
            int user_id = Storage.getUser().Id;
            double total_amount = 0;
            string command = "{\"user_id\":" + user_id + ",\"command_details\":[";
            while (dgvCart.Rows.Count > 0)
            {
                DataGridViewRow row = dgvCart.Rows[0];
                Stock stock = Stock.loadStock().Find(s => s.Supply == row.Cells[1].Value.ToString());
                command += $"{{\"stock_id\":{stock.Stock_id},\"quantity\":{row.Cells[2].Value}}},";
                total_amount += Convert.ToInt32(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value);
                if (dgvCart.Rows.Count == 1)
                {
                    command = command.Substring(0, command.Length - 1) + "]}";
                }
                if (Stock.updateStockQuantity(stock.Stock_id, Convert.ToInt32(row.Cells[2].Value)))
                {
                    if (Cart.deleteCart(stock.Stock_id)) { dgvCart.Rows.RemoveAt(0); } else { MessageBox.Show("Problem with the cart", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Problem with the stock","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (Order.storeOrder(date, status, command, total_amount, user_id))
            {
                MessageBox.Show("Order has been placed successfully","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Order has not been placed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void autoResizeColumn()
        {
            for (int i = 0; i < dgvCart.Columns.Count; i++)
            {
                dgvCart.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["Delete"].Index)
            {
                int stockId = Stock.loadStock().Find(s => s.Supply == dgvCart.Rows[e.RowIndex].Cells[1].Value.ToString()).Stock_id;
                if (Cart.deleteCart(stockId))
                {
                    MessageBox.Show("Stock Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    init();
                }
            }
        }

        private void init()
        {
            dgvCart.Rows.Clear(); 
            List<Cart> cart = Cart.loadCarts();
            foreach (var item in cart)
            {
                if (item != null)
                {
                    Stock stock = Stock.loadStockById(item.Stock_id);
                    addElementDataGridView(stock.Type, stock.Supply, item.Quantity, stock.Price);
                }
            }
        }
    }
}
