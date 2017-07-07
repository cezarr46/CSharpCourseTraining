using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLetter = "X";
            string secondLetter = "O";

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(firstLetter);
                    }
                    else if ((i + j) % 2 == 1)
                    {
                        Console.Write(secondLetter);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
