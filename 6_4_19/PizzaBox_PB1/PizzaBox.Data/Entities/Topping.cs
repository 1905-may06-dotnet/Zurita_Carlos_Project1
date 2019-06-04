using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class Topping
    {
        public int Toppingid { get; set; }
        public int Tpizzaid { get; set; }
        public string Topping1 { get; set; }

        public virtual Pizza Tpizza { get; set; }
    }
}
