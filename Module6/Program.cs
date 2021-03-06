﻿using System;

namespace Module6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivan", "Ivanov", "Sofia", 1000, "Bulgaria", 12212);
            Student student2 = new Student("Petar", "Petrov", "Sofia", 1000, "Bulgaria", 12213);
            Student student3 = new Student("Todor", "Todorov", "Sofia", 1000, "Bulgaria", 12214);
            Student[] students = { student1, student2, student3 };
            Teacher teacher1 = new Teacher("Radomir", "Radomirov", "Sofia", 1000, "Bulgaria", 20);
            Teacher[] teachers = { teacher1 };
            Course course = new Course("Programming with C#", students, teachers);
            Degree degree1 = new Degree("Bachelor", course, 120);
            UProgram programe = new UProgram("Information Technology", degree1);

            Console.WriteLine($"The {programe.ProgramName} program contains the {degree1.DegreeName} of Science degree");
            Console.WriteLine();
            Console.WriteLine($"The {programe.Degree} of Science degree contains the course {course.CourseName}");
            Console.WriteLine();
            Console.WriteLine($"The {course.CourseName} course contains {Student.studentCounter} student<s>");
        }
    }
}
