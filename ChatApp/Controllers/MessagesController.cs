using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatApp.Models;
using ChatApp.Services;

namespace ChatApp.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private IMessageService _messageService;

        public MessagesController( IMessageService messageService )
        {
            _messageService = messageService;
        }

        //Get all messages : GET api/messages
        [HttpGet]
        public ActionResult<IEnumerable<Message>> Get()
        {
            return _messageService.GetAll();
        }

        // POST api/message
        [HttpPost]
        public ActionResult<Message> Post( [FromBody] Message message )
        {
            return _messageService.Create( message.UserName, message.MessageBody );
        }

        //Get all Users
        public ActionResult<IEnumerable<Message>> GetUser( [FromBody] Message message )
        {
            return _messageService.GetUsers( message.UserName );
        }

        //Create a User

        //get single user
        [HttpGet("{id}")]
        public ActionResult<Message> Get (int id)
        {
            return _messageService.Get(id);
        }



    }
}