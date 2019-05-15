using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Services
{
    public interface IMessageService
    {
        List<Message> GetAll();
        Message CreateMessage( string username, string messageContent );
        Message CreateUser( string newusername );
        List<Message> GetUsers( string username );
        Message Get( int id );
    }

    public class MessageService : IMessageService
    {
        private List<Message> _messages;

        int count = 2;

        public MessageService()
        {
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

        public List<Message> GetAll()
        {
            return _messages;
        }

        public Message Get (int id)
        {
            var matchingMessage = _messages.FirstOrDefault( message => id == message.Id );

            return matchingMessage;
        }

        public List<Message> GetUsers(string username)
        {

            //loop through an existing list of objects
            //extract the username property
            //store property values into a list of values
            //return that list 

            return _messages;
        }


        //make this so that you can pass body context into this method from the end point
     
        public Message CreateMessage(string username, string messageContent)
        {
            var newMessage = new Message {
                Id = ++count,
                //MessageBody = "added in controller",
                MessageBody = messageContent,
                UserName = username
            };

            _messages.Add(newMessage);

            return newMessage;
        }

        public Message CreateUser (string newusername )
        {
            var newUser = new Message {
                UserName = newusername
            };

            return newUser;
        }

    }
}
