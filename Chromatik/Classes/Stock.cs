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
    public class Stock
    {
        private int stock_id;
        private string supply;
        private string brand;
        private string type;
        private double price;
        private int quantity;
        private int supplier_id;
        private DateTime date;

        public int Stock_id { get => stock_id; set => stock_id = value; }
        public string Supply { get => supply; set => supply = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Supplier_id { get => supplier_id; set => supplier_id = value; }
        public DateTime Date { get => date; set => date= value; }

        public Stock() { }

        public Stock(string supply, string brand, string type, double price, int quantity, int supplier_id)
        {
            this.supply = supply;
            this.brand = brand;
            this.type = type;
            this.price = price;
            this.quantity = quantity;
            this.supplier_id = supplier_id;
        }
        public override string ToString()
        {
            return $"Stock_id : {stock_id}, Supply : {supply}, Brand : {brand}, Type : {type}, Price : {price}, Quantity : {quantity}, Supplier_id : {supplier_id}";
        }

        public static List<Stock> loadStock()
        {
            try
            {
                IEnumerable<Stock> stock = null;
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                var consumeApi = client.GetAsync("stock");
                consumeApi.Wait();
                var data = consumeApi.Result;

                if (data.IsSuccessStatusCode)
                {
                    var response = data.Content.ReadAsStringAsync();
                    response.Wait();
                    stock = JsonConvert.DeserializeObject<IList<Stock>>(response.Result);
                    return stock.ToList();
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
        public static Stock loadStockById(int stock_id)
        {
            try
            {
                IEnumerable<Stock> stocks = null;
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
                    stocks = JsonConvert.DeserializeObject<IList<Stock>>("[" + response.Result + "]");
                    return stocks.FirstOrDefault();
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

        public static bool storeStock(Stock stock)
        {
            try
            {
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                var data = JsonConvert.SerializeObject(stock);
                var consumeApi = client.PostAsJsonAsync("stock", new{
                    supply = stock.Supply,
                    brand = stock.Brand,
                    type = stock.Type,
                    price = stock.Price,
                    quantity = stock.Quantity,
                    supplier_id = stock.Supplier_id});
                consumeApi.Wait();
                var res = consumeApi.Result;
                if (res.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public static bool updateStockQuantity(int id, int quantity)
        {
            try
            {
                IEnumerable<Stock> stock = null;
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                var consumeApi = client.GetAsync($"stock/{id}");
                consumeApi.Wait();
                var data = consumeApi.Result;
                if (data.IsSuccessStatusCode)
                {
                    var response = data.Content.ReadAsStringAsync();
                    response.Wait();
                    stock = JsonConvert.DeserializeObject<IList<Stock>>("[" + response.Result + "]");
                    int newQuantity = stock.First().Quantity - quantity;
                    var consumeApi2 = client.PutAsJsonAsync($"stock/{id}", new
                    {
                        quantity = newQuantity
                    });
                    consumeApi2.Wait();
                    var data2 = consumeApi2.Result;
                    if (data2.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Problem with the update", "Error !");
                        return false;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool updateStock(int id, Stock stock)
        {
            try
            {
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                var consumeApi = client.PutAsJsonAsync($"stock/{id}", new { 
                    
                    supply = stock.Supply,
                    brand = stock.Brand,
                    type = stock.Type,
                    price = stock.Price,
                    quantity = stock.Quantity,
                    supplier_id = stock.Supplier_id
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

        public static bool deleteStock(int stock_id)
        {
            try
            {
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                var consumeApi = client.DeleteAsync($"stock/{stock_id}");
                consumeApi.Wait();
                var res = consumeApi.Result;
                if (res.IsSuccessStatusCode)
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

        public static void getStockFromCommand(ListView lvw, string command)
        {
            Command split = JsonConvert.DeserializeObject<Command>(command);
            try
            {
                foreach (var details in split.command_details)
                {
                    Stock stock = Stock.loadStockById(details.stock_id);
                    double price = stock.Price * details.quantity;
                    lvw.Items.Add(new ListViewItem(new string[] { stock.Supply, details.quantity.ToString(), stock.Price.ToString() + " CHF", price.ToString() + " CHF" }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
