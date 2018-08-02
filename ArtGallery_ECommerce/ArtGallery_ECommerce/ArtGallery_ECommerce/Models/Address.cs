using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtGallery_ECommerce.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Display(Name = "Street Address")]
        public string SteetAddress { get; set; }

        public string City { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }


        [Required]
        [Display(Name = "State")]
        [RegularExpression("[A-Z]{2}")]
        public string State { get; set; }

        
    }
}