using Chromatik.Classes.Token;
using Chromatik.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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
            RemplirGraphique();
            RemplirDataGridView();

        }



        private void RemplirGraphique()
        {
            /*chtVente.Series.Clear(); 
            chtVente.Series.Add("Ventes"); 
            chtVente.Series["Ventes"].Points.AddXY("Gomme", 12);
            chtVente.Series["Ventes"].Points.AddXY("Crayon", 15); 
            chtVente.Series["Ventes"].Points.AddXY("Stylo", 13);
            chtVente.Series["Ventes"].Points.AddXY("Peinture", 11);
            chtVente.Series["Ventes"].Points.AddXY("Toile", 10);
            chtVente.Series["Ventes"].Points.AddXY("Pinceau", 16);
            chtVente.Series["Ventes"].Points.AddXY("Papier A4", 14);

            // Personnaliser l'apparence du diagramme
            chtVente.Series["Ventes"].ChartType = SeriesChartType.Pie; // Type de graphique en secteurs
            chtVente.Series["Ventes"]["PieLabelStyle"] = "Outside"; // Position des étiquettes
            chtVente.Series["Ventes"].IsValueShownAsLabel = true;
            chtVente.ChartAreas[0].Position.Width = 100; // Augmente la largeur de la zone de traçage (en pourcentage)
            chtVente.ChartAreas[0].Position.Height = 100;*/

            chtVente.Series.Clear();
            chtVente.Series.Add("¨Sells");
            List<Order> orders = Order.loadOrders();
            foreach (Order order in orders)
            {

            }

        }

        private void RemplirDataGridView()
        {
            List<Order> orders = Order.loadOrders();
            dgvOrders.DataSource = orders;

            // Optionally hide unwanted columns if they're automatically generated
            foreach (DataGridViewColumn column in dgvOrders.Columns)
            {
                if (column.Name != "Date" && column.Name != "Status" && column.Name != "Command" && column.Name != "DetailsOrder")
                {
                    column.Visible = false;
                }
            }
            // Add a link column for details
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

