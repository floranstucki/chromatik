using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromatik.Classes
{
    public class Cart
    {
        private int cart_id;
        private int user_id;
        private int product_id;
        private int quantity;

        public int User_id { get => user_id; set => user_id = value; }
        public int Product_id { get => product_id; set => product_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Cart_id { get => cart_id; set => cart_id = value; }
    }
}
