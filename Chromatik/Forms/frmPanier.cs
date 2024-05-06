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
    public partial class frmPanier : Form
    {
        public frmPanier()
        {
            InitializeComponent();
            AjouterElementToListView("Peinture", "Aquarelle", 2, 12.5);
            AjouterElementToListView("Toile", "Lin", 5, 8.5);
            AutoResizeColumns(lvwPanier);
        }

        private void AjouterElementToListView(string typeFourniture, string nomFourniture, int nb, double prixUnitaire)
        {
            // Créez un nouvel élément ListViewItem avec les informations fournies
            ListViewItem item = new ListViewItem(typeFourniture);
            item.SubItems.Add(nomFourniture);
            item.SubItems.Add(nb.ToString());
            item.SubItems.Add(prixUnitaire.ToString());

            // Ajoutez l'élément à la ListView
            lvwPanier.Items.Add(item);
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

        private void frmPanier_Load(object sender, EventArgs e)
        {
           
        }

        private void lvwPanier_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lvwPanier.Sorting == SortOrder.Descending)
                lvwPanier.Sorting = SortOrder.Ascending;
            else
                lvwPanier.Sorting = SortOrder.Descending;
            lvwPanier.Sort();
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            while (lvwPanier.Items.Count > 0)
            {
                lvwPanier.Items.RemoveAt(0);
            }
        }
    }
}
