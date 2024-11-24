using AuthenticationLogin.Data.Interface.IJobSeeker;
using AuthenticationLogin.Data.Model.JobSeeker;

namespace AuthenticationLogin.Data.Repositorys.JobSeekerRepository
{
    public class MyAccountRepository : IMyAccount
    {
        private readonly ApplicationDbContext _context;
        public MyAccountRepository(ApplicationDbContext context)
        {
                _context = context;
        }
        public bool AddMyAccount(MyAccount myAccount)
        {
            try
            {
                _context.JSMyAccounts.Add(myAccount);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }

        public bool DeleteMyAccount(int Id)
        {
            try
            {
                var reg=_context.JSMyAccounts.Find(Id);
                _context.JSMyAccounts.Remove(reg);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false; 
            }
        }

        public List<MyAccount> GetAllMyAccounts()
        {
            try
            {
                return _context.JSMyAccounts.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public MyAccount GetMyAccountById(int Id)
        {
            try
            {
                return _context.JSMyAccounts.Find(Id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateMyAccount(MyAccount myAccount)
        {
            try
            {
                _context.JSMyAccounts.Update(myAccount);
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
