using Microsoft.AspNetCore.Mvc;

namespace EntityLearn.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();  
        }

    }
}
