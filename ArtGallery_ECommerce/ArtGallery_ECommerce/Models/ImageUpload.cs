using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArtGallery_ECommerce.Models
{
    public class ImageUploadViewModel
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
       
        [Display(Name = "Image path")]
        public string Contents { get; set; }
        public byte[] Image { get; set; }
        //public HttpPostedFileBase ImageFile { get; set; }
    }
}