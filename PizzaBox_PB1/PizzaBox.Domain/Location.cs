using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class Location
    {
        public int Locationid { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? Zipcode { get; set; }

        public List<User> Users { get; set; }
    }
}
