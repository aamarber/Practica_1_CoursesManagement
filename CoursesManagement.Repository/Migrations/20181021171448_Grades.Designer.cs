﻿// <auto-generated />
using System;
using CoursesManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoursesManagement.Repository.Migrations
{
    [DbContext(typeof(CoursesContext))]
    [Migration("20181021171448_Grades")]
    partial class Grades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CoursesManagement.Domain.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CoursesManagement.Domain.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CourseId");

                    b.Property<int?>("StudentId");

                    b.Property<int?>("TeacherId");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("CoursesManagement.Domain.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CourseId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CoursesManagement.Domain.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CoursesManagement.Domain.Course", b =>
                {
                    b.HasOne("CoursesManagement.Domain.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("CoursesManagement.Domain.Grade", b =>
                {
                    b.HasOne("CoursesManagement.Domain.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("CoursesManagement.Domain.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.HasOne("CoursesManagement.Domain.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("CoursesManagement.Domain.Student", b =>
                {
                    b.HasOne("CoursesManagement.Domain.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId");
                });
#pragma warning restore 612, 618
        }
    }
}
