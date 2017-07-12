using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Course
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

        public Course(string courseName, List<Student> students, List<Teacher> teachers)
        {
            this.CourseName = courseName;
        }
    }
}
