using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtGallery_ECommerce.Models
{
    public class Employee
    {
        [Key]
        int EmployeeID { get; set; }
        string UserID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}