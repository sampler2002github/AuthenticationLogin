using AuthenticationLogin.Data.Interface.IFeedback;
using AuthenticationLogin.Data.Model.Feedback;

namespace AuthenticationLogin.Data.Repositorys.FeedbackRepository
{
    public class FeedbackRepository : IFeedback
    {
        public readonly ApplicationDbContext _context;
        public FeedbackRepository(ApplicationDbContext context)
        {
            _context = context;       
        }
        public bool AddFeedBack(Feedback feedback)
        {
            try
            {
                _context.FeedBacks.Add(feedback);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteFeedBack(int Id)
        {
            try
            {
                var reg = _context.FeedBacks.Find(Id);
                _context.FeedBacks.Remove(reg);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }

        public List<Feedback> GetAllFeedbacks()
        {
            try
            {
                return _context.FeedBacks.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Feedback GetFeedbackById(int Id)
        {
            try
            {
                return _context.FeedBacks.Find(Id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateFeedBack(Feedback feedback)
        {
            try
            {
                _context.FeedBacks.Update(feedback);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
