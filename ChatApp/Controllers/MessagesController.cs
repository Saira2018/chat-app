using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatApp.Models;

namespace ChatApp.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private List<Message> _messages;

        public MessagesController()
        {
            //do something on startup
            _messages = new List<Message> {
                new Message {
                Id = 0,
                UserName = "Saira C",
                MessageBody = "Oh hi there"
                },
                new Message {
                    Id = 1,
                    UserName = "Saira C",
                    MessageBody = "How are you"
                },
                new Message {
                    Id = 2,
                    UserName = "Saira C",
                    MessageBody = "Hope all is well"
                },
             };
        }

        //Get all messages : GET api/messages
        [HttpGet]
        public ActionResult<IEnumerable<Message>> Get()
        {
            return _messages;
        }



        [HttpGet( "{id}" )]
        public ActionResult<Message> Get( int id )
        {
            //go through the _messages
            //select meatching message with id

            var matchingMessage = _messages.FirstOrDefault( message => id == message.Id );

            return matchingMessage;

        }


        //Create a chat message : POST api/messages
        // post to _message variable
        [HttpPost]
        public ActionResult<Message> Post ([FromBody] string _userName )
        {
            var IncomingUserName = _userName;
             
        }



    }
}