using CoursesManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoursesManagement.Repository
{
    public class CoursesContext : DbContext
    {
        public CoursesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Grade> Grades { get; set; }
    }
}
