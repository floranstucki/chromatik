using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmFavoris : Form
    {
        public frmFavoris()
        {
            InitializeComponent();

            AddElementToListView("Peinture", "Aquarelle", DateTime.Parse("26.3.2022"));
            AddElementToListView("Toile", "Lin", DateTime.Parse("24.08.2023"));
            AutoResizeColumns(lvwFavoris);
        }

        private void AddElementToListView(string typeFourniture, string nomFourniture, DateTime dateMiseEnFavori)
        {
            // Créez un nouvel élément ListViewItem avec les informations fournies
            ListViewItem item = new ListViewItem(typeFourniture);
            item.SubItems.Add(nomFourniture);
            item.SubItems.Add(dateMiseEnFavori.ToString("dd/MM/yyyy"));

            // Ajoutez l'élément à la ListView
            lvwFavoris.Items.Add(item);
        }

        private void AutoResizeColumns(ListView listView)
        {
            // Calculez la largeur disponible pour toutes les colonnes
            int availableWidth = listView.ClientSize.Width;

            // Vérifiez s'il y a des colonnes dans la ListView
            if (listView.Columns.Count == 0)
                return;

            // Divisez la largeur disponible également entre toutes les colonnes
            int columnWidth = availableWidth / listView.Columns.Count;

            // Définissez la largeur de chaque colonne
            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void lvwFavoris_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lvwFavoris.Sorting == SortOrder.Descending)
                lvwFavoris.Sorting = SortOrder.Ascending;
            else
                lvwFavoris.Sorting = SortOrder.Descending;
            lvwFavoris.Sort();
        }
    }
}
