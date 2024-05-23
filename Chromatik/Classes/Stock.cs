using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Supply { get => supply; set => supply = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Supplier_id { get => supplier_id; set => supplier_id = value; }
        public int Stock_id { get => stock_id; set => stock_id = value; }


        public override string ToString()
        {
            return $"Stock_id : {stock_id}, Supply : {supply}, Brand : {brand}, Type : {type}, Price : {price}, Quantity : {quantity}, Supplier_id : {supplier_id}";
        }
    }
}
