using EmployeeManagmentMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagmentMvc.Controllers
{
    public class CompanyController : Controller
    {
        public List<Company> Companies = new List<Company>
            {
                new Company()
                {
                            Id = 1,

                            Address = "Megenagna, Addis Ababa",
                            Country = "Ethiopia",
                            Name = "MakeIt"
                },
                 new Company()
                {
                            Id = 2,

                            Address = "Megenagna, Addis Ababa",
                            Country = "Ethiopia",
                            Name = "MakeIt two"
                },
            };
        public IActionResult Index()
        {
           
            return View(Companies);
        }
        [HttpGet]
        public IActionResult Edit(int? id) { 
            var company=Companies.FirstOrDefault(x => x.Id == id);
           
            if(company != null)
            {
                var prevId = company.Id;
                Companies.Remove(company);
                Companies.Add(company);

                return View(company);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edit(Company company)
        {
            var companyToBeDeleted = Companies.FirstOrDefault(x => x.Id == company.Id);
            if (company != null)
            {
                var prevId = companyToBeDeleted.Id;
                Companies.Remove(companyToBeDeleted);
                company.Id = prevId;
                Companies.Add(company);
                return View("Index");
               
            }
            return View(company);

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(Companies.FirstOrDefault(a=>a.Id==id));
        }
        [HttpPost]
        public IActionResult Delete(Company company)
        {
            return View("Index");
        }
    }
}
