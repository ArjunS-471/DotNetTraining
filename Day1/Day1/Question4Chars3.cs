using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Question4Chars3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");

            string Sample = Console.ReadLine();
            string First;

            if (Sample.Length >= 3)
            {
                First = Sample.Substring(0, 3);
            }
            else
            {
                First = Sample;
            }

            Sample = First + Sample + First;

            Console.WriteLine(Sample);
        }
    }
}
