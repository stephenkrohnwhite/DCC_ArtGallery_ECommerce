using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtGallery_ECommerce.Models
{
    public class ProductSize
    {
        [Key]
        public int ProductSizeId { get; set; }

        public string Size { get; set; }
    }
}