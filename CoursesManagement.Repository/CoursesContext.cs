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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseMySql(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        //}
    }
}
