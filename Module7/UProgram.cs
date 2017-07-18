using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    internal class UProgram
    {
        private string programName;
        private Degree degree;

        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }

        public Degree Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public UProgram(string programName, Degree degree)
        {
            ProgramName = programName;
            Degree = degree;
        }
    }
}