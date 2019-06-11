using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Order
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
        public int Numo { get; set; } = 0;
        public int Orderid { get; set; }
        [DisplayName("Customer")]
        [Required(ErrorMessage = "Customer Id cannot be blank")]
        public int Ocustomerid { get; set; }
        [DisplayName("Date Time")]
        public DateTime? Datetime { get; set; }
        [DisplayName("TotalCost")]
        public int totalordercostp { get; set; }
    }
}
