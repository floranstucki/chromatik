using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chromatik.Forms
{
    public partial class frmListCommandes : Form
    {
        private Dictionary<int, frmDetailCommande> detailCommandeMap;

        public frmListCommandes()
        {
            InitializeComponent();
            detailCommandeMap = new Dictionary<int, frmDetailCommande>();
            //RemplirDataGridView();

        }
        private void RemplirDataGridView(string response) {
            dgvCommande.Columns.Add("DateCommande", "Date de commande");
            dgvCommande.Columns.Add("NoCommande", "Numéro de commande");
            dgvCommande.Columns.Add(new DataGridViewLinkColumn() { Name = "DetailsCommande", HeaderText = "Détails de la commande" });
            dgvCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            String[] strings = response.Split(',');
            for (int i = 0; i < strings.Length; i++)
            {
                String[] values = strings[i].Split(',');
                AjouterLigne(DateTime.Parse(values[0]), int.Parse(values[1]), new frmDetailCommande(int.Parse(values[1])));
            }
        }

        private void AjouterLigne(DateTime valeurColonne1, int valeurColonne2, frmDetailCommande valeurColonne3)
        {
            int indexLigne = dgvCommande.Rows.Add(valeurColonne1, valeurColonne2, "Détails");

            detailCommandeMap[indexLigne] = valeurColonne3;
        }


        private void dgvCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCommande.Columns["DetailsCommande"].Index && e.RowIndex >= 0)
            {
                frmDetailCommande detailCommandeForm;
                if (detailCommandeMap.TryGetValue(e.RowIndex, out detailCommandeForm))
                {
                    detailCommandeForm?.Show();
                }
            }
        }

        private void dgvCommande_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvCommande.Columns[e.ColumnIndex];

            dgvCommande.Sort(clickedColumn, ListSortDirection.Ascending);

        }

        private async void frmListCommandes_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(Properties.Resources.baseURL);

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync("/orders");

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        MessageBox.Show(responseBody, "Données reçues", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RemplirDataGridView(responseBody);
                    }
                    else
                    {
                        MessageBox.Show($"Erreur : {response.StatusCode}", "Erreur de requête", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
