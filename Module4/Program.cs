using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student[] heldStudents = new Student[5];
            heldStudents[0].StudentFirstName = "Ivan";
            heldStudents[0].StudentLastName = "Ivanov";
            heldStudents[0].City = "Sofia";
            heldStudents[0].FacultyNumber = 121212101;

            Console.WriteLine($"Student's first name: {heldStudents[0].StudentFirstName}");
            Console.WriteLine($"Student's last name: {heldStudents[0].StudentLastName}");
            Console.WriteLine($"Student's lives in: {heldStudents[0].City}");
            Console.WriteLine($"Student's faculty number is: {heldStudents[0].FacultyNumber}");

            //challenge
            for (int i = 0; i < heldStudents.Length; i++)
            {
                int stNum = i + 1;
                Console.Write("Enter " + stNum + " student's first name: ");
                heldStudents[i].StudentFirstName = Console.ReadLine();
                Console.Write("Enter " + stNum + " student's last name: ");
                heldStudents[i].StudentLastName = Console.ReadLine();
                Console.Write("Enter " + stNum + " student's city: ");
                heldStudents[i].City = Console.ReadLine();
                Console.Write("Enter " + stNum + " student's faculty number: ");
                heldStudents[i].FacultyNumber = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < heldStudents.Length; i++)
            {
                int stNum = i + 1;
                Console.WriteLine($"{stNum} student's first name: {heldStudents[i].StudentFirstName}");
                Console.WriteLine($"{stNum} student's last name: {heldStudents[i].StudentLastName}");
                Console.WriteLine($"{stNum} student's city: {heldStudents[i].City}");
                Console.WriteLine($"{stNum} student's faculty number: {heldStudents[i].FacultyNumber}");
            }

        }

        public struct Student
        {
            private string studentFirstName;
            private string studentLastName;
            private string addressLine;
            private string city;
            private string country;
            private int zip;
            private int facultyNumber;

            public string StudentFirstName
            {
                get { return studentFirstName; }
                set { studentFirstName = value; }
            }
            public string StudentLastName
            {
                get { return studentLastName; }
                set { studentLastName = value; }
            }

            public string AddressLine
            {
                get { return addressLine; }
                set { addressLine = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            public int Zip
            {
                get { return zip; }
                set { zip = value; }
            }

            public int FacultyNumber
            {
                get { return facultyNumber; }
                set { facultyNumber = value; }
            }
            
            public Student(string studentFirstName, string studentLastName,string addressLine, string city,string country, int zip, int facultyNumber)
            {
                this.studentFirstName = studentFirstName;
                this.studentLastName = studentLastName;
                this.addressLine = addressLine;
                this.city = city;
                this.country = country;
                this.zip = zip;
                this.facultyNumber = facultyNumber;
            }
        }

        public struct Teacher
        {
            private string teacherFirstName;
            private string teacherLastName;
            private string addressLine;
            private string city;
            private string country;
            private int zip;
            private string subject;

            public string TeacherFirstName
            {
                get { return teacherFirstName; }
                set { teacherFirstName = value; }
            }

            public string TeacherLastName
            {
                get { return teacherLastName; }
                set { teacherLastName = value; }
            }

            public string AddressLine
            {
                get { return addressLine; }
                set { addressLine = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            public int Zip
            {
                get { return zip; }
                set { zip = value; }
            }

            public string Subject
            {
                get { return subject; }
                set { subject = value; }
            }

            public Teacher(string teacherFirstName, string teacherLastName, string addressLine, string city, string country, int zip, string subject)
            {
                this.teacherFirstName = teacherFirstName;
                this.teacherLastName = teacherLastName;
                this.addressLine = addressLine;
                this.city = city;
                this.country = country;
                this.zip = zip;
                this.subject = subject;
            }
        }

        public struct UProgram
        {
            private string programName;
            private string department;
            private int degrees;

            public string ProgramName
            {
                get { return programName; }
                set { programName = value; }
            }

            public string Department
            {
                get { return department; }
                set { department = value; }
            }

            public int Degrees
            {
                get { return degrees; }
                set { degrees = value; }
            }

            public UProgram(string programName, string department, int degrees)
            {
                this.programName = programName;
                this.department = department;
                this.degrees = degrees;
            }
        }

        public struct Course
        {
            private string courseName;
            private int credits;
            private int teachers;

            public string CourseName
            {
                get { return courseName; }
                set { courseName = value; }
            }

            public int Credits
            {
                get { return credits; }
                set { credits = value; }
            }

            public int Teachers
            {
                get { return teachers; }
                set { teachers = value; }
            }

            public Course(string courseName, int credits, int teachers)
            {
                this.courseName = courseName;
                this.credits = credits;
                this.teachers = teachers;
            }
        }
    }
}