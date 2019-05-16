using System.Collections.Generic;
using ChatApp.Models;
using ChatApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController( IUserService userService )
        {
            _userService = userService;
        }


        //Get all users : GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUser()
        {
            return _userService.getAll ();
        }


        //Create a user : POST api/users
        [HttpPost]
        public ActionResult<User> CreateUser ([FromBody] User user )
        {
            return _userService.CreateUser( user.UserName );
        }

        //Get a single user : GET api/users/{id}
        [HttpGet( "{id}" )]
        public ActionResult<User> Get( int id )
        {
            return _userService.Get( id );
        }
    }
}