using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EasyNetQ;

namespace rabbit.web.Controllers
{
    [Produces("application/json")]
    [Route("api/Order")]
    public class OrderController : Controller
    {
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]TeslaOrder order)
        {
            var messageBus = RabbitHutch.CreateBus("host=localhost");
            using(var publishChannel = messageBus..op)
            return Ok();
        }

        // POST api/values
        [HttpGet]
        public IActionResult Get([FromQuery]TeslaOrder order)
        {
            return Ok(new {id = 5 });
        }
    }
}