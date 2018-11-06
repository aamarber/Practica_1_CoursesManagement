using CoursesManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Threading;

namespace CoursesManagement.Repository.Migrations
{
    public partial class SeedInitialData : Migration
    {
        private static IList<Student> students = new List<Student>
        {
            new Student
            {
                Name = "David"
            },
            new Student
            {
                Name = "Pablo"
            },
            new Student
            {
                Name = "Moisés"
            },
            new Student
            {
                Name = "Sergio"
            }
        };

        private static Teacher teacher = new Teacher
        {
            Name = "Aarón"
        };

        private static decimal[] gradesValues = GetGrades();

        private static decimal[] GetGrades()
        {
            decimal[] gradesValues = new decimal[4];

            for (var i = 0; i < 4; i++)
            {
                Thread.Sleep(10);

                gradesValues[i] = new decimal(new Random().NextDouble() * 10);
            }

            return gradesValues;
        }

        private static IList<Grade> grades = new List<Grade>
        {
            new Grade
            {
                Student = students[0],
                Teacher = teacher,
                Value = gradesValues[0]
            },
            new Grade
            {
                Student = students[1],
                Teacher = teacher,
                Value = gradesValues[1]
            },
            new Grade
            {
                Student = students[2],
                Teacher = teacher,
                Value = gradesValues[2]
            },
            new Grade
            {
                Student = students[3],
                Teacher = teacher,
                Value = gradesValues[3]
            },
        };

        private IList<Course> courses = new List<Course>
        {
            new Course
            {
                Name = "Formacion Amaris",
                Students = students,
                Teacher = teacher,
                Grades = grades
            },
            new Course{
                Name = "Formacion Customerville",
                Students = students,
                Teacher = teacher,
                Grades = grades
            },
            new Course
            {
                Name = "Formacion Inventada",
                Students = students,
                Teacher = teacher,
                Grades = grades
            },
        };

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var optionsBuilder = new DbContextOptionsBuilder();

            optionsBuilder.UseMySql("Server=localhost;Database=CourseManagement;Uid=root;Pwd=root");

            var db = new CoursesContext(optionsBuilder.Options);

            db.AddRange(courses);

            db.SaveChanges();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
