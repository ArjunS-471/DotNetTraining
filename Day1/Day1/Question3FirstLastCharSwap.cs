using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Question3FirstLastCharSwap
    {
        static void MainSwap(string[] args)
        {
            Console.WriteLine("Enter text");
            string MainString = Console.ReadLine();
            string First, Last;

            First = MainString.Substring(0, 1);
            Last = MainString.Substring(MainString.Length - 1, 1);

            if (MainString.Length > 1)
            {
                MainString = Last + MainString.Substring(1, MainString.Length - 2) + First;
            }

            Console.WriteLine(MainString);

        }
    }
}
