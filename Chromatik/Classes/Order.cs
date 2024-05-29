using Chromatik.Classes.Token;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Chromatik.Classes
{
    public class Order
    {
        private int order_id;
        private DateTime date;
        private string status;
        private string command;
        private double total_amount;
        private int user_id;

        public DateTime Date { get => date; set => date = value; }
        public string Status { get => status; set => status = value; }
        public string Command { get => command; set => command = value; }
        public double Total_amount { get => total_amount; set => total_amount = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int Order_id { get => order_id; set => order_id = value; }

        public Order() { }

        public override string ToString()
        {
            return "Order_id: " + order_id + "\r\n Status: " + status + "\r\n Command: " + command + "\r\n Total_amount: " + total_amount + "\r\n User_id: " + user_id;
        }
        public static List<Order> loadOrders()
        {
            try
            {
                IEnumerable<Order> stock = null;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Storage.token}");

                var response = client.GetAsync($"orders").Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    stock = JsonConvert.DeserializeObject<IList<Order>>(json);
                    return stock.ToList();
                }
                return null;
            }
            catch { return null; }
        }

        public static Order loadOrderById(int orderId)
        {
            try
            {
                IEnumerable<Order> order = null;
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Storage.token}");

                var response = client.GetAsync($"orders/{orderId}").Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    order = JsonConvert.DeserializeObject<IList<Order>>("[" + json + "]");
                    return order.First();
                }
                return null;
            }
            catch { return null; }
        }

        public static bool postOrder(DateTime dateOrder, string statusOrder, string commandOrder, double total, int userId)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
            string contentType = "application/json";
            client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
            Console.WriteLine(client.BaseAddress + "orders?date=" + dateOrder.ToString("yyyy-MM-dd") + "&status=" + statusOrder + "&command=" + JsonConvert.SerializeObject(commandOrder) + "&total_amount" + total + "&user_id=" + userId);
            var consumeApi = client.PostAsJsonAsync("orders", new
            {
                date = dateOrder.ToString("yyyy-MM-dd"),
                status = statusOrder,
                command = commandOrder,
                total_amount = total,
                user_id = userId
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

        public static void generatePDF(int command) {
            try
            {
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token));
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                var consumeApi = client.GetAsync($"orders/{command}/generate");
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
                        saveFileDialog.FileName = $"Order_{command}.pdf";

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
    }
}
