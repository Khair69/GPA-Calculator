using GPA_Calculator.Modles;
using Microsoft.EntityFrameworkCore;

namespace GPA_Calculator.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Course> Courses { get; set; }
    }
}
