using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
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

            //for (int i = 0; i < heldStudents.Length; i++)
            //{
            //    Console.Write("Enter student's first name: ");
            //    heldStudents[i].StudentFirstName = Console.ReadLine();
            //    Console.Write("Enter student's last name: ");
            //    heldStudents[i].StudentLastName = Console.ReadLine();
            //    Console.Write("Enter student's city: ");
            //    heldStudents[i].City = Console.ReadLine();
            //    Console.Write("Enter student's faculty number: ");
            //    heldStudents[i].FacultyNumber = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < heldStudents.Length; i++)
            //{
            //    Console.WriteLine($"Student's first name: {heldStudents[i].StudentFirstName}");
            //    Console.WriteLine($"Student's last name: {heldStudents[i].StudentLastName}");
            //    Console.WriteLine($"Student's city: {heldStudents[i].City}");
            //    Console.WriteLine($"Student's faculty number: {heldStudents[i].FacultyNumber}");
            //}

        }

        public struct Student
        {
            public string StudentFirstName;
            public string StudentLastName;
            public string City;
            public int FacultyNumber;

            public Student(string studentFirstName, string studentLastName, string city, int facultyNumber)
            {
                this.StudentFirstName = studentFirstName;
                this.StudentLastName = studentLastName;
                this.City = city;
                this.FacultyNumber = facultyNumber;
            }
        }

        public struct Teacher
        {
            public string TeacherFirstName;
            public string TeacherLastName;
            public string Subject;

            public Teacher(string teacherFirstName, string teacherLastName, string subject)
            {
                this.TeacherFirstName = teacherFirstName;
                this.TeacherLastName = teacherLastName;
                this.Subject = subject;
            }
        }

        public struct UProgram
        {
            public string ProgramName;
            public string Department;
            public int Degrees;

            public UProgram(string programName, string department, int degrees)
            {
                this.ProgramName = programName;
                this.Department = department;
                this.Degrees = degrees;
            }
        }

        public struct Course
        {
            public string CourseName;
            public int Credits;
            public int Teachers;

            public Course(string courseName, int credits, int teachers)
            {
                this.CourseName = courseName;
                this.Credits = credits;
                this.Teachers = teachers;
            }
        }
    }
}
