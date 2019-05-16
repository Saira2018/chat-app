using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChatApp.Services
{

    public interface IUserService
    {
        List<User> getAll();
        User Get( int id );
        User CreateUser( string username );
    }

    public class UserService : IUserService
    {

        private List<User> _users;

        int count = 1;

        public UserService()
        {
            _users = new List<User> {
                new User {
                    id = 0,
                    UserName = "Merlin C"
                },
                new User {
                    id = 1,
                    UserName = "Mary P"
                }
            };

        }

        public List<User> getAll()
        {
            return _users;
        }

        public User Get (int id)
        {
            var matchingUser = _users.FirstOrDefault( user => id == user.id );

            return matchingUser;
        }

        public User CreateUser (string username)
        {
            var newUser = new User {
                id = ++count,
                UserName = username
            };

            _users.Add( newUser );

            return newUser;
        }


    }
}
