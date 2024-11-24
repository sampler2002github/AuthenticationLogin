using AuthenticationLogin.Data.Model.JobSeeker;

namespace AuthenticationLogin.Data.Interface.IJobSeeker
{
    public interface IMyAccount
    {
        bool AddMyAccount (MyAccount myAccount);
        bool UpdateMyAccount (MyAccount myAccount);
        bool DeleteMyAccount (int Id);
        List<MyAccount> GetAllMyAccounts ();
        MyAccount GetMyAccountById (int Id);

    }
}
