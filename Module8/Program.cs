using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivan", "Ivanov", "Sofia", 1000, "Bulgaria", 12212);
            Student student2 = new Student("Petar", "Petrov", "Sofia", 1000, "Bulgaria", 12213);
            Student student3 = new Student("Todor", "Todorov", "Sofia", 1000, "Bulgaria", 12214);
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Teacher teacher1 = new Teacher("Radomir", "Radomirov", "Sofia", 1000, "Bulgaria", 20);
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(teacher1);

            for (int i = 0; i < 5; i++)
            {
                student1.Grades.Push(5);
                student2.Grades.Push(5);
                student3.Grades.Push(5);
            }

            Student.ListStudents(students);
            Course course = new Course("Programming with C#", students, teachers);
            Degree degree1 = new Degree("Bachelor", course, 120);
            UProgram programe = new UProgram("Information Technology", degree1);

            Console.WriteLine($"The {programe.ProgramName} program contains the {degree1.DegreeName} of Science degree");
            Console.WriteLine();
            Console.WriteLine($"The {degree1.DegreeName} of Science degree contains the course {course.CourseName}");
            Console.WriteLine();
            Console.WriteLine($"The {course.CourseName} course contains {Student.studentCounter} student<s>");
        }
    }
}
