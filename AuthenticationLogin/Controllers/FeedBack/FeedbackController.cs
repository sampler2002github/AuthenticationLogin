using AuthenticationLogin.Data.Interface.IFeedback;
using AuthenticationLogin.Data.Model.Feedback;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationLogin.Controllers.FeedBack
{
    [Route("api/[Controller]")]
    [ApiController]
    public class FeedbackController : Controller
    {
        private readonly IFeedback _feedback;
        public FeedbackController(IFeedback feedback)
        {
                _feedback = feedback;
        }
        [HttpGet]
        [Route("GetAllFeedbacks")]
        public IActionResult GetAllFeedbacks()
        {
            return Ok(_feedback.GetAllFeedbacks());
        }
        [HttpGet]
        [Route("GetFeedbackById")]
        public IActionResult GetFeedbackById(int Id)
        {
            return Ok(_feedback.GetFeedbackById(Id));
        }
        [HttpPost]
        [Route("AddFeedBack")]
        public IActionResult AddFeedBack(Feedback feedBack)
        {
            return Ok(_feedback.AddFeedBack(feedBack));
        }
        [HttpPut]
        [Route("UpdateFeedBack")]
        public IActionResult UpdateFeedBack(Feedback feedback) 
        {
            return Ok(_feedback.UpdateFeedBack(feedback));   
        }
        [HttpDelete]
        [Route("DeleteFeedBack")]
        public IActionResult DeleteFeedBack(int Id) 
        {
        return Ok(_feedback.DeleteFeedBack(Id));
        }
    }
}
