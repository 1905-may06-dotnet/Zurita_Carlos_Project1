using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Pizza
    {
        //Data Annotations - UI Appearance of fields could be manipulate
        //- You can use them to validate the input data
        //[Required]
        //[Range]
        //[Max]
        //[Min]
        //[Compare]
        //[RegularExpression()]

        //- With EF Code First you can manage the types of the entities
        [DisplayName("#")]
        public int Nump { get; set; } = 0;
        public int Pizzaid { get; set; }
        [DisplayName("Size")]
        [Required(ErrorMessage = "Size cannot be blank")]
        public string Size { get; set; }
        [DisplayName("Crust")]
        [Required(ErrorMessage = "Crust cannot be blank")]
        public string Crust { get; set; }
        [DisplayName("Cost")]
        [Required(ErrorMessage = "Cost cannot be blank")]
        public int Cost { get; set; }
        [DisplayName("Order")]
        [Required(ErrorMessage = "Porderid cannot be blank")]
        public int Porderid { get; set; }
        [DisplayName("Topping 1")]
        [Required(ErrorMessage = "This topping selection cannot be blank")]
        public string ToppingN1 { get; set; }
        [DisplayName("Topping 2")]
        [Required(ErrorMessage = "This topping selection cannot be blank")]
        public string ToppingN2 { get; set; }
        [DisplayName("Topping 3")]
        public string ToppingN3 { get; set; }
        [DisplayName("Topping 4")]
        public string ToppingN4 { get; set; }
        [DisplayName("Topping 5")]
        public string ToppingN5 { get; set; }
    }
}
