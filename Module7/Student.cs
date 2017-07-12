using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class Student : Person
    {
        private static int studentCounter;
        private int facultyNumber;
        public Stack<int> Grades = new Stack<int>();

        public int Count
        {
            get { return studentCounter; }
            set { studentCounter = value; }
        }

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public Student()
        {

        }

        public Student(string firstName, string lastName, string city, int zip, string country)
        {
            studentCounter += 1;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Zip = zip;
            this.Country = country;
        }

        public static void TakeTest()
        {
            Console.WriteLine("Students taking test...");
        }

        public static void ListStudents(ArrayList students)
        {
            foreach (Student s in students)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }
        }
    }
}
