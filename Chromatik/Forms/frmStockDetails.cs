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
using Chromatik.Classes.Token;
using System.Collections;
using System.Net.Http.Json;

namespace Chromatik.Forms
{
    public partial class frmStockDetails : Form
    {
        private int stock_id;
        public frmStockDetails(int _stock_id)
        {
            InitializeComponent();
            this.stock_id = _stock_id;
            tbxFourniture.Text = Stock.LoadStockById(stock_id).ToString();
            checkFavorite();
        }


        private void btnFavorites_Click(object sender, EventArgs e)
        {
            int id = stock_id;
            if(btnFavorites.Text == "Delete from your favorites")
            {
                
                if (Favorite.DeleteFavoriteById(id))
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
            else { 
                
                if (Favorite.AddFavorite(id))
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

        private void checkFavorite() { 
            List<Favorite> favorites = Favorite.LoadFavoritesByUser();
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
    }
}
