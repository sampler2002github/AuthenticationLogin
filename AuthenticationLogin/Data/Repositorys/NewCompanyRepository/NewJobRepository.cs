using AuthenticationLogin.Data.Interface.INewCompany;
using AuthenticationLogin.Data.Model.NewCompany;

namespace AuthenticationLogin.Data.Repositorys.NewCompanyRepository
{
    public class NewJobRepository : IPostNewJob
    {
        private readonly ApplicationDbContext _context;
        public NewJobRepository(ApplicationDbContext context)
        {
                _context=context;
        }
        public bool AddNewJob(PostNewJob newJob)
        {
            try
            {
                _context.NewJobs.Add(newJob);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
             return false;
            }
        }

        public bool DeleteNewJob(int Id)
        {
            try
            {
                var reg = _context.NewJobs.Find(Id);
                _context.NewJobs.Remove(reg);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }

        public List<PostNewJob> GetAllNewJobs()
        {
            try
            {
               return _context.NewJobs.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public PostNewJob GetNewJobById(int Id)
        {
            try
            {
                return _context.NewJobs.Find(Id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateNewJob(PostNewJob newJob)
        {
            try
            {
                _context.NewJobs.Update(newJob);
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
