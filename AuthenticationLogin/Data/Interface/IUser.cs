using AuthenticationLogin.Data.Model;

namespace AuthenticationLogin.Data.Interface
{
    public interface IUser
    {
        bool AddUser(User user);
        bool DeleteUser(int Id);
        bool UpdateUser (User user);
        List<User> GetAllUsers();
        User GetUserById(int Id);

    }
}
