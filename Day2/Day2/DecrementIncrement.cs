using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class DecrementIncrement
    {
        static void MainDI(string[] args)
        {
            for (int i = 5;i > 0; i--)
            {
                int k = 5-i;
                for (int l = 0; l < k; l++)
                {
                    Console.Write(" ");
                }
                for (int j = 0;j < i; j++)
                {
                    Console.Write("*");
                }
                if (i!=1)
                {
                    Console.WriteLine();
                }
            }

            for (int i = 0; i < 6; i++)
            {
                int k = 5 - i;
                for (int l = 0; l < k; l++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
