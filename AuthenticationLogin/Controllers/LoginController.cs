using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AuthenticationLogin.Data.Model;
using AuthenticationLogin.Data;
using Microsoft.AspNetCore.Authorization; 

namespace TuesdayDemo.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly ApplicationDbContext _context;
        public LoginsController(IConfiguration config, ApplicationDbContext context)
        {
            _config = config;
            _context = context;
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == login.UserId && x.Password == login.Password);
            var roleid = _context.UserRoles.FirstOrDefault(x => x.UserId == user.Id);
            var rolename = _context.Roles.FirstOrDefault(x => x.Id == roleid.RoleId);
            if (user != null)
            {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                var claims = new[]
                {
                 new Claim(ClaimTypes.NameIdentifier, user.Email),
                 new Claim(ClaimTypes.Role,rolename.RoleName),
                };
                var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                    _config["Jwt:Audience"],
                    claims,
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: credentials
                    );
                return Ok(new { Token = new JwtSecurityTokenHandler().WriteToken(token),Role=rolename.RoleName});
            }

            return NotFound("User not found!");
        }

    }
}
