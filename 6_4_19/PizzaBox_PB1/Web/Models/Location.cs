using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class Location
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
        public int Num { get; set; } = 0;
        public int Locationid { get; set; }
        [DisplayName("Street1")]
        [Required(ErrorMessage = "Street 1 cannot be blank")]
        public string Street1 { get; set; }
        [DisplayName("Street2")]
        public string Street2 { get; set; }
        [DisplayName("City")]
        [Required(ErrorMessage = "City cannot be blank")]
        public string City { get; set; }
        [DisplayName("State")]
        [Required(ErrorMessage = "State cannot be blank")]
        public string State { get; set; }
        [DisplayName("Country")]
        [Required(ErrorMessage = "Country cannot be blank")]
        public string Country { get; set; }
        public int? Zipcode { get; set; }
    }
}
