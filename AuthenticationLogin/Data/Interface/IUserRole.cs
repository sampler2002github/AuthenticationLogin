using AuthenticationLogin.Data.Model;

namespace AuthenticationLogin.Data.Interface
{
    public interface IUserRole
    {
        bool AddUserRole(UserRole _userrole);
        bool DeleteUserRole(int Id);
        bool UpdateUserRole(UserRole _userrole);
        List<UserRole> GetAllUserRoles();
        UserRole GetUserRoleById(int Id);
    }
}
