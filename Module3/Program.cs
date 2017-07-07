using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            string address = "";
            string city = "";
            DateTime birthdate = new DateTime();
            string programName = "";
            string departmentHead = "";
            int degrees = 0;
            string degreeName = "";
            int credits = 0;

            GetStudentInformation(firstName, lastName, birthdate, city, address);
            GetTeacherInformation(firstName, lastName, birthdate, city, address);
            GetUProgramInformation(programName, departmentHead, degrees);
            GetDegreeInformation(degreeName, credits);
            PrintStudentDetails(firstName, lastName, birthdate);
            PrintTeacherDetails(firstName, lastName, address, city);
            PrintUProgramInformation(programName, departmentHead, degrees);
            PrintDegreeInformation(degreeName, credits);
            //ValidatatingStudentBirthday();
        }

        static void ValidatatingStudentBirthday()
        {
            throw new NotImplementedException();
        }

        static void GetStudentInformation(string firstName, string lastName, DateTime birthdate, string city, string address)
        {
            Console.Write("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter the student's last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter the student's birthdate: ");
            birthdate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the student's city: ");
            city = Console.ReadLine();
            Console.Write("Enter the student's address: ");
            address = Console.ReadLine();
        }

        static void GetTeacherInformation(string firstName, string lastName, DateTime birthdate, string city, string address)
        {
            Console.Write("Enter the teacher's first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter the teacher's last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter the teacher's birthdate: ");
            birthdate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the teacher's city: ");
            city = Console.ReadLine();
            Console.Write("Enter the teacher's address: ");
            address = Console.ReadLine();
        }

        static void GetUProgramInformation(string programName, string departmentHead, int degrees)
        {
            Console.Write("Enter Program Name: ");
            programName = Console.ReadLine();
            Console.Write("Enter Department Head: ");
            departmentHead = Console.ReadLine();
            Console.Write("Enter Degrees: ");
            degrees = int.Parse(Console.ReadLine());
        }

        static void GetDegreeInformation(string degreeName, int credits)
        {
            Console.Write("Enter Degree Name: ");
            degreeName = Console.ReadLine();
            Console.Write("Enter Credits Required: ");
            credits = int.Parse(Console.ReadLine());
        }

        static void PrintStudentDetails(string firstName, string lastName, DateTime birthdate)
        {
            Console.WriteLine($"{firstName} {lastName} was born on {birthdate}");
        }

        static void PrintTeacherDetails(string firstName, string lastName, string address, string city)
        {
            Console.WriteLine($"Teacher: {firstName} {lastName} lives in {city}, {address}");
        }

        static void PrintUProgramInformation(string programName, string departmentHead, int degrees)
        {
            Console.WriteLine($"Program name is: {programName} with Department Head {departmentHead} and {degrees} degrees");
        }

        static void PrintDegreeInformation(string degreeName, int credits)
        {
            Console.WriteLine($"Degree name: {degreeName} with {credits} credits");
        }
    }
}
