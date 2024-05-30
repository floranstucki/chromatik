using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace Chromatik.Classes
{
    public class Cart
    {
        private int cart_id;
        private int user_id;
        private int stock_id;
        private int quantity;

        public int User_id { get => user_id; set => user_id = value; }
        public int Stock_id { get => stock_id; set => stock_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Cart_id { get => cart_id; set => cart_id = value; }

        public Cart() { }
        public static List<Cart> loadCarts()
        {

            try
            {
                IEnumerable<Cart> cart = null;
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                var consumeApi = client.GetAsync($"users/{Storage.getUser().Id}/carts");
                consumeApi.Wait();
                var data = consumeApi.Result;

                if (data.IsSuccessStatusCode)
                {
                    var response = data.Content.ReadAsStringAsync();
                    response.Wait();
                    cart = JsonConvert.DeserializeObject<IList<Cart>>(response.Result);
                    return cart.ToList();
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public static bool storeCart(int stockId, int quantites) {
            try
            {
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                var consumeApi = client.PostAsJsonAsync($"carts/", new { 
                    user_id = Storage.getUser().Id,
                    stock_id = stockId,
                    quantity = quantites
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public static bool updateCart(int id, int quantites) {
            Cart cart = loadCarts().Find(s => s.Cart_id == id);
            try
            {
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                var consumeApi = client.PutAsJsonAsync($"carts/{id}", new
                {
                    quantity = cart.Quantity + quantites
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool deleteCart(int stockid)
        {
            try
            {
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                var consumeApi = client.DeleteAsync($"users/{Storage.getUser().Id}/carts/{stockid}");
                consumeApi.Wait();
                var data = consumeApi.Result;
                if (data.IsSuccessStatusCode)
                {
                    return true;

                }
                else
                {
                    MessageBox.Show("Problem with the deletion", "Error !");
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
