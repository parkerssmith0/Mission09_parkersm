using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_parkersm.Models
{
    public class Checkout
    {
        [Key]
        [BindNever]
        public int CheckoutId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a phone number:")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter an address:")]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required(ErrorMessage = "Please enter a city:")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state:")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a Country:")]
        public string  Country { get; set; }
    }
}
