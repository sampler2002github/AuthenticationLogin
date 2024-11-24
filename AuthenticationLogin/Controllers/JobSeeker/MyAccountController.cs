using AuthenticationLogin.Data.Interface.IJobSeeker;
using AuthenticationLogin.Data.Model.JobSeeker;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationLogin.Controllers.JobSeeker
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MyAccountController : Controller
    {
        private readonly IMyAccount _myAccount;
        public MyAccountController(IMyAccount myAccount)
        {
            _myAccount = myAccount;       
        }
        [HttpGet]
        [Route("GetAllMyAccounts")]
        public IActionResult GetAllMyAccounts()
        {
            return Ok(_myAccount.GetAllMyAccounts());
        }
        [HttpGet]
        [Route("GetMyAccountById")]
        public IActionResult GetMyAccountById(int Id) 
        {
            return Ok(_myAccount.GetMyAccountById(Id));
        }
        [HttpPost]
        [Route("AddMyAccount")]
        public IActionResult AddMyAccount(MyAccount myAccount) 
        {
        return Ok(_myAccount.AddMyAccount(myAccount));
        }
        [HttpPut]
        [Route("UpdateMyAccount")]
        public IActionResult UpdateMyAccount(MyAccount myAccount) 
        {
        return Ok(_myAccount.UpdateMyAccount(myAccount));
        }
        [HttpDelete]
        [Route("DeleteMyAccount")]
        public IActionResult DeleteMyAccount(int Id) 
        {
        return Ok(_myAccount.DeleteMyAccount(Id));
        }
    }
}
