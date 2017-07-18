using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    internal class Student : Person
    {
        public static int studentCounter;
        private int facultyNumber;

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
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
    }
}
