using System;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, addressLine1, addressLine2, city, state, country;
            DateTime birthDate;
            int zip;

            firstName = "Sezay";
            lastName = "Ismail";
            addressLine1 = "Studentski grad";
            addressLine2 = "blok 2";
            city = "Sofia";
            state = "Sofia";
            country = "Bulgaria";
            birthDate = new DateTime(1994, 10, 02);
            zip = 1000;

            Console.WriteLine($"First Name: {firstName},\nLast Name: {lastName},\nBirthdate: {birthDate},\nAddress Line 1: {addressLine1},\nAddress Line 2: {addressLine2},\nCity: {city},\nState/Province: {state},\nZip/Postal: {zip},\nCountry: {country}");

        }
    }
}
