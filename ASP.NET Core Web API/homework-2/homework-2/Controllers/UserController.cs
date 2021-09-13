using homework_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            var firstUser = new User()
            {
                FirstName = "Viktor",
                LastName = "Jakovlev",
                Age = 31
            };
            var secondUser = new User()
            {
                FirstName = "Radmila",
                LastName = "Kocovska",
                Age = 27
            };
            var thirdUser = new User()
            {
                FirstName = "Bojan",
                LastName = "Zdravkovski",
                Age = 35
            };
            var users = new List<User>();
            users.Add(firstUser);
            users.Add(secondUser);
            users.Add(thirdUser);

            return Ok(users);
        }
        
        [HttpGet("GetUserByIndex/{index}")]
        public IActionResult GetUserByIndex([FromRoute] int index)                             
        {
            var userOne = new User()
            {
                FirstName = "Simeon",
                LastName = "Gacovski",
                Age = 11
            };
            var userTwo = new User()
            {
                FirstName = "Teona",
                LastName = "Gacovski",
                Age = 8   
            };
            var userThree = new User()
            {
                FirstName = "Vasil",
                LastName = "Barandovski",
                Age = 19
            };
            var users = new List<User>();
            users.Add(userOne);
            users.Add(userTwo);
            users.Add(userThree);

            if (index >= users.Count)
            {
                return NotFound("The user can not be found");
            }
            else
            { 
                if (users[index].Age >= 18)
                {
                    Console.WriteLine("The user is an adult");
                }
                return Ok(users[index]);
            }
        }
    }
}
