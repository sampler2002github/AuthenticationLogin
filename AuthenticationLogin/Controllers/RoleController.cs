using AuthenticationLogin.Data.Interface;
using AuthenticationLogin.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationLogin.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class RoleController : Controller
    {
        private readonly IRole _role;
        public RoleController(IRole role) 
        { 
          _role = role;
        }

        [HttpGet]
        [Route("GetAllRoles")]
        public IActionResult GetAllRoles()
        {
            return Ok(_role.GetAllRoles());
        }
        [HttpGet]
        [Route("GetUserById")]
        public IActionResult GetUserById(int Id)
        {
            return Ok(_role.GetRoleById(Id));
        }
        [HttpPost]
        [Route("AddRole")]
        public IActionResult AddRole(Role role)
        { 
        return Ok(_role.AddRole(role));
        }
        [HttpPut]
        [Route("UpdateRole")]
        public IActionResult UpdateRole(Role role)
        {
            return Ok(_role.UpdateRole(role));
        }
        [HttpDelete]
        [Route("DeleteRole")]
        public IActionResult DeleteRole(int Id) 
        {
            return Ok(_role.DeleteRole(Id));
        }
    }
}
