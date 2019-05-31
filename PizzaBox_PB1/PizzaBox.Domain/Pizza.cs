using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Domain
{
    public class Pizza
    {
        public int Pizzaid { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public int Cost { get; set; }
        public int Porderid { get; set; }

        public List<string> Topping { get; set; }
    }
}
