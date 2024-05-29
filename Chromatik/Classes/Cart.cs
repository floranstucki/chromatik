using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace Chromatik.Classes
{
    public class Cart
    {
        private int cart_id;
        private int user_id;
        private int product_id;
        private int quantity;

        public int User_id { get; set; }
        public int Stock_id { get; set; }
        public int Quantity { get; set; }
        public int Cart_id { get; set; }

        public Cart() { }
        public static List<Cart> LoadCart()
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


        public static bool AddToCart(int stockId, int quantites) {
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


        public static bool UpdateCart(int id, int quantites) {
            Cart cart = LoadCart().Find(s => s.Cart_id == id);
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
        public static bool deleteFromCart(int stockid)
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
