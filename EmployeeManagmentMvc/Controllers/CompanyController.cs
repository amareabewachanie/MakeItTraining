using EmployeeManagmentMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagmentMvc.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            var companies= new List<Company>
            {
                new Company()
                {
                          Id = new Guid(),
                    
                            Address = "Megenagna, Addis Ababa",
                            Country = "Ethiopia",
                            Name = "MakeIt"
                },
            };
            return View(companies);
        }
    }
}
