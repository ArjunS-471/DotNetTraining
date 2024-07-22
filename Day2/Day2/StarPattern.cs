using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class StarPattern
    {
        static void MainPattern(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                if (i == 0 || i == 10)
                {
                    for (int j = 0; j < 11; j++) 
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                if (i == 1 || i == 9)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 0; k < 7; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                if (i == 2 || i == 8)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 0; k < 5; k++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                if (i == 3 || i == 7)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                if (i == 4 || i == 6)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                if (i == 5)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
