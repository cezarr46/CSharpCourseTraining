using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class Student : Person
    {
        public static int studentCounter;
        private int facultyNumber;
        private Stack<int> grades = new Stack<int>();
        
        public int FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public Stack<int> Grades
        {
            get { return grades; }
            set { grades = value; }
        }
        public Student(string firstName, string lastName, string city, int zip, string country, int facultyNumber)
        {
            studentCounter += 1;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Zip = zip;
            Country = country;
            FacultyNumber = facultyNumber;
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
