using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    internal class Teacher : Person
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Teacher(string firstName, string lastName, string city, int zip, string country, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Zip = zip;
            Country = country;
            Id = id;
        }

        public static void GradeTest()
        {
            Console.WriteLine("Grading tests...");
        }
    }
}
