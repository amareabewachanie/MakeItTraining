using System.Security.Cryptography.X509Certificates;
using EmployeeManagmentMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagmentMvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = new Guid(),
                    Company = new
                        Company
                        {
                            Id = new Guid(),
                            Address = "Megenagna, Addis Ababa",
                            Country = "Ethiopia",
                            Name = "MakeIt"
                        },
                    DateOfBirth = new DateTime(1992,01,19),
                    Name = "Amare Abewa",
                    Position = "Senior Software Enginner"
                },
                new Employee
                {
                    Id = new Guid(),
                    Company = new
                        Company
                        {
                            Id = new Guid(),
                            Address = "Megenagna, Addis Ababa",
                            Country = "Ethiopia",
                            Name = "MakeIt"
                        },
                    DateOfBirth = new DateTime(1992,01,19),
                    Name = "Amare Abewa Two",
                    Position = "Senior Software Enginner"
                }
            };
            return View(employees);
        }
    }
}
