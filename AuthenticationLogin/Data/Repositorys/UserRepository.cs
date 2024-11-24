using AuthenticationLogin.Data.Interface;
using AuthenticationLogin.Data.Model;

namespace AuthenticationLogin.Data.Repositorys
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool AddUser(User User)
        {
            try
            {
                _context.Users.Add(User);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<User> GetAllUsers()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public User GetUserById(int Id)
        {
            try
            {
                return _context.Users.Find(Id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DeleteUser(int Id)
        {
            try
            {
                var reg = _context.Users.Find(Id);
                _context.Users.Remove(reg);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateUser(User User)
        {
            try
            {
                _context.Users.Update(User);
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
