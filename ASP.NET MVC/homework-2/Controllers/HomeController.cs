using homework_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace homework_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var person = new Employee
            {
                EmployeeId = 23,
                FirstName = "Bodan",
                LastName = "Bojkovski",
                DateOfHire = new DateTime(2011, 12, 01),
                Position = Position.Junior,
                Salary = 1500.00
            };
            var branch = new Division
            {
                DivisionId = 10,
                Name = "Berovo",
                HeadOfDivision = person
            };

            var employeeDetailsModel = new EmployeeDetailsModel
            {
                
                EmployeeId = person.EmployeeId,
                FirstName = person.FirstName,
                LastName = person.LastName,
                FullName = person.GetFullName(),
                Position = person.Position,
                DateOfHire = person.DateOfHire.Date,
                Salary = person.Salary,
                DivisionId = branch.DivisionId,
                DivisionName = branch.Name
            };
            return View(employeeDetailsModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
