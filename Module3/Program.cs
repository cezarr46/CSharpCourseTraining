using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    public class Program
    {
        private static string firstName = "";
        private static string lastName = "";
        private static string address = "";
        private static string city = "";
        private static DateTime birthDate = new DateTime();
        private static string programName = "";
        private static string departmentHead = "";
        private static int degrees = 0;
        private static string degreeName = "";
        private static int credits = 0;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetStudentInformation();
            p.GetTeacherInformation();
            p.GetUProgramInformation();
            p.GetDegreeInformation();
            p.PrintStudentDetails(firstName, lastName, birthDate);
            p.PrintTeacherDetails(firstName, lastName, address, city);
            p.PrintUProgramInformation(programName, departmentHead, degrees);
            p.PrintDegreeInformation(degreeName, credits);
            //ValidatatingStudentBirthday();
        }

        public void ValidatatingStudentBirthday()
        {
            throw new NotImplementedException();
        }

        public void GetStudentInformation()
        {
            Console.Write("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter the student's last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter the student's birthdate(day/month/year): ");
            birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the student's city: ");
            city = Console.ReadLine();
            Console.Write("Enter the student's address: ");
            address = Console.ReadLine();
        }

        public void GetTeacherInformation()
        {
            Console.Write("Enter the teacher's first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter the teacher's last name: ");
            lastName = Console.ReadLine();
            Console.Write("Enter the teacher's birthdate(day/month/year): ");
            birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter the teacher's city: ");
            city = Console.ReadLine();
            Console.Write("Enter the teacher's address: ");
            address = Console.ReadLine();
        }

        public void GetUProgramInformation()
        {
            Console.Write("Enter Program Name: ");
            programName = Console.ReadLine();
            Console.Write("Enter Department Head: ");
            departmentHead = Console.ReadLine();
            Console.Write("Enter Degrees: ");
            degrees = int.Parse(Console.ReadLine());
        }

        public void GetDegreeInformation()
        {
            Console.Write("Enter Degree Name: ");
            degreeName = Console.ReadLine();
            Console.Write("Enter Credits Required: ");
            credits = int.Parse(Console.ReadLine());
        }

        public void PrintStudentDetails(string firstName, string lastName, DateTime birthDate)
        {
            Console.WriteLine($"{firstName} {lastName} was born on {birthDate}");
        }

        public void PrintTeacherDetails(string firstName, string lastName, string address, string city)
        {
            Console.WriteLine($"Teacher: {firstName} {lastName} lives in {city}, {address}");
        }

        public void PrintUProgramInformation(string programName, string departmentHead, int degrees)
        {
            Console.WriteLine($"Program name is: {programName} with Department Head {departmentHead} and {degrees} degrees");
        }

        public void PrintDegreeInformation(string degreeName, int credits)
        {
            Console.WriteLine($"Degree name: {degreeName} with {credits} credits");
        }
    }
}
