using AuthenticationLogin.Data.Model.NewCompany;

namespace AuthenticationLogin.Data.Interface.INewCompany
{
    public interface INCMyAccount
    {
        bool AddAccount(NCMyAccount myAccount);
        bool UpdateAccount(NCMyAccount myAccount);
        bool DeleteAccount(int Id);
        List<NCMyAccount> GetAllAccounts();
        NCMyAccount GetAccountById(int Id);
    }
}
