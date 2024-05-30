using Chromatik.Classes;
using Chromatik.Classes.Token;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmOrderList : Form
    {
        private Dictionary<int, frmOrderDetails> detailCommandeMap;
        private int id;

        public frmOrderList()
        {
            InitializeComponent();
            id = Storage.getUser().Id;
            detailCommandeMap = new Dictionary<int, frmOrderDetails>();

            loadOrders();
            dgvOrder.CellContentClick += dgvCommande_CellContentClick;
            
        }


        private void dgvCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOrder.Columns["DetailsOrder"].Index && e.RowIndex >= 0)
            {
                // Get the order ID from the hidden column (if it exists in the data source)
                int orderId = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells["order_id"].Value);

                if (!detailCommandeMap.TryGetValue(orderId, out var detailCommandeForm))
                {
                    detailCommandeForm = new frmOrderDetails(orderId);
                    detailCommandeMap[orderId] = detailCommandeForm;
                }

                detailCommandeForm.Show();
            }
        }

        private void dgvCommande_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvOrder.Columns[e.ColumnIndex];
            dgvOrder.Sort(clickedColumn, ListSortDirection.Ascending);
        }

        public void loadOrders()
        {
            List<Order> orders = User.loadOrderByUser();
            if (orders.Count > 0)
            {

                var bindingList = new BindingList<Order>(orders);
                dgvOrder.DataSource = bindingList;

                foreach (DataGridViewColumn column in dgvOrder.Columns)
                {
                    if (column.Name != "Date" && column.Name != "Status" && column.Name != "Command" && column.Name != "DetailsCommande")
                    {
                        column.Visible = false;
                    }
                }
                // Add a link column for details
                DataGridViewLinkColumn detailsColumn = new DataGridViewLinkColumn();
                detailsColumn.Name = "DetailsOrder";
                detailsColumn.HeaderText = "Details";
                detailsColumn.Text = "See Details";
                detailsColumn.UseColumnTextForLinkValue = true;
                dgvOrder.Columns.Add(detailsColumn);
            }
            else
            {
                MessageBox.Show("You don't have an order !", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOrder.Columns["DetailsOrder"].Index && e.RowIndex >= 0)
            {
                // Get the order ID from the hidden column (if it exists in the data source)
                int orderId = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells["order_id"].Value);

                if (!detailCommandeMap.TryGetValue(orderId, out var detailCommandeForm) || detailCommandeForm.IsDisposed)
                {
                    detailCommandeForm = new frmOrderDetails(orderId);
                    detailCommandeMap[orderId] = detailCommandeForm;
                }

                detailCommandeForm.Show();
            }
        }
    }
}