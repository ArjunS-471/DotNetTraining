using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class FirstApplication
    {
        private static void MainFA(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int Number1, Number2;
            Console.WriteLine("Please enter some number 1");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter some number 2");
            Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Number1 + " " + Number2);
            Console.Write(Number1 + "\t");
            Console.Write(Number2);
        }
    }
}
