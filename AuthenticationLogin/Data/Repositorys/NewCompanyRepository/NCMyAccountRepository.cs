using AuthenticationLogin.Data.Interface.INewCompany;
using AuthenticationLogin.Data.Model.NewCompany;

namespace AuthenticationLogin.Data.Repositorys.NewCompanyRepository
{
    public class NCMyAccountRepository : INCMyAccount
    {
        private readonly ApplicationDbContext _context;
        public NCMyAccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool AddAccount(NCMyAccount myAccount)
        {
            try
            {
                _context.NCMyAccounts.Add(myAccount);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }

        public bool DeleteAccount(int Id)
        {
            try
            {
                var reg = _context.NCMyAccounts.Find(Id);
                _context.NCMyAccounts.Remove(reg);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                 return false;
            }
        }

        public NCMyAccount GetAccountById(int Id)
        {
            try
            {
                return _context.NCMyAccounts.Find(Id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<NCMyAccount> GetAllAccounts()
        {
            try
            {
                return _context.NCMyAccounts.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateAccount(NCMyAccount myAccount)
        {
            try
            {
                _context.NCMyAccounts.Update(myAccount);
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
