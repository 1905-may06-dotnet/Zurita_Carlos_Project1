using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class User
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Ulocationid { get; set; }
        public List<Order> Orders { get; set; }
    }
}
