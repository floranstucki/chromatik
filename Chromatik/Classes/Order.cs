using Newtonsoft.Json;
using System;

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


        public override string ToString()
        {
            return "Order_id: " + order_id + "\r\n Status: " + status + "\r\n Command: " + command + "\r\n Total_amount: " + total_amount + "\r\n User_id: " + user_id;
        }
    }
}
