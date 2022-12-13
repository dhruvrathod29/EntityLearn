using EntityLearn.Data;
using EntityLearn.Models;
using Microsoft.AspNetCore.Mvc;

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

    }
}
