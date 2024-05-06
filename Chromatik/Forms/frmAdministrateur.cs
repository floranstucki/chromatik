using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chromatik.Forms
{
    public partial class frmAdministrateur : Form
    {
        public frmAdministrateur()
        {
            InitializeComponent();
            RemplirGraphique();
            RemplirDataGridView();
        }



        private void RemplirGraphique()
        {
            chtVente.Series.Clear(); 
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
            chtVente.ChartAreas[0].Position.Height = 100;
        }

        private void RemplirDataGridView()
        {
            // Ajouter des colonnes au DataGridView
            dgvCommandes.Columns.Add("DateCommande","Date de la commande");
            dgvCommandes.Columns.Add("Utilisateur", "Commande passée par");
            dgvCommandes.Columns.Add("NoCommande", "Numéro de commande");
            DataGridViewLinkColumn detailsColumn = new DataGridViewLinkColumn() { Name = "Détails", HeaderText = "Détails de la commande" };
            dgvCommandes.Columns.Add(detailsColumn);

            // Définir AutoSizeColumnsMode sur Fill pour remplir automatiquement l'espace disponible
            dgvCommandes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajouter des données à partir du code
            /*AjouterLigne(DateTime.Parse("27.05.2023"), "floran",1, new frmDetailCommande(DateTime.Now,1));
            AjouterLigne(DateTime.Parse("17.04.2023"), "damien",2 ,new frmDetailCommande(DateTime.Now,2));
            AjouterLigne(DateTime.Parse("02.03.2024"), "lorene",3, new frmDetailCommande(DateTime.Now,3));
            AjouterLigne(DateTime.Parse("30.06.2021"), "floran",4, new frmDetailCommande(DateTime.Now,4));
            AjouterLigne(DateTime.Parse("28.02.2022"), "felix",5, new frmDetailCommande(DateTime.Now,5));
            AjouterLigne(DateTime.Parse("21.01.2023"), "floran",6, new frmDetailCommande(DateTime.Now,6));*/

        }

        private void AjouterLigne(DateTime date, string User, int noCommande, frmDetailCommande frm)
        {
            // Ajouter une ligne au DataGridView
            int indexLigne = dgvCommandes.Rows.Add(date, User, noCommande);

            // Ajouter l'objet frm à la colonne "Détails" de la ligne ajoutée
            dgvCommandes.Rows[indexLigne].Cells["Détails"].Tag = frm;

            // Définir le texte du lien
            dgvCommandes.Rows[indexLigne].Cells["Détails"].Value = "Voir les détails";
            dgvCommandes.Rows[indexLigne].Cells[0].Style.Format = "dd/MM/yyyy";
        }

        private void dgvCommandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCommandes.Columns["Détails"].Index && e.RowIndex >= 0)
            {
                // Obtenir l'objet frmDetailsFourniture à partir de la cellule de la colonne "Détails"
                frmDetailCommande frm = dgvCommandes.Rows[e.RowIndex].Cells["Détails"].Tag as frmDetailCommande;

                // Afficher les détails de la fourniture
                frm?.Show();
            }
        }
    }
}
