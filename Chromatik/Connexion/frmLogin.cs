using System;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Http;
using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Chromatik
{
    public partial class frmLogin : Form
    {
    
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            string contentType = "application/json";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var consumeApi = client.PostAsJsonAsync("login", new { email = tbxEmail.Text, password = tbxPassword.Text });
            consumeApi.Wait();
            var data = consumeApi.Result;
            if (data.IsSuccessStatusCode)
            {
                var response = data.Content.ReadAsStringAsync();
                response.Wait();
                var res = JsonConvert.DeserializeObject<AccessToken>(response.Result);
                Storage.setToken(res.token);
                searchUser();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password","Error !");
            }
        }


        private void searchUser() { 
        
            HttpClient client = new HttpClient();
            string contentType = "application/json";
            client.BaseAddress = new Uri("http://localhost:8000/api/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var consumeApi = client.GetAsync("users");
            consumeApi.Wait();
            var data = consumeApi.Result;
            if (data.IsSuccessStatusCode)
            {
                var response = data.Content.ReadAsStringAsync();
                response.Wait();
                var users = JsonConvert.DeserializeObject<IEnumerable<User>>(response.Result);
                foreach (var user in users)
                {
                    if (user.Email == tbxEmail.Text)
                    {
                        User u = new User(user.Id,user.Name,user.First_name,user.Phone_number, user.Email);
                        Storage.setUser(u);
                        break;
                    }
                }
            }
            
        }
     
        

        private void llbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp frmSU = new frmSignUp();
            frmSU.ShowDialog();
        }
        private void llbForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmForgotPassword frmFP = new frmForgotPassword(tbxEmail.Text);
            frmFP.ShowDialog();
        }
    }
}




