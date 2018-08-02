﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArtGallery_ECommerce.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Display(Name = "Tracking Number")]
        public string TrackingId { get; set; }

        public IEnumerable<Products> Purchase { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderTime { get; set; }

        [ForeignKey("OrderStatus")]
        public int StatusId { get; set; }

        [Display(Name = "Order Status")]
        public Status OrderStatus { get; set; }

        public IEnumerable<Status> StatusList { get; set; }

        [ForeignKey("Buyer")]
        public int CustomerId { get; set; }

        [Display(Name = "Customer")]
        public Customer Buyer { get; set; }
    }
}