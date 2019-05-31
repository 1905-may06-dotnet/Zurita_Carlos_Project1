using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class Order
    {
        public Order()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int Orderid { get; set; }
        public int Ocustomerid { get; set; }
        public DateTime? Datetime { get; set; }

        public virtual User Ocustomer { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
