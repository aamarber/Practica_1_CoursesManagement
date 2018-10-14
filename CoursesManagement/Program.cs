using CoursesManagement.Domain;
using CoursesManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace CoursesManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Entity Framework World!");

            var optionsBuilder = new DbContextOptionsBuilder();

            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder.UseMySql(config.GetConnectionString("DefaultConnection"));

            var db = new CoursesContext(optionsBuilder.Options);

            var teacher = new Teacher() { Name = "Aarón" };

            var course = new Course() { Name = "NET Amaris", Teacher = teacher };

            db.Courses.Add(course);

            db.SaveChanges();


        }
    }
}
