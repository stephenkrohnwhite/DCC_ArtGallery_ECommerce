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
        int CategoryId { get; set; }
        string Name { get; set; }
    }
}