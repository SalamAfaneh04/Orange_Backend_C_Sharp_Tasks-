using Microsoft.EntityFrameworkCore;

namespace Test_ASP.net_core_MVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> StudentsInfi { get; set; }
    }
}