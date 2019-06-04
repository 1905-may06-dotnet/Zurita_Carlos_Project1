using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class User
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
        public int Numu { get; set; } = 0;
        public int Userid { get; set; }
        [DisplayName("Username")]
        [Required(ErrorMessage = "Username cannot be blank")]
        [Remote("IsAlreadyRegistered", "Location", HttpMethod = "POST", ErrorMessage = "Username already exists in database.")]
        public string Username { get; set; }
        [DisplayName("Username")]
        [Required(ErrorMessage = "Username cannot be blank")]
        public string Usernamein { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password cannot be blank")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Firstname cannot be blank")]
        public string Firstname { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Lastname cannot be blank")]
        public string Lastname { get; set; }
        [DisplayName("Location")]
        [Required(ErrorMessage = "Ulocationid cannot be blank")]
        public int Ulocationid { get; set; }
    }
}
