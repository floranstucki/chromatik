﻿using Chromatik.Classes.Token;
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
    public class Favorite
    {
        private int id;
        private int user_id;
        private int stock_id;
        private DateTime created_at;

        public int User_id { get => user_id; set => user_id = value; }
        public int Stock_id { get => stock_id; set => stock_id = value; }
        public int Id { get => id; set => id = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }

        public static List<Favorite> loadFavoritesByUser()
        {

            try
            {
                IEnumerable<Favorite> favorite = null;
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header
                client.BaseAddress = new Uri("http://localhost:8000/api/");
                var consumeApi = client.GetAsync($"users/{Storage.getUser().Id}/favorites");
                consumeApi.Wait();
                var data = consumeApi.Result;
                if (data.IsSuccessStatusCode)

                {
                    var response = data.Content.ReadAsStringAsync();
                    response.Wait();
                    favorite = JsonConvert.DeserializeObject<IList<Favorite>>(response.Result);
                    return favorite.ToList();
                }
                return null;
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static bool storeFavorite(int id)
        {
            try
            {
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); //si on veut ajouter le token dans le header

                var consumeApi = client.PostAsJsonAsync($"users/{Storage.getUser().Id}/favorites", new
                {
                    stock_id = id
                });
                consumeApi.Wait();
                var data = consumeApi.Result;

                if (data.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        public static bool deleteFavoriteById(int id) {
            try
            {
                HttpClient client = new HttpClient();
                string contentType = "application/json";
                client.BaseAddress = new Uri("http://127.0.0.1:8000/api/");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Bearer {0}", Storage.token)); 
                var consumeApi = client.DeleteAsync($"users/{Storage.getUser().Id}/favorites/?stock_id={id}");
                consumeApi.Wait();
                var data = consumeApi.Result;

                if (data.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
