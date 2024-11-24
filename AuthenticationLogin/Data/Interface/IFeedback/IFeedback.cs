using AuthenticationLogin.Data.Model.Feedback;

namespace AuthenticationLogin.Data.Interface.IFeedback
{
    public interface IFeedback
    {
        bool AddFeedBack(Feedback feedback);
        bool UpdateFeedBack(Feedback feedback);
        bool DeleteFeedBack(int Id);
        List<Feedback> GetAllFeedbacks();
        Feedback GetFeedbackById(int Id);
    }
}
