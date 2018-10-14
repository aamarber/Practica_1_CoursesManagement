using CoursesManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.IO;

namespace CoursesManagement
{
    public class CoursesContextFactory : IDesignTimeDbContextFactory<CoursesContext>
    {
        public CoursesContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder();

            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));

            return new CoursesContext(optionsBuilder.Options);
        }
    }
}
