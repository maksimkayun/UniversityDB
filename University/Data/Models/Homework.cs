﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Data.Models
{
    public class Homework
    {
        [Key] 
        public int HomeworkId { get; set; }

        [Required, Column(TypeName = "varchar(max)")]
        public string Content { get; set; }

        [Required] 
        public ContentType ContentType { get; set; }

        public DateTime SubmissionTime { get; set; }

        [ForeignKey("Student")] 
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Course")] 
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}