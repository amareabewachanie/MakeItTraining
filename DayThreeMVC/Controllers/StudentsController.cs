using DayThreeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DayThreeMVC.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentsController(ApplicationDbContext dbContext)
        {
            _dbContext= dbContext;
        }
        public IActionResult Index()
        {
            return View(_dbContext.Students.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Students.Add(student);
                _dbContext.SaveChanges();
                return View("Index", _dbContext.Students.ToList());
            }
           return View(student);
        }
        public IActionResult Details(int Id) {
            return View(_dbContext.Students.FirstOrDefault(a => a.Id == Id));
        }

        public IActionResult Edit(int Id)
        {
            return View(_dbContext.Students.FirstOrDefault(a => a.Id == Id));
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            _dbContext.Update(student);
            _dbContext.SaveChanges();
            return View("Index", _dbContext.Students.ToList());
        }



        public IActionResult Delete(int Id) {
            return View(_dbContext.Students.FirstOrDefault(a => a.Id == Id));
        }
        [HttpPost]
        public IActionResult Delete(Student student)
        {
            _dbContext.Remove(student);
            _dbContext.SaveChanges();
            return View("Index",_dbContext.Students.ToList());
        }
    }
}
