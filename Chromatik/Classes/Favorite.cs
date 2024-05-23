using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromatik.Classes
{
    internal class Favorite
    {
        private int id;
        private int user_id;
        private int stock_id;

        public int User_id { get => user_id; set => user_id = value; }
        public int Stock_id { get => stock_id; set => stock_id = value; }
        public int Id { get => id; set => id = value; }
    }
}
