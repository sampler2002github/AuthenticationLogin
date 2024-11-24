using AuthenticationLogin.Data.Interface;
using AuthenticationLogin.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationLogin.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserRoleController : Controller
    {
        private readonly IUserRole _userRole;
        public UserRoleController(IUserRole userRole)
        {
                _userRole = userRole;
        }
        [HttpGet]
        [Route("GetAllUserRoles")]
        public IActionResult GetAllUserRoles()
        {
            return Ok(_userRole.GetAllUserRoles());
        }
        [HttpGet]
        [Route("GetUserRoleById")]
        public IActionResult GetUserRoleById(int Id)
        {
            return Ok(_userRole.GetUserRoleById(Id));
        }

        [HttpPost]
        [Route("AddUserRole")]
        public IActionResult AddUserRole(UserRole userRole)
        {
            return Ok(_userRole.AddUserRole(userRole));
        }
        [HttpPut]
        [Route("UpdateUserRole")]
        public IActionResult UpdateUserRole(UserRole userRole)
        {
            return Ok(_userRole.UpdateUserRole(userRole));
        }
        [HttpDelete]
        [Route("DeleteUserRole")]
        public IActionResult DeleteUserRole(int Id)
        {
            return Ok(_userRole.DeleteUserRole(Id));
        }
    }
}
