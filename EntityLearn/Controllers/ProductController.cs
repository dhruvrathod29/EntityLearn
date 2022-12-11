using EntityLearn.Data;
using EntityLearn.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityLearn.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductDbContext _db;
        public ProductController(ProductDbContext db) 
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Products.ToList());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            if(ModelState.IsValid)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult Update(int id)
        {
            if(id == 0)
            {
                return RedirectToAction("Index");
            }
            Product product = _db.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Update(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            if(id == 0)
            {
                return RedirectToAction("Index");
            }
            Product product = _db.Products.Find(id);
            _db.Products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
