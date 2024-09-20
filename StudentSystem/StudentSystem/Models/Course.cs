using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    internal class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }

        public List<Student> students { get; } = [];
        public ICollection<Homework> homeworks { get; } = new List<Homework>();
        public ICollection<Resource> Resources { get; } = new List<Resource>();
        public List<StudentCourse> studentcourse { get; } = [];
    }
}
