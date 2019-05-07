using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChatApp.Models;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        // Get all messages : GET api/messages
        [HttpGet]
        public ActionResult<IEnumerable<String>> Get()
        {
            return new string[] { "Message1", "Message2", "Message3" };
        }


        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "A message";
        }
        //Create a chat message : POST api/messages


    }
}