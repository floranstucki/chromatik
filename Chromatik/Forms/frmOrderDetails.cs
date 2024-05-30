using Chromatik.Classes;
using System;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmOrderDetails : Form
    {
        private int _noCommand;
        public frmOrderDetails(int no)
        {
            InitializeComponent();
            _noCommand = no;
            initializeListView();
            loadOrders();
            resizeLVW();
        }

        private void initializeListView()
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
        public void loadOrders()
        {
            Order order = Order.loadOrderById(_noCommand);
            lblDetails.Text += " n°" + order.Order_id;
            lblDate.Text += order.Date.ToString("dd.MM.yyyy");
            Stock.getStockFromCommand(lvwOrder, order.Command);

            lblPrice.Text += order.Total_amount + " CHF";
        }

        
    }
}
