using Microsoft.EntityFrameworkCore;

namespace AspNetCorePractice_WebApp_MVC.Models
{
    public class AspNetCorePracticeDbContext : DbContext
    {
        public AspNetCorePracticeDbContext(DbContextOptions <AspNetCorePracticeDbContext> options) : base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Batch> Batches { get; set; }


    }
}
