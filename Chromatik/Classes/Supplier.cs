using Chromatik.Classes.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using Newtonsoft.Json;
using System.Collections;

namespace Chromatik.Classes
{
    public class Supplier
    {
        private int supplier_id;
        private string name;
        private string address;
        private string phone_number;
        private string npa;
        private string city;
        private string email;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Npa { get => npa; set => npa = value; }
        public string City { get => city; set => city = value; }
        public string Email { get => email; set => email = value; }
        public int Supplier_id { get => supplier_id; set => supplier_id = value; }

        public Supplier()
        {
        }

        public Supplier(string name, string address, string phone_number, string npa, string city, string email)
        {
            this.name = name;
            this.address = address;
            this.phone_number = phone_number;
            this.npa = npa;
            this.city = city;
            this.email = email;
        }
        public override string ToString()
        {
            return $"Supplier_id : {supplier_id}, Name : {name}, Address : {address}, Phone_number : {phone_number}, Npa : {npa}, City : {city}, Email : {email}";
        }

        public static List<Supplier> LoadSuppliers()
        {
            try
            {
                IEnumerable<Supplier> supplier = null;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
                string contentType = "application/json";
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                var consumeApi = client.GetAsync("suppliers");
                consumeApi.Wait();
                var data = consumeApi.Result;
                if (data.IsSuccessStatusCode)
                {
                    var response = data.Content.ReadAsStringAsync();
                    response.Wait();
                    supplier = JsonConvert.DeserializeObject<IList<Supplier>>(response.Result);
                    return supplier.ToList();
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

        public static Supplier SupplierById(int id)
        {
            IEnumerable<Supplier> supplier = null;
            HttpClient client = new HttpClient();
            string contentType = "application/json";
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header
            client.BaseAddress = new Uri("http://localhost:8000/api/");
            var consumeApi = client.GetAsync($"suppliers/{id}");
            consumeApi.Wait();
            var data = consumeApi.Result;
            if (data.IsSuccessStatusCode)
            {
                var response = data.Content.ReadAsStringAsync();
                response.Wait();
                supplier = JsonConvert.DeserializeObject<IList<Supplier>>("[" + response.Result + "]");
                return supplier.First();

            }

            return null;
        }
        public static bool AddSupplier(Supplier supplier)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
                string contentType = "application/json";
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                var consumeApi = client.PostAsJsonAsync("suppliers", supplier);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
