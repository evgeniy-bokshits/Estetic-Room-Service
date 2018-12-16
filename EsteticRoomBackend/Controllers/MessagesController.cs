using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EsteticRoomBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        static List<Models.Message> messages = new List<Models.Message> {
            new Models.Message
            {
                Owner = "John",
                Text = "Hello!"
            },
            new Models.Message
            {
                Owner = "Tim",
                Text = "Hi!"
            }
        };

        [HttpGet]
        public IEnumerable<Models.Message> Get()
        {
            return messages;
        }

        [HttpPost]
        public void Post([FromBody] Models.Message message)
        {
            messages.Add(message);
        }
    }
}