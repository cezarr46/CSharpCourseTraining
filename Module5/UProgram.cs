using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    public class UProgram
    {
        private string programName;
        private string degree;

        public string ProgramName
        {
            get { return programName; }
            set { programName = value; }
        }

        public string Degree
        {
            get { return degree; }
            set { degree = value; }
        }

        public UProgram()
        {

        }

        public UProgram(string programName, string degree)
        {
            this.ProgramName = programName;
            this.Degree = degree;
        }
    }
}
