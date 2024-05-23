using Chromatik.Classes;
using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chromatik.Forms
{
    public partial class frmListCommandes : Form
    {
        private Dictionary<int, frmDetailCommande> detailCommandeMap;
        private int id;
        public frmListCommandes()
        {
            InitializeComponent();
            id = Storage.getUser().Id;
            Async();
            detailCommandeMap = new Dictionary<int, frmDetailCommande>();
            dgvOrder.CellContentClick += dgvCommande_CellContentClick;

        }

        private void InitializeDataGridView()
        {
            // Ajoutez une colonne de lien
            DataGridViewLinkColumn detailsColumn = new DataGridViewLinkColumn();
            detailsColumn.Name = "DetailsCommande";
            detailsColumn.HeaderText = "Détails";
            detailsColumn.Text = "Voir Détails";
            detailsColumn.UseColumnTextForLinkValue = true;
            dgvOrder.Columns.Add(detailsColumn);
        }

        private void dgvCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOrder.Columns["DetailsCommande"].Index && e.RowIndex >= 0)
            {
                // Obtenez l'ID de la commande à partir de la ligne cliquée
                int orderId = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells["order_id"].Value);

                frmDetailCommande detailCommandeForm;
                if (!detailCommandeMap.TryGetValue(orderId, out detailCommandeForm))
                {
                    // Si le formulaire de détail n'existe pas dans le dictionnaire, créez-en un nouveau
                    detailCommandeForm = new frmDetailCommande(orderId);
                    detailCommandeMap[orderId] = detailCommandeForm;
                }

                detailCommandeForm.Show();
            }
        }

        private void dgvCommande_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn clickedColumn = dgvOrder.Columns[e.ColumnIndex];

            dgvOrder.Sort(clickedColumn, ListSortDirection.Ascending);

        }

        public void Async()
        {
            try
            {
                IEnumerable<Order> order = null;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                var consumeApi = client.GetAsync($"users/{id}/orders");
                consumeApi.Wait();
                var data = consumeApi.Result;

                if (data.IsSuccessStatusCode)
                {
                    InitializeDataGridView();
                    var response = data.Content.ReadAsStringAsync();
                    response.Wait();

                    order = JsonConvert.DeserializeObject<IList<Order>>(response.Result);

                    dgvOrder.DataSource = order;

                    // Assurez-vous que la colonne ID de la commande est incluse dans le DataGridView
                    if (!dgvOrder.Columns.Contains("order_id"))
                    {
                        dgvOrder.Columns.Add("OrderId", "ID de la Commande");
                    }
                }
                else { 
                    MessageBox.Show("Vous n'avez aucune commande !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
