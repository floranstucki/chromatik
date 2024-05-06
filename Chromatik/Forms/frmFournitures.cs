using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmFournitures : Form
    {
        List<Tuple<string, string, string, double>> lstFourniture = new List<Tuple<string, string, string, double>>
        {
            new Tuple<string, string,string, double>("Gomme", "Fabercastell", "Blanche",2.5),
            new Tuple<string, string,string, double>("Crayon", "Caran d'ache", "Couleurs", 5.5),
            new Tuple<string, string,string, double>("Stylo", "BIC","Bleu", 1.5),
            new Tuple<string, string,string, double>("Peinture Aquarelle", "Caran d'Ache","Bleu", 12.5),
            new Tuple<string, string,string, double>("Toile en Lin", "Caran d'Ache","beige", 8.5)
        };
        bool _isAdmin = true;
        public frmFournitures()
        {
            InitializeComponent();
            RemplirDataGridView();
            if (_isAdmin)
            {
                btnAjouter.Visible = true;
            }
        }

        private void RemplirDataGridView()
        {
            // Ajouter des colonnes au DataGridView
            dgvFournitures.Columns.Add("Fourniture", "Fourniture");
            dgvFournitures.Columns.Add("Marque", "Marque");
            dgvFournitures.Columns.Add("Couleur", "Couleur");
            dgvFournitures.Columns.Add("Prix", "Prix");
            DataGridViewLinkColumn detailsColumn = new DataGridViewLinkColumn() { Name = "Détails", HeaderText = "Détails de la fourniture" };
            dgvFournitures.Columns.Add(detailsColumn);

            if(_isAdmin)
            {
                DataGridViewLinkColumn updateColumn = new DataGridViewLinkColumn() { Name = "Modifier", HeaderText = "Modifier la fourniture" };
                DataGridViewLinkColumn deleteColumn = new DataGridViewLinkColumn() { Name = "Supprimer", HeaderText = "Supprimer la fourniture" };

                dgvFournitures.Columns.Add(updateColumn);
                dgvFournitures.Columns.Add(deleteColumn);
            }
            

            // Définir AutoSizeColumnsMode sur Fill pour remplir automatiquement l'espace disponible
            dgvFournitures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ajouter des données à partir du code
            foreach (var fourniture in lstFourniture)
            {
                if (_isAdmin)
                {
                    AjouterLigne(fourniture.Item1, fourniture.Item2, fourniture.Item3, fourniture.Item4, new frmDetailsFourniture(fourniture), new frmUpdateStock(fourniture));
                }
                else {
                    AjouterLigne(fourniture.Item1, fourniture.Item2, fourniture.Item3, fourniture.Item4, new frmDetailsFourniture(fourniture), new frmUpdateStock(null));
                }           
                
            }
        }

        private void AjouterLigne(string fourniture, string marque, string couleur, double prix, frmDetailsFourniture frm, frmUpdateStock frmU)
        {
            // Ajouter une ligne au DataGridView
            int indexLigne = dgvFournitures.Rows.Add(fourniture, marque, couleur, prix);

            // Ajouter l'objet frm à la colonne "Détails" de la ligne ajoutée
            dgvFournitures.Rows[indexLigne].Cells["Détails"].Tag = frm;
            if (_isAdmin)
            {
                dgvFournitures.Rows[indexLigne].Cells["Modifier"].Tag = frmU; // Assurez-vous que frmUpdateStock est correctement passé ici
            }

            // Définir le texte du lien
            dgvFournitures.Rows[indexLigne].Cells["Détails"].Value = "Voir les détails";
            if(_isAdmin)
            {
                dgvFournitures.Rows[indexLigne].Cells["Modifier"].Value = "Modifier";
                dgvFournitures.Rows[indexLigne].Cells["Supprimer"].Value = "Supprimer";
            }
            
        }


        private void dgvFournitures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = dgvFournitures.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Vérifier si le clic est sur la colonne "Détails"
                if (cell.OwningColumn.Name == "Détails")
                {
                    frmDetailsFourniture frm = cell.Tag as frmDetailsFourniture;
                    frm?.Show();
                }
                // Vérifier si le clic est sur la colonne "Supprimer"
                else if (cell.OwningColumn.Name == "Modifier")
                {
                    frmUpdateStock frm = cell.Tag as frmUpdateStock;
                    frm?.Show();
                }
                else
                {
                    // Supprimer
                    if (MessageBox.Show("Voulez-vous vraiment supprimer cette fourniture ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dgvFournitures.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.ShowDialog();
        }
    }
}
