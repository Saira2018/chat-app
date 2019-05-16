using ChatApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ChatApp.Services
{
    public interface IMessageService
    {
        List<Message> GetAll();
        Message CreateMessage( string username, string messageContent );
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


        public Message CreateMessage(string username, string messageContent)
        {
            var newMessage = new Message {
                Id = ++count,
                MessageBody = messageContent,
                UserName = username
            };

            _messages.Add(newMessage);

            return newMessage;
        }

    }
}
