using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkShop1._0.Models.Dto;
using WorkShop1._0.Services.Interfaces;

namespace WorkShop1._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController (IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("adduser")]
        public ActionResult<string> AddUser([FromBody]UserDto user)
        {
            try
            {
                var response = _userService.AddUser(user);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getallusers")]

        public ActionResult<List<UserDto>> GetAllUsers()
        {
            try
            {
                var response = _userService.GetAllUsers();
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("getuserbyid/{userId}")]

        public ActionResult<UserDto> GetUserById([FromRoute]int userId)
        {
            try
            {
                var response = _userService.GetUserById(userId);
                return Ok(response);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
    }
}
