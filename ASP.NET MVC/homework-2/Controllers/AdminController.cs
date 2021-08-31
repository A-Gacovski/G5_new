using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppHomework.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View("Admin");
        }
    }
}
