using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [Route("GetOrder")]
        public async Task<IActionResult> GetOrder()
        {
            return Ok();
        }

        [HttpGet]
        [Route("GetOrderById")]
        public IActionResult GetOrderById([FromRoute] int? id)
        {
            if (id == null)
            {
                return BadRequest("The id is null");
            }
            else
            {
                return Ok();
            }
        }
        [HttpGet]
        [Route("GetOrderByQuery")]
        public async Task<IActionResult> GetOrderByQuery([FromQuery] int id,
                                                         [FromQuery] int orderId,
                                                         [FromQuery] int productId)
        {
            return Ok();
        }
    }
}
