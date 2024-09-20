﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    internal class Homework
    {
        public int HomeworkId { get; set; }
        public string Content  { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }


        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }

      

    }
}
