using AuthenticationLogin.Data.Interface.IContactUs;
using AuthenticationLogin.Data.Model.ContactUs;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationLogin.Controllers.ContactUs
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ContactUsController : Controller
    {
        private readonly IContactUs _contactUs;
        public ContactUsController(IContactUs contactUs)
        {
                _contactUs = contactUs;
        }
        [HttpGet]
        [Route("GetAllDetails")]
        public IActionResult GetAllDetails()
        {
            return Ok(_contactUs.GetAllDetails());
        }
        [HttpGet]
        [Route("GetDetailById")]
        public IActionResult GetDetailById(int Id)
        {
            return Ok(_contactUs.GetDetailById(Id));
        }
        [HttpPost]
        [Route("AddDetail")]
        public IActionResult AddDetail(ModContactUS contactUs) 
        { 
        return Ok(_contactUs.AddDetail(contactUs));
        }
        [HttpPut]
        [Route("UpdateDetail")]
        public IActionResult UpdateDetail(ModContactUS contactUs)
        { 
         return Ok(_contactUs.UpdateDetail(contactUs));
        }
        [HttpDelete]
        [Route("DeleteDetail")]
        public IActionResult DeleteDetail(int Id)
        { 
        return Ok(_contactUs.DeleteDetail(Id));
        }
    }
}






