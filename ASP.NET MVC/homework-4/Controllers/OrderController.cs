using homework_3.Models;
using Microsoft.AspNetCore.Mvc;


namespace homework_3.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("OrderDetails/{id}")]
        public IActionResult GetOrderDetails(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            var person = new User
            {
                FirstName = "Aleksandar",
                LastName = "Gacovski",
                Address = "Kiro Dimuskov",
                Phone = 12345678
            };
            var order = new Order
            {
                Id = id,
                User = person,
                Pizza = "Vegetariana",
                Price = 510,
                Delivered = false
            };
            return View("OrderDetails",order);
        }
    }
}
