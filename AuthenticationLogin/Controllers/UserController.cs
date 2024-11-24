using AuthenticationLogin.Data.Interface;
using AuthenticationLogin.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationLogin.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            return Ok(_user.GetAllUsers());
        }
        [HttpGet]
        [Route("GetUserById")]
        public IActionResult GetUserById(int Id)
        {
            return Ok(_user.GetUserById(Id));
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(User User)
        {
            return Ok(_user.AddUser(User));
        }
        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(User User)
        {
            return Ok(_user.UpdateUser(User));
        }
        [HttpDelete]
        [Route("DeleteUser")]
        public IActionResult DeleteUser(int id)
        { 
         return Ok(_user.DeleteUser(id));
        }
    }
}
