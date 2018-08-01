using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArtGallery_ECommerce.Models
{
    public class ImageViewModels
    {
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        public string Artist { get; set; }

        public double Price { get; set; }

        [Display(Name = "Available")]
        public bool InStock { get; set; }

        public string Description { get; set; }

        [ForeignKey("Size")]
        public int ProductSizeId { get; set; }
        public IEnumerable<ProductSize> SizeList { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public IEnumerable<Categories> CategoriesList { get; set; }
        [Required]
        //public string Title { get; set; }

        //public string AltText { get; set; }

        //[DataType(DataType.Html)]
        //public string Caption { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}