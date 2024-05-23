using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chromatik.Classes
{
    public class Supplier
    {
        private int supplier_id;
        private string name;
        private string address;
        private string phone_number;
        private int npa;
        private string city;
        private string email;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public int Npa { get => npa; set => npa = value; }
        public string City { get => city; set => city = value; }
        public string Email { get => email; set => email = value; }
        public int Supplier_id { get => supplier_id; set => supplier_id = value; }

        public Supplier()
        {
        }

        public Supplier(string name, string address, string phone_number, int npa, string city, string email)
        {
            this.name = name;
            this.address = address;
            this.phone_number = phone_number;
            this.npa = npa;
            this.city = city;
            this.email = email;
        }
        public override string ToString()
        {    
            return $"Supplier_id : {supplier_id}, Name : {name}, Address : {address}, Phone_number : {phone_number}, Npa : {npa}, City : {city}, Email : {email}";
        }
        }
}
