using AuthenticationLogin.Data.Interface.INewCompany;
using AuthenticationLogin.Data.Model.NewCompany;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationLogin.Controllers.NewCompany
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PostNewJobController : Controller
    {
        private readonly IPostNewJob _newJob;
        public PostNewJobController(IPostNewJob newJob)
        {
                _newJob = newJob;
        }
        [HttpGet]
        [Route("GetAllNewJobs")]
        public IActionResult GetAllNewJobs()
        {
            return Ok(_newJob.GetAllNewJobs());
        }
        [HttpGet]
        [Route("GetNewJobById")]
        public IActionResult GetNewJobById(int Id)
        {
            return Ok(_newJob.GetNewJobById(Id));
        }
        [HttpPost]
        [Route("AddNewJob")]
        public IActionResult AddNewJob(PostNewJob newJob)
        {
            return Ok(_newJob.AddNewJob(newJob));
        }
        [HttpPut]
        [Route("UpdateNewJob")]
        public IActionResult UpdateNewJob(PostNewJob newJob)
        {
            return Ok(_newJob.UpdateNewJob(newJob));
        }
        [HttpDelete]
        [Route("DeleteNewJob")]
        public IActionResult DeleteNewJob(int Id)
        {
            return Ok(_newJob.DeleteNewJob(Id));
        }
    }
}
