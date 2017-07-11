﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Teacher
    {
        private string firstName;
        private string lastName;
        private string city;
        private int zip;
        private string country;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
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
    }
}
