using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class FunctionMax3Num
    {
        public static int findMax(int a, int b, int c)
        {
            int Num;
            if (a > b)
            {
                Num = a;
            } else
            {
                Num = b;
            }

            if (c > Num)
            {
                Num = c;
            }
            return Num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max num = " + findMax(a,b,c));
        }
    }
}
