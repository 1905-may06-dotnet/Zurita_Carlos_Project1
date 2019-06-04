using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Topping
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
        public int Numt { get; set; } = 0;
        public int Toppingid { get; set; }
        [DisplayName("Pizza")]
        [Required(ErrorMessage = "Pizza Id cannot be blank")]
        public int Tpizzaid { get; set; }
        [DisplayName("Topping")]
        public string Topping1 { get; set; }
    }
}
