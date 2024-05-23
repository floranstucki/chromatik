using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromatik
{
    public class User
    {
        private int id;
        private string name;
        private string first_name;
        private string phone_number;
        private string email;
        private string password;

        public string Name { get => name; set => name = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        public User()
        {
            
        }

        public User(int id, string name, string first_name, string phone_number, string email)
        {
            this.id = id;
            this.name = name;
            this.first_name = first_name;
            this.phone_number = phone_number;
            this.email = email;
        }
    }
}
