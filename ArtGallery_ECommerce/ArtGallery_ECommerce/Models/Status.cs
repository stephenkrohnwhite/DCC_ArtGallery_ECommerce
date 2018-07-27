using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtGallery_ECommerce.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string Name { get; set; }
    }
}