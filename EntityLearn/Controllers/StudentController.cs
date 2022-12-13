using EntityLearn.Data;
using EntityLearn.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

namespace EntityLearn.Controllers
{
    public class StudentController : Controller
    {
        private readonly ProductDbContext _db;
        

        public StudentController(ProductDbContext db)
        {
            _db = db;   
        }
        public IActionResult Index()
        {
            return View(_db.Students.ToList()) ;
        }
        public IActionResult Add()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Add(student);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
        
        public IActionResult Update(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");

            }
            Student student = _db.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(student);   
                _db.SaveChanges();  
                return RedirectToAction("Index");
            }
            return View(student);
        }
       public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");   
            }
            Student student = _db.Students.Find(id);
            _db.Students.Remove(student);   
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
