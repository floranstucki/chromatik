using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
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
        }

        private async void frmDetailCommande_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(Properties.Resources.baseURL);

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    string url = $"orders/{_noCommand}/";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        MessageBox.Show(responseBody, "Données reçues", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxCommande.Text = responseBody;
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

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(Properties.Resources.baseURL);

                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    int orderId = 1; 

                    string url = $"orders/{orderId}/generate";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        using (var stream = await response.Content.ReadAsStreamAsync())
                        {
                            var path = $"C:\\Users\\Flo\\Downloads\\order_{orderId}.pdf";
                            using (var fileStream = File.Create(path))
                            {
                                await stream.CopyToAsync(fileStream);
                                MessageBox.Show("Le fichier PDF a été généré avec succès dans le dossier " + path, "Fichier PDF généré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
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
