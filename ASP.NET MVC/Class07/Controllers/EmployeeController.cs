using Class07.Models;
using Class07.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class07.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();


            var employee = new Employee
            {
                EmployeeId = 21,
                FirstName = "Aleksandar",
                LastName = "Gacovski",
                Salary = 1500,
                Position = Position.Junior
            };
            var employeeViewModel = new EmployeeViewModel()
            {
                EmployeeId = employee.EmployeeId,
                FullName = employee.FullName(),
                Position = Position.Junior
            }
        }
    }
}
