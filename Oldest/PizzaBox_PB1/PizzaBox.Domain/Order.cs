using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class Order
    {
        public int Orderid { get; set; }
        public int Ocustomerid { get; set; }
        public DateTime? Datetime { get; set; }

        public List<Pizza> Pizza { get; set; }
    }
}
