using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9
{
    internal class Student
    {
        private string firstName;
        private string lastName;
        private string city;
        private List<Student> students = new List<Student>();
        private int count = 0;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
