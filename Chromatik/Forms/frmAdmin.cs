using Chromatik.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chromatik.Forms
{
    public partial class frmAdmin : Form
    {
        private Dictionary<int, frmOrderDetails> detailCommandeMap;
        public frmAdmin()
        {
            detailCommandeMap = new Dictionary<int, frmOrderDetails>();
            InitializeComponent();
            fillGraphic();
            fillDataGridView();
        }
        private void fillGraphic()
        {
            chtSells.Series.Clear();
            chtSells.Series.Add("Sells");
            List<Order> orders = Order.loadOrders();
            foreach (Order order in orders)
            {
                Order o = Order.loadOrderById(order.Order_id);
                Console.WriteLine(o.Command);
                Command split = JsonConvert.DeserializeObject<Command>(o.Command);

                foreach (var item in split.command_details)
                {
                    Stock stock = Stock.loadStockById(item.stock_id);
                    double supplyValue = item.quantity;
                    Console.WriteLine(supplyValue + " " + stock);
                    string stockName = stock.Supply;
                    var existingPoint = chtSells.Series["Sells"].Points.FirstOrDefault(point => point.AxisLabel == stockName);

                    if (existingPoint != null)
                    {
                        existingPoint.YValues[0] += supplyValue;
                    }
                    else
                    {   DataPoint newPoint = new DataPoint
                        {
                            AxisLabel = stockName,
                            YValues = new double[] { supplyValue }
                        };
                        chtSells.Series["Sells"].Points.Add(newPoint);
                    }
                }
            }

        }

        private void fillDataGridView()
        {
            List<Order> orders = Order.loadOrders();
            dgvOrders.DataSource = orders;
            foreach (DataGridViewColumn column in dgvOrders.Columns)
            {
                if (column.Name != "Date" && column.Name != "Status" && column.Name != "Command" && column.Name != "DetailsOrder")
                {
                    column.Visible = false;
                }
            }
            DataGridViewLinkColumn detailsColumn = new DataGridViewLinkColumn();
            detailsColumn.Name = "DetailsOrder";
            detailsColumn.HeaderText = "Détails";
            detailsColumn.Text = "Voir Détails";
            detailsColumn.UseColumnTextForLinkValue = true;
            dgvOrders.Columns.Add(detailsColumn);
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOrders.Columns["DetailsOrder"].Index && e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.Rows[e.RowIndex].Cells["order_id"].Value);

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

