using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ArtGallery_ECommerce.Models;

namespace ArtGallery_ECommerce.Controllers
{
    public class StoreFrontController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: StoreFront
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                //change to show all?
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categories category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
    }
}