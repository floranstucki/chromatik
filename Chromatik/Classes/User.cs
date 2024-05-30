using Chromatik.Classes;
using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace Chromatik
{
    public class User
    {
        private int id;
        private string name;
        private string first_name;
        private string phone_number;
        private string email;
        private string password;
        private string role;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        private string c_password { get; set; }
       public string Role { get => role; set => role = value ; }
        

        public User()
        {
            
        }

        public User(int id, string name, string first_name, string phone_number, string email,string role)
        {
            this.id = id;
            this.name = name;
            this.first_name = first_name;
            this.phone_number = phone_number;
            this.email = email;
            this.role = role;
        }

        public static List<User> loadUsers() {
            try
            {
                IEnumerable<User> users = null;
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                var consumeApi = client.GetAsync("users");
                consumeApi.Wait();
                var data = consumeApi.Result;

                if (data.IsSuccessStatusCode)
                {
                    var response = data.Content.ReadAsStringAsync();
                    response.Wait();
                    users = JsonConvert.DeserializeObject<IList<User>>(response.Result);
                    return users.ToList();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static bool registerUser(User user)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            string contentType = "application/json";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var consumeApi = client.PostAsJsonAsync("register", new { 
                name = user.Name,
                first_name = user.First_name,
                phone_number = user.Phone_number,
                email = user.Email,
                password = user.Password,
                c_password = user.password,
                role = ""
            });
            consumeApi.Wait();
            var data = consumeApi.Result;
            if (data.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool oginUser(string emailUser, string passwordUser) {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            string contentType = "application/json";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            var consumeApi = client.PostAsJsonAsync("login", new { email = emailUser, password = passwordUser});
            consumeApi.Wait();
            var data = consumeApi.Result;
            if (data.IsSuccessStatusCode)
            {
                var response = data.Content.ReadAsStringAsync();
                response.Wait();
                var res = JsonConvert.DeserializeObject<AccessToken>(response.Result);
                Storage.setToken(res.token);
                if (searchUser(emailUser))
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static bool searchUser(string email)
        {

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

                User user = loadUsers().Find(u => u.Email == email);
                if (user != null)
                {
                    if(user.Role != "manage")
                    {
                        user.Role = "view";
                    }
                    Storage.setUser(user);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static bool updateUser(User user)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Storage.token}");

                var consumeApi = client.PutAsJsonAsync($"users/{Storage.getUser().Id}", new { 
                    name = user.Name,
                    first_name = user.First_name,
                    phone_number = user.Phone_number,
                    email = user.Email,
                    password = user.Password
                });
                consumeApi.Wait();
                var data = consumeApi.Result;
                if (data.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static List<Order> loadOrderByUser() {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Storage.token}");

                var response = client.GetAsync($"users/{Storage.getUser().Id}/orders").Result;

                if (response.IsSuccessStatusCode)
                {
                    
                    var json = response.Content.ReadAsStringAsync().Result;
                    List<Order> orders = (List<Order>)JsonConvert.DeserializeObject<IList<Order>>(json);
                    return orders;

                    
                }
                return null;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
