using System;

namespace Module5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivan", "Ivanov", "Sofia", 1000, "Bulgaria");
            Student student2 = new Student("Petar", "Petrov", "Sofia", 1000, "Bulgaria");
            Student student3 = new Student("Todor", "Todorov", "Sofia", 1000, "Bulgaria");
            Student[] students = { student1, student2, student3 };
            Teacher teacher1 = new Teacher("Radomir", "Radomirov", "Sofia", 1000, "Bulgaria");
            Teacher[] teachers = { teacher1 };
            Course course = new Course("Programming with C#", students, teachers);
            Degree degree1 = new Degree("Bachelor", course, 120);
            UProgram programe = new UProgram("Information Technology", "Bachelor");

            Console.WriteLine($"The {programe.ProgramName} program contains the {programe.Degree} of Science degree");
            Console.WriteLine();
            Console.WriteLine($"The {programe.Degree} of Science degree contains the course {course.CourseName}");
            Console.WriteLine();
            Console.WriteLine($"The {course.CourseName} course contains {student1.Count} student<s>");
        }
    }
}
