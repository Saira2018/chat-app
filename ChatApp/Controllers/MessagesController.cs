using System.Collections.Generic;
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

        // Create a chat message : POST api/message
        [HttpPost]
        public ActionResult<Message> Post( [FromBody] Message message )
        {
            return _messageService.CreateMessage( message.UserName, message.MessageBody );
        }

    }
}