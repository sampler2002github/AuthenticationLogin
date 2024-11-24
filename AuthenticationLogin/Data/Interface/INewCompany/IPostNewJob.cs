using AuthenticationLogin.Data.Model.NewCompany;

namespace AuthenticationLogin.Data.Interface.INewCompany
{
    public interface IPostNewJob
    {
        bool AddNewJob(PostNewJob newJob);
        bool UpdateNewJob(PostNewJob newJob);
        bool DeleteNewJob(int Id);
        List<PostNewJob> GetAllNewJobs();
        PostNewJob GetNewJobById(int Id);
    }
}
