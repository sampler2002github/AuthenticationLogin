using AuthenticationLogin.Data.Model;

namespace AuthenticationLogin.Data.Interface
{
    public interface IRole
    {
        bool AddRole(Role role);
        bool DeleteRole(int Id);
        bool UpdateRole(Role role);
        List<Role> GetAllRoles();
        Role GetRoleById(int Id);
    }
}
