using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    class Teacher : Person
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, string city, int zip, string country)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Zip = zip;
            this.Country = country;
        }

        public static void GradeTest()
        {
            Console.WriteLine("Grading tests...");
        }
    }
}
