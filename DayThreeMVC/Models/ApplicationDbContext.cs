using Microsoft.EntityFrameworkCore;

namespace DayThreeMVC.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet <Company> Companies { get; set; }
        public DbSet<Student> Students { get; set; }
        }
}
