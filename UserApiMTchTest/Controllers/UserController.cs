using Microsoft.AspNetCore.Mvc;
using UserApiMTchTest.Models;
using UserApiMTchTest.Services;
using System.Collections.Generic;

namespace UserApiMTchTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/api/users")]        
        public ActionResult<List<User>> GetUsers()
        {
            var users = _userService.GetUsers();
            return Ok(users);
        }
    }
}