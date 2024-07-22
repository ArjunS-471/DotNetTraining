using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class OddEven
    {
        static void MainOddEven(string[] args)
        {
            Console.WriteLine("Enter a number to check Odd or Even");
            int Number;
            Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 1)
            {
                Console.WriteLine("Odd");
            }
            else
            {
                Console.WriteLine("Even");
            }
        }
    }
}
