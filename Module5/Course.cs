using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Course
    {
        private string courseName;
        private Student[] students;
        private Teacher[] teachers;
        private Degree degree;
        
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        public Student[] Students
        {
            get { return students; }
            set { students = value; }
        }

        public Teacher[] Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public Degree Degreee
        {
            get { return degree; }
            set { degree = value; }
        }

        public Course()
        {

        }
        
        public Course(string courseName, Student[] students, Teacher[] teachers)
        {
            this.CourseName = courseName;
            this.Students = students;
            this.Teachers = teachers;
        }
    }
}
