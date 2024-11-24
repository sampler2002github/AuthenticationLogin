using AuthenticationLogin.Data.Interface;
using AuthenticationLogin.Data.Model;

namespace AuthenticationLogin.Data.Repositorys
{
    public class UserRoleRepository : IUserRole
    {
        public readonly ApplicationDbContext _context;
        public UserRoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool AddUserRole(UserRole userRole)
        {
            try
            {
                _context.UserRoles.Add(userRole);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool DeleteUserRole(int Id)
        {
            try
            {
                var reg = _context.UserRoles.Find(Id);
                _context.UserRoles.Remove(reg);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<UserRole> GetAllUserRoles()
        {
            try
            {
                return _context.UserRoles.ToList();
            }
            catch (Exception)
            {
                return null;
            }

        }

        public UserRole GetUserRoleById(int Id)
        {
            try
            {
                return _context.UserRoles.Find(Id);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool UpdateUserRole(UserRole userRole)
        {
            try
            {
                _context.UserRoles.Update(userRole);
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
