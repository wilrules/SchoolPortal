using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SchoolPortal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet <Tribe> Tribes { get; set; }

        public DbSet<Religion> Religions { get; set; }

        public DbSet<Title> Titles { get; set; }    

        public DbSet<Gender> Genders { get; set; }

        public DbSet <Student> Students { get; set; }

      

       public DbSet<File> Files { get; set; }
      
        public DbSet<StudentsSubjects> StudentsSubjects { get; set; }

        public DbSet<Subjects> Subjects { get; set; }

        public DbSet<Year> Years { get; set; }

        public DbSet<Teacher> Teachers { get; set; }






        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}