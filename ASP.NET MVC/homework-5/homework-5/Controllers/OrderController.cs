using homework_5.Models;
using Microsoft.AspNetCore.Mvc;


namespace homework_5.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult NewOrder()
        {
            var newOrder = new NewOrderViewModel();
            return View(newOrder);
        }
        [HttpPost]
        public IActionResult NewOrder(NewOrderViewModel newOrder)
        {
            return RedirectToAction("Registered", "Home");
        }

    }
}
