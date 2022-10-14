using BookShowBLL.Services;
using BookShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MovieAppCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUsers")]//
        public IEnumerable<User> GetUsers()
        {
            return _userService.GetUser();
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            _userService.AddUser(user);
            return Ok("User created Successfully");
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int userId)
        {
            _userService.DeleteUser(userId);
            return Ok("User deleted Successfully");
        }

        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody]User user)
        {
            _userService.UpdateUser(user);
            return Ok("User Updated Successfully");
        }

        [HttpGet("GetUserById")]
        public User GetUserById(int userId)
        {
            return _userService.GetUserById(userId);
        }

    }
}
