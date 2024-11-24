using AuthenticationLogin.Data.Model;
using AuthenticationLogin.Data.Model.ContactUs;
using AuthenticationLogin.Data.Model.Feedback;
using AuthenticationLogin.Data.Model.JobSeeker;
using AuthenticationLogin.Data.Model.NewCompany;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationLogin.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
                
        }
        public DbSet<User> Users { get; set; } 
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        //JobSeeker...........
        public DbSet<MyAccount> JSMyAccounts { get; set; }

        //New Company.........
        public DbSet<PostNewJob> NewJobs { get; set; }
        public DbSet<NCMyAccount> NCMyAccounts { get; set; }

        //FeedBack.............
        public DbSet<Feedback> FeedBacks { get; set; }

        //Contact Us...........
        public DbSet<ModContactUS> ContactUs { get; set; }

    }
}
