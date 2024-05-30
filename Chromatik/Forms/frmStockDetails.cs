using Chromatik.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmStockDetails : Form
    {
        private int stock_id;
        public frmStockDetails(int _stock_id)
        {
            InitializeComponent();
            this.stock_id = _stock_id;
            initializeListView();
            fillListView();
            checkFavorite();
        }


        private void btnFavorites_Click(object sender, EventArgs e)
        {
            int id = stock_id;
            if (btnFavorites.Text == "Delete from your favorites")
            {

                if (Favorite.deleteFavoriteById(id))
                {
                    MessageBox.Show("Stock deleted from your favorites", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnFavorites.Text = "Add to your favorites";
                }
                else
                {
                    MessageBox.Show("Error with the deleting from favorites", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {

                if (Favorite.storeFavorite(id))
                {
                    MessageBox.Show("Stock added to your favorites", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnFavorites.Text = "Delete from your favorites";
                }
                else
                {
                    MessageBox.Show("Error with the adding to favorites", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkFavorite()
        {
            List<Favorite> favorites = Favorite.loadFavoritesByUser();
            if (favorites != null)
            {
                foreach (Favorite fav in favorites)
                {
                    if (fav.Stock_id == stock_id)
                    {
                        btnFavorites.Text = "Delete from your favorites";
                    }
                }
            }
        }
        private void initializeListView()
        {
            // Configurez les colonnes du ListView

            lvwStockDetails.Columns.Add("Supply", -2, HorizontalAlignment.Left);
            lvwStockDetails.Columns.Add("Brand", -2, HorizontalAlignment.Left);
            lvwStockDetails.Columns.Add("Type", -2, HorizontalAlignment.Left);
            lvwStockDetails.Columns.Add("Unit Price", -2, HorizontalAlignment.Left);
            lvwStockDetails.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            lvwStockDetails.Columns.Add("Supplier", -2, HorizontalAlignment.Left);
            lvwStockDetails.View = View.Details;

        }

        private void fillListView() {
            Stock stock = Stock.loadStockById(stock_id);
            if (stock != null)
            {
                ListViewItem item = new ListViewItem();
                item.Text = stock.Supply;
                item.SubItems.Add(stock.Brand);
                item.SubItems.Add(stock.Type);
                item.SubItems.Add(stock.Price.ToString());
                item.SubItems.Add(stock.Quantity.ToString());
                item.SubItems.Add(Supplier.loadSupplierById(stock.Supplier_id).Name);
                lvwStockDetails.Items.Add(item);
            }

        }
    }
}
