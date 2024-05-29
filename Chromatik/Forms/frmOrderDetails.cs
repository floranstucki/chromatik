using Chromatik.Classes;
using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chromatik.Forms
{
    public partial class frmOrderDetails : Form
    {
        private int _noCommand;
        public frmOrderDetails(int no)
        {
            InitializeComponent();
            _noCommand = no;
            InitializeListView();
            LoadOrders();
            resizeLVW();
        }

        private void InitializeListView()
        {
            // Configurez les colonnes du ListView

            lvwOrder.Columns.Add("Supply", -2, HorizontalAlignment.Left);
            lvwOrder.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            lvwOrder.Columns.Add("Unit Price", -2, HorizontalAlignment.Left);
            lvwOrder.Columns.Add("Total Price", -2, HorizontalAlignment.Left);
            lvwOrder.View = View.Details;

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Order.generatePDF(_noCommand);
        }

        private void resizeLVW()
        {
            int columnCount = lvwOrder.Columns.Count;
            if (columnCount == 0)
                return;

            // Calcul de la largeur de chaque colonne
            int totalWidth = lvwOrder.ClientSize.Width;
            int columnWidth = totalWidth / columnCount;

            // Ajustement de la largeur des colonnes
            foreach (ColumnHeader column in lvwOrder.Columns)
            {
                column.Width = columnWidth;
            }

        }
        public void LoadOrders()
        {
            Order order = Order.loadOrderById(_noCommand);
            lblDetails.Text += " n°" + order.Order_id;
            lblDate.Text += order.Date.ToString("dd.MM.yyyy");
            Stock.getStockFromCommand(lvwOrder, order.Command);
            lblPrice.Text += order.Total_amount + " CHF";
        }

        
    }
}
