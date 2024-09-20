using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homework { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial catalog=Student_System_Database ;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
        .Property(b => b.PhoneNumber)
        .IsUnicode(false);
            modelBuilder.Entity<Resource>()
     .Property(b => b.Url)
     .IsUnicode(false);
            modelBuilder.Entity<Student>(
                eb =>
                {
                    eb.Property(b => b.Name).HasColumnType("varchar(80)");
                    eb.Property(b => b.PhoneNumber).HasColumnType("varchar(10)");
                });
            modelBuilder.Entity<Course>(
               eb =>
               {
                   eb.Property(b => b.Name).HasColumnType("varchar(80)");
               });
            modelBuilder.Entity<Resource>(
             eb =>
             {
                 eb.Property(b => b.Name).HasColumnType("varchar(50)");
             });
            modelBuilder.Entity<StudentCourse>()
            .HasKey(c => new { c.StudentId, c.CourseId });
            modelBuilder.Entity<Student>().HasData(
new Student { StudentId = 1, Name = "Alaa", Birthday = "15/03/1995", PhoneNumber = "0100000000", RegisteredOn = new DateTime(2024, 7, 22) },

    new Student { StudentId = 2, Name = "Mustafa", Birthday = "15/09/2002", PhoneNumber = "0111111111", RegisteredOn = new DateTime(2024, 7, 21) },
 new Student { StudentId = 3, Name = "Ahmed", Birthday = "15/09/2000", PhoneNumber = "0122222222", RegisteredOn = new DateTime(2024, 7, 20) });

            modelBuilder.Entity<Course>().HasData(
    new Course { CourseId = 1, Name = "c#", Description = "for .net developer", Price = 5500.00, StartDate = new DateTime(2024, 7, 1), EndDate = new DateTime(2024, 11, 1) },
        new Course { CourseId = 2, Name = "java", Description = "for java developer", Price = 6000, StartDate = new DateTime(2024, 3, 1), EndDate = new DateTime(2024, 6, 1) });

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentId = 1, CourseId = 2 },
                 new StudentCourse { StudentId = 2, CourseId = 1 },
                 new StudentCourse { StudentId = 3, CourseId = 1 }
                );

            modelBuilder.Entity<Resource>().HasData(
                new Resource { ResourceId = 1, Name = "Math Video", Url = "http://google.com/math-video", ResourceType = ResourceType.Video, CourseId = 1 },
                new Resource { ResourceId = 2, Name = "Physics Presentation", Url = "http://google.com/physics-presentation", ResourceType = ResourceType.Presentation, CourseId = 2 }
            );

            modelBuilder.Entity<Homework>().HasData(
            new Homework { HomeworkId = 1, Content = "http://google.com/homework1", ContentType = ContentType.Pdf, SubmissionTime = DateTime.Now, StudentId = 1, CourseId = 1 },
            new Homework { HomeworkId = 2, Content = "http://google.com/homework2", ContentType = ContentType.Zip, SubmissionTime = DateTime.Now, StudentId = 2, CourseId = 2 },
            new Homework { HomeworkId = 3,  Content = "http://google.com/homework2", ContentType = ContentType.Zip, SubmissionTime = DateTime.Now, StudentId = 3, CourseId = 2 }
        );
        }
    }
    }

