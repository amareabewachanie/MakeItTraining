using DayThreeMvcWOEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace DayThreeMvcWOEF.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Index()
        {
            return View(Repository.Students);
        }
        public IActionResult Create() { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
           var success= Repository.AddStudent(student);
            if(success)
            {
                return View("Index");
            }
            return View();
        }
    }
}
