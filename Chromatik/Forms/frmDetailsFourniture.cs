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

namespace Chromatik.Forms
{
    public partial class frmDetailsFourniture : Form
    {
        private int stock_id;
        public frmDetailsFourniture(int _stock_id)
        {
            InitializeComponent();
           this.stock_id = _stock_id;
            Async();
        }


        private void frmDetailsFourniture_Load(object sender, EventArgs e)
        {
               
        }

        private void btnFavoris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aticle ajouté aux favoris !", "Réussite !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Async()
        {
            try
            {
                IEnumerable<Stock> stock = null;
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header
                
                var consumeApi = client.GetAsync($"stock/{stock_id}");
                consumeApi.Wait();
                var data = consumeApi.Result;

                if (data.IsSuccessStatusCode)
                {
                    var response = data.Content.ReadAsStringAsync();
                    response.Wait();
                    stock = JsonConvert.DeserializeObject<IList<Stock>>("["+response.Result+"]");
                    Stock test = stock.FirstOrDefault();
                    tbxFourniture.Text = test.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
