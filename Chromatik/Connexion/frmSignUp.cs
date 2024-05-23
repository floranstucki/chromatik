using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chromatik
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this functuion is used to reset all the fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    
                    ((TextBox)control).Clear();
                }
            }
        }

        /// <summary>
        /// register an user to the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            string contentType = "application/json";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var consumeApi = client.PostAsJsonAsync("register", new { 
                name = tbxName.Text, 
                first_name = tbxFirstName.Text,
                phone_number = tbxTelephone.Text,
                email = tbxEmail.Text,
                password = tbxPassword.Text,
                c_password = tbxConfirmation.Text
               
            });
            consumeApi.Wait();
            var data = consumeApi.Result;
            if (data.IsSuccessStatusCode)
            {
                MessageBox.Show("User registered successfully", "Success !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error while register User", "Error !");
            }
        }
        /// <summary>
        /// filters characters to numbers and "+" only
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
    }
}
