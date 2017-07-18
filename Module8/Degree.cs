using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    internal class Degree
    {
        private string degreeName;
        private int creditsRequired;
        private Course coursee;

        public string DegreeName
        {
            get { return degreeName; }
            set { degreeName = value; }
        }

        public int CreditsRequired
        {
            get { return creditsRequired; }
            set { creditsRequired = value; }
        }

        public Course Coursee
        {
            get { return coursee; }
            set { coursee = value; }
        }
        public Degree(string degreeName, Course coursee, int creditsRequired)
        {
            DegreeName = degreeName;
            Coursee = coursee;
            CreditsRequired = creditsRequired;
        }
    }
}
