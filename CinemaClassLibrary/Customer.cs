using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaClassLibrary
{
    public class Customer
    {
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Customer(String name, String phone, String email, String password)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Password = password;
        }
    }
}
