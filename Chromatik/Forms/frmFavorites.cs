using Chromatik.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmFavorites : Form
    {
        public frmFavorites()
        {
            InitializeComponent();
            InitializeDataGridView();
            loadFavoritesByUser();
            autoResizeColumns(dgvFavorites);
        }

        private void InitializeDataGridView()
        {

            dgvFavorites.Columns.Add("Type", "Supply Type");
            dgvFavorites.Columns.Add("Name", "Supply Name");
            dgvFavorites.Columns.Add("Date", "In Favorites since");

            DataGridViewLinkColumn deleteLinkColumn = new DataGridViewLinkColumn();
            deleteLinkColumn.Name = "Delete";
            deleteLinkColumn.HeaderText = "Delete";
            deleteLinkColumn.Text = "Delete from favorites";
            deleteLinkColumn.UseColumnTextForLinkValue = true;
            dgvFavorites.Columns.Add(deleteLinkColumn);
        }

        private void loadFavoritesByUser()
        {
            List<Favorite> list = Favorite.loadFavoritesByUser();

            if (list != null)
            {
                foreach (Favorite fav in list)
                {
                    Stock stock = Stock.loadStockById(fav.Stock_id);
                    addElementToDataGridView(stock.Type, stock.Supply, fav.Created_at, fav.Stock_id);
                }
            }
            else
            {
                MessageBox.Show("You don't have favorites yet", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addElementToDataGridView(string typeFourniture, string nomFourniture, DateTime dateMiseEnFavori, int favoriteId)
        {
            int rowIndex = dgvFavorites.Rows.Add(typeFourniture, nomFourniture, dateMiseEnFavori.ToString("dd/MM/yyyy"));
            dgvFavorites.Rows[rowIndex].Tag = favoriteId; // Utiliser Tag pour stocker l'ID du favori
        }

        private void autoResizeColumns(DataGridView dataGridView)
        {
            int availableWidth = dataGridView.ClientSize.Width;

            if (dataGridView.Columns.Count == 0)
                return;

            int columnWidth = availableWidth / dataGridView.Columns.Count;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void dgvFavorites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int favoriteId = Convert.ToInt32(dgvFavorites.Rows[e.RowIndex].Tag);

                if (e.ColumnIndex == dgvFavorites.Columns["Delete"].Index)
                {
                    if (Favorite.deleteFavoriteById(favoriteId))
                    {
                        MessageBox.Show("Favorite deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvFavorites.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("An error occured while deleting the favorite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
