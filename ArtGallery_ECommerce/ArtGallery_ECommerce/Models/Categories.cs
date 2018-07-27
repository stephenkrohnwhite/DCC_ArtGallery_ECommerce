using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtGallery_ECommerce.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}