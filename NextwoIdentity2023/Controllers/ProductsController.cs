using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NextwoIdentity2023.Data;
using NextwoIdentity2023.Models;

namespace NextwoIdentity2023.Controllers
{
    public class ProductsController : Controller
    {
        private NextwoDbContext db;
        public ProductsController(NextwoDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View(db.Products.Include(x => x.Category));
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            var result = db.Products.Include(c=>c.Category).FirstOrDefault(p=>p.ProductId==id);
            if (result == null)
                return RedirectToAction("Index");
            return View(result);
        }


        [Authorize(Roles ="Admin")]
        public IActionResult Create()
        {
            ViewBag.CatList = new SelectList(db.Categories, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Product pro)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(pro);
                db.SaveChanges();
                return RedirectToAction("index");

            }
            return View(pro);
        }

        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult EditProduct(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            var result = db.Products.Find(id);
            ViewBag.CatList = new SelectList(db.Categories, "CategoryId", "CategoryName");
            if (result == null)
                return RedirectToAction("Index");
            return View(result);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult EditProduct(Product model)
        {
            if(ModelState.IsValid)
            {
                db.Products.Update(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult DeleteProduct(int? id)
        {
            if(id==null)
                return RedirectToAction("Index");
            var result=db.Products.Find(id);
            if(result==null)
                return RedirectToAction("Index");
            return View(result);
        }


        [HttpPost]
        public IActionResult DeleteProduct(Product model)
        {
            if(ModelState.IsValid)
            {
                db.Products.Remove(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        }
}
