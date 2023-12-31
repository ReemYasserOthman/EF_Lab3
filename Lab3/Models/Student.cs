﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Lab3.Models
{
    public partial class Student
    {
        public Student()
        {
            InverseStSuperNavigation = new HashSet<Student>();
            StudCourses = new HashSet<StudCourse>();
        }

        public int StId { get; set; }
        public string StFname { get; set; }
        public string StLname { get; set; }
        public string StAddress { get; set; }
        public int? StAge { get; set; }
        public int? DeptId { get; set; }
        public int? StSuper { get; set; }

        public virtual Department Dept { get; set; }
        public virtual Student StSuperNavigation { get; set; }
        public virtual ICollection<Student> InverseStSuperNavigation { get; set; }
        public virtual ICollection<StudCourse> StudCourses { get; set; }
    }
}
