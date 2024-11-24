using AuthenticationLogin.Data.Interface.IContactUs;
using AuthenticationLogin.Data.Model.ContactUs;

namespace AuthenticationLogin.Data.Repositorys.ContactUsRepository
{
    public class ContactUsRepository : IContactUs
    {
        private readonly ApplicationDbContext _context;
        public ContactUsRepository(ApplicationDbContext context)
        {
                _context=context;
        }
        public bool AddDetail(ModContactUS contactUs)
        {
            try
            {
                _context.ContactUs.Add(contactUs);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }

        public bool DeleteDetail(int Id)
        {
            try
            {
                var reg = _context.ContactUs.Find(Id);
                _context.ContactUs.Remove(reg);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }

        public List<ModContactUS> GetAllDetails()
        {
            try
            {
                return _context.ContactUs.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ModContactUS GetDetailById(int Id)
        {
            try
            {
                return _context.ContactUs.Find(Id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateDetail(ModContactUS contactUs)
        {
            try
            {
                _context.ContactUs.Update(contactUs);
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
