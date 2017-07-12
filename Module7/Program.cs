﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ivan", "Ivanov", "Sofia", 1000, "Bulgaria");
            Student student2 = new Student("Petar", "Petrov", "Sofia", 1000, "Bulgaria");
            Student student3 = new Student("Todor", "Todorov", "Sofia", 1000, "Bulgaria");
            ArrayList students = new ArrayList();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Teacher teacher1 = new Teacher("Radomir", "Radomirov", "Sofia", 1000, "Bulgaria");
            ArrayList teachers = new ArrayList();
            teachers.Add(teacher1);

            for (int i = 0; i < students.Count; i++)
            {
                student1.Grades.Push(5);
                student2.Grades.Push(5);
                student3.Grades.Push(5);
            }

            //ListGrade
            //foreach (int grade in student1.Grades)
            //{
            //    Console.WriteLine(grade);
            //}

            Student.ListStudents(students);

            Course course = new Course("Programming with C#", students, teachers);
            Degree degree1 = new Degree("Bachelor", course, 120);

            Console.WriteLine($"The {course.CourseName} program contains the {degree1.DegreeName} of Science degree");
            Console.WriteLine();
            Console.WriteLine($"The {degree1.DegreeName} of Science degree contains the course {course.CourseName}");
            Console.WriteLine();
            Console.WriteLine($"The {course.CourseName} course contains {student1.Count} student<s>");
        }
    }
}
