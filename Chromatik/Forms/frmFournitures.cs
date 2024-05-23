using Chromatik.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Windows.Forms;
using Chromatik.Classes.Token;

namespace Chromatik.Forms
{
    
    public partial class frmFournitures : Form
    {
        private Dictionary<int, frmDetailsFourniture> detailCommandeMap;

        public frmFournitures()
        {
            InitializeComponent();
            InitializeDataGridView();
            detailCommandeMap = new Dictionary<int, frmDetailsFourniture>();
            Async();
    
        }
        private void InitializeDataGridView()
        {
            // Ajoutez une colonne de lien
            DataGridViewLinkColumn detailsColumn = new DataGridViewLinkColumn();
            detailsColumn.Name = "DetailsStock";
            detailsColumn.HeaderText = "Détails";
            detailsColumn.Text = "Voir Détails";
            detailsColumn.UseColumnTextForLinkValue = true;
            dgvStock.Columns.Add(detailsColumn);
        }
        private void dgvFournitures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvStock.Columns["DetailsStock"].Index && e.RowIndex >= 0)
            {
                int stockId = Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells["stock_id"].Value);

                frmDetailsFourniture detailCommandeForm;
                if (!detailCommandeMap.TryGetValue(stockId, out detailCommandeForm))
                {
                    detailCommandeForm = new frmDetailsFourniture(stockId);
                    detailCommandeMap[stockId] = detailCommandeForm;
                }

                detailCommandeForm.Show();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.ShowDialog();
        }
        public void Async()
        {
            try
            {
                IEnumerable<Stock> stock = null;
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                var consumeApi = client.GetAsync("stock");
                consumeApi.Wait();
                var data = consumeApi.Result;

                if (data.IsSuccessStatusCode)
                {
                    var response = data.Content.ReadAsStringAsync();
                    response.Wait();
                    stock = JsonConvert.DeserializeObject<IList<Stock>>(response.Result);
                    dgvStock.DataSource = stock;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
