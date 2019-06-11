using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class Location
    {
        public Location()
        {
            User = new HashSet<User>();
        }

        public int Locationid { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? Zipcode { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
