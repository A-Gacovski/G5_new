using Microsoft.AspNetCore.Mvc;


namespace AppHomework.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("localhost:1111/User")]
        public IActionResult GetUser()
        {
            return View("User");
        }

        public IActionResult GetContact()
        {
            return RedirectToAction("Admin", "Admin");
        }

        [HttpGet("localhost:1111/Empty")]
        public IActionResult GetEmpty()
        {
            return new EmptyResult();
        }

        [HttpGet("localhost:1111/Id/{id}")]
        public IActionResult GetId(int id)
        {
            if (id == 2)
            {
                return RedirectToAction("GetEmpty");
            }
            else
            {
                return View("User");
            }
            
         
        }
        
    }
}
