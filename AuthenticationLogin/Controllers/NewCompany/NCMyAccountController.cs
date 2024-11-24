using AuthenticationLogin.Data.Interface.INewCompany;
using AuthenticationLogin.Data.Model.NewCompany;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationLogin.Controllers.NewCompany
{
    [Route("api/[Controller]")]
    [ApiController]
    public class NCMyAccountController : Controller
    {
        private readonly INCMyAccount _myAccount;
        public NCMyAccountController(INCMyAccount myAccount)
        {
                _myAccount=myAccount;
        }

        [HttpGet]
        [Route("GetAllAccounts")]
        public IActionResult GetAllAccounts()
        {
            return Ok(_myAccount.GetAllAccounts());
        }
        [HttpGet]
        [Route("GetAccountById")]
        public IActionResult GetAccountById(int Id)
        {
            return Ok(_myAccount.GetAccountById(Id));
        }
        [HttpPost]
        [Route("AddAccount")]
        public IActionResult AddAccount(NCMyAccount newJob)
        {
            return Ok(_myAccount.AddAccount(newJob));
        }
        [HttpPut]
        [Route("UpdateAccount")]
        public IActionResult UpdateAccount(NCMyAccount myAccount)
        {
            return Ok(_myAccount.UpdateAccount(myAccount));
        }
        [HttpDelete]
        [Route("DeleteAccount")]
        public IActionResult DeleteAccount(int Id)
        {
            return Ok(_myAccount.DeleteAccount(Id));
        }
    }
}
