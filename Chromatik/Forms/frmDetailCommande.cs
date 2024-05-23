using Chromatik.Classes;
using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chromatik.Forms
{
    public partial class frmDetailCommande : Form
    {
        private int _noCommand;
        public frmDetailCommande(int no)
        {
            InitializeComponent();
            _noCommand = no;
            LoadOrders();
        }

            private void btnGenerate_Click(object sender, EventArgs e)
            {
                try
                {
                    HttpClient client = new HttpClient();
                    string contentType = "application/json";
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                    client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                    client.BaseAddress = new Uri("http://localhost:8000/api/");
                    var consumeApi = client.GetAsync($"orders/{_noCommand}/generate");
                    consumeApi.Wait();
                    var data = consumeApi.Result;
                    if (data.IsSuccessStatusCode)
                    {
                        var pdfData = data.Content.ReadAsByteArrayAsync().Result;

                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                            saveFileDialog.FilterIndex = 1;
                            saveFileDialog.RestoreDirectory = true;
                            saveFileDialog.FileName = $"Order_{_noCommand}.pdf";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string filePath = saveFileDialog.FileName;
                                File.WriteAllBytes(filePath, pdfData);
                                MessageBox.Show("PDF successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public void LoadOrders()
            {
                try
                {
                    IEnumerable<Order> order = null;
                    HttpClient client = new HttpClient();
                    string contentType = "application/json";
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                    client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header
                    client.BaseAddress = new Uri("http://localhost:8000/api/");
                    var consumeApi = client.GetAsync($"orders/{_noCommand}");
                    consumeApi.Wait();
                    var data = consumeApi.Result;
                    if (data.IsSuccessStatusCode)

                    {

                        var response = data.Content.ReadAsStringAsync();

                        response.Wait();


                        order = JsonConvert.DeserializeObject<IList<Order>>("["+response.Result+"]");
                        tbxCommande.Text = order.First().ToString();
                        lblDateCommande.Text += order.First().Date.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    }
}
