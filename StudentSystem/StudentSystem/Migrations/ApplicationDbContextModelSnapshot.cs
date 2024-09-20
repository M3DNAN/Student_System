﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSystem.Data;

#nullable disable

namespace StudentSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("studentsStudentId")
                        .HasColumnType("int");

                    b.HasKey("CoursesCourseId", "studentsStudentId");

                    b.HasIndex("studentsStudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("StudentSystem.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            Description = "for .net developer",
                            EndDate = new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "c#",
                            Price = 5500.0,
                            StartDate = new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CourseId = 2,
                            Description = "for java developer",
                            EndDate = new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "java",
                            Price = 6000.0,
                            StartDate = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.Homework", b =>
                {
                    b.Property<int>("HomeworkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeworkId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContentType")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmissionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("HomeworkId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Homework");

                    b.HasData(
                        new
                        {
                            HomeworkId = 1,
                            Content = "http://google.com/homework1",
                            ContentType = 1,
                            CourseId = 1,
                            StudentId = 1,
                            SubmissionTime = new DateTime(2024, 9, 19, 19, 57, 10, 115, DateTimeKind.Local).AddTicks(17)
                        },
                        new
                        {
                            HomeworkId = 2,
                            Content = "http://google.com/homework2",
                            ContentType = 2,
                            CourseId = 2,
                            StudentId = 2,
                            SubmissionTime = new DateTime(2024, 9, 19, 19, 57, 10, 115, DateTimeKind.Local).AddTicks(53)
                        },
                        new
                        {
                            HomeworkId = 3,
                            Content = "http://google.com/homework2",
                            ContentType = 2,
                            CourseId = 2,
                            StudentId = 3,
                            SubmissionTime = new DateTime(2024, 9, 19, 19, 57, 10, 115, DateTimeKind.Local).AddTicks(56)
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.Resource", b =>
                {
                    b.Property<int>("ResourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourceId"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ResourceType")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("ResourceId");

                    b.HasIndex("CourseId");

                    b.ToTable("Resources");

                    b.HasData(
                        new
                        {
                            ResourceId = 1,
                            CourseId = 1,
                            Name = "Math Video",
                            ResourceType = 0,
                            Url = "http://google.com/math-video"
                        },
                        new
                        {
                            ResourceId = 2,
                            CourseId = 2,
                            Name = "Physics Presentation",
                            ResourceType = 1,
                            Url = "http://google.com/physics-presentation"
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("PhoneNumber")
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Birthday = "15/03/1995",
                            Name = "Alaa",
                            PhoneNumber = "0100000000",
                            RegisteredOn = new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StudentId = 2,
                            Birthday = "15/09/2002",
                            Name = "Mustafa",
                            PhoneNumber = "0111111111",
                            RegisteredOn = new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StudentId = 3,
                            Birthday = "15/09/2000",
                            Name = "Ahmed",
                            PhoneNumber = "0122222222",
                            RegisteredOn = new DateTime(2024, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("StudentSystem.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourse");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            CourseId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            CourseId = 1
                        });
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("studentsStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentSystem.Models.Homework", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", "Course")
                        .WithMany("homeworks")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Models.Student", "Student")
                        .WithMany("homeworks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSystem.Models.Resource", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", "Course")
                        .WithMany("Resources")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentSystem.Models.StudentCourse", b =>
                {
                    b.HasOne("StudentSystem.Models.Course", "course")
                        .WithMany("studentcourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentSystem.Models.Student", "student")
                        .WithMany("studentcourse")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("student");
                });

            modelBuilder.Entity("StudentSystem.Models.Course", b =>
                {
                    b.Navigation("Resources");

                    b.Navigation("homeworks");

                    b.Navigation("studentcourse");
                });

            modelBuilder.Entity("StudentSystem.Models.Student", b =>
                {
                    b.Navigation("homeworks");

                    b.Navigation("studentcourse");
                });
#pragma warning restore 612, 618
        }
    }
}
