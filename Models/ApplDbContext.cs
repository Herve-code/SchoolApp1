using Microsoft.EntityFrameworkCore;

namespace SchoolApp.Models
{
    public class ApplDbContext : DbContext
    {
        public ApplDbContext(DbContextOptions<ApplDbContext> options) : base (options)
        {

        }
        public DbSet<Course>Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
