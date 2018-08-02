using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ArtGallery_ECommerce.Models;

namespace ArtGallery_ECommerce.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Size);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name");
            ViewBag.ProductSizeId = new SelectList(db.ProductSize, "ProductSizeId", "Size");
            ImageViewModels product = new ImageViewModels();
            //product.SizeList = db.ProductSize.ToList();

            return View(product);
        }
        //public ActionResult Create()
        //{
        //    return View(new ImageViewModel());
        //}

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(HttpPostedFileBase file, [Bind(Include = "ProductId,Name,Artist,Price,InStock,Description,ProductSizeId,CategoryId")] Products products)
        //{
        //    try
        //    {
        //        if (file.ContentLength > 0)
        //        {
        //            string _FileName = Path.GetFileName(file.FileName);
        //            string _path = Path.Combine(Server.MapPath("~/Content"), _FileName);
        //            file.SaveAs(_path);
        //            products.FileImagePath = _path;
        //        }
        //        ViewBag.Message = "File Uploaded Successfully!!";
                
        //    }
        //    catch
        //    {
        //        ViewBag.Message = "File upload failed!!";
        //        return View();
        //    }
        //    if (ModelState.IsValid)
        //    {

        //        db.Products.Add(products);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name", products.CategoryId);
        //    ViewBag.ProductSizeId = new SelectList(db.ProductSize, "ProductSizeId", "Size", products.ProductSizeId);
        //    return View(/*products*/);
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ImageViewModels model)
        {
            var validImageTypes = new string[]
            {
        "image/gif",
        "image/jpeg",
        "image/pjpeg",
        "image/png"
            };

            //if (model.ImageUpload == null || model.ImageUpload.ContentLength == 0)
            //        {
            //            ModelState.AddModelError("ImageUpload", "This field is required");
            //        }
            //        else if (!validImageTypes.Contains(model.ImageUpload.ContentType))
            //        {
            //            ModelState.AddModelError("ImageUpload", "Please choose either a GIF, JPG or PNG image.
            //        }

            if (ModelState.IsValid)
            {
                var image = new Products();
                {
                  
                }

                if (model.ImageUpload != null && model.ImageUpload.ContentLength > 0)
                {
                    var uploadDir = "~/content/images";
                    var imagePath = Path.Combine(Server.MapPath(uploadDir), model.ImageUpload.FileName);
                    var imageUrl = Path.Combine(uploadDir, model.ImageUpload.FileName);
                    model.ImageUpload.SaveAs(imagePath);
                    image.FileImagePath = imageUrl;
                }
                image.Name = model.Name;
                image.Artist = model.Artist;
                image.Price = model.Price;
                image.InStock = model.InStock;
                image.Description = model.Description;
                image.CategoryId = model.CategoryId;
                image.Category = db.Categories.Where(c => c.CategoryId == image.CategoryId).First();
                image.ProductSizeId = model.ProductSizeId;
                image.Size = db.ProductSize.Where(s => s.ProductSizeId == image.ProductSizeId).First();
                db.Products.Add(image);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name", products.CategoryId);
            ViewBag.ProductSizeId = new SelectList(db.ProductSize, "ProductSizeId", "Size", products.ProductSizeId);
            return View(products);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,Name,Artist,Price,InStock,Description,ProductSizeId,CategoryId")] Products products)
        {
            if (ModelState.IsValid)
            {
                db.Entry(products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name", products.CategoryId);
            ViewBag.ProductSizeId = new SelectList(db.ProductSize, "ProductSizeId", "Size", products.ProductSizeId);
            return View(products);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.Products.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Products products = db.Products.Find(id);
            db.Products.Remove(products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
