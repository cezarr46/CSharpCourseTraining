using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Degree
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

        public Degree()
        {

        }

        public Degree(string degreeName, Course coursee, int creditsRequired)
        {
            this.DegreeName = degreeName;
            this.Coursee = coursee;
            this.CreditsRequired = creditsRequired;
        }
    }
}
