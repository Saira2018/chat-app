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
        Message Create( string username );
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

        public Message Create(string username)
        {
            var newMessage = new Message {
                Id = ++count,
                MessageBody = "added in controller",
                UserName = username
            };

            _messages.Add(newMessage);

            return newMessage;
        }
    }
}
