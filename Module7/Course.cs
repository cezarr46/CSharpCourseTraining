﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class Course
    {
        private string courseName;
        private Degree degree;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public Degree Degreee
        {
            get { return degree; }
            set { degree = value; }
        }

        public Course()
        {

        }

        public Course(string courseName, ArrayList students, ArrayList teachers)
        {
            this.CourseName = courseName;
        }
    }
}
