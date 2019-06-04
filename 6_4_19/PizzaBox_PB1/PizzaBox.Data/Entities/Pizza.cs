using System;
using System.Collections.Generic;

namespace PizzaBox.Data.Entities
{
    public partial class Pizza
    {
        public Pizza()
        {
            Topping = new HashSet<Topping>();
        }

        public int Pizzaid { get; set; }
        public string Size { get; set; }
        public string Crust { get; set; }
        public int Cost { get; set; }
        public int Porderid { get; set; }

        public virtual Order Porder { get; set; }
        public virtual ICollection<Topping> Topping { get; set; }
    }
}
