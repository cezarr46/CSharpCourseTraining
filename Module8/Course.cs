using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    internal class Course
    {
        private string courseName;
        private Degree degree;
        private List<Student> students;
        private List<Teacher> teachers;

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

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }
        public Course(string courseName, List<Student> students, List<Teacher> teachers)
        {
            CourseName = courseName;
        }
    }
}
