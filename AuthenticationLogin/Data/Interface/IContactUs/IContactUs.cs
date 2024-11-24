using AuthenticationLogin.Data.Model.ContactUs;

namespace AuthenticationLogin.Data.Interface.IContactUs
{
    public interface IContactUs
    {
        bool AddDetail(ModContactUS contactUs);
        bool UpdateDetail(ModContactUS contactUs);
        bool DeleteDetail(int Id);
        List<ModContactUS> GetAllDetails();
        ModContactUS GetDetailById(int Id);
    }
}
