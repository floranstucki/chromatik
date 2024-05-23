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
using Chromatik.Classes;
using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Chromatik.Forms
{
    public partial class frmFournisseur : Form
    {
        public frmFournisseur()
        {
            InitializeComponent();
        }

        

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            string contentType = "application/json";
            client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var consumeApi = client.PostAsJsonAsync("suppliers", new { 
                name= tbxFournisseur.Text, 
                address = tbxAdresse.Text,
                phone_number = tbxTelephone.Text,
                npa = tbxNPA.Text,
                city = tbxVille.Text,
                email = tbxEmail.Text
            
            });
            consumeApi.Wait();
            var data = consumeApi.Result;
            if (data.IsSuccessStatusCode)
            {
                MessageBox.Show("Supplier added successfully", "Success !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password", "Error !");
            }
        }

        private void tbxNPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}
