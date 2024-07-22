using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Functions
    {
        public static int sum (int a, int b)
        {
            return a + b;
        }
        static void MainFunc(string[] args)
        {
            Console.WriteLine("Outout - " + sum(1,3));
        }
    }
}
