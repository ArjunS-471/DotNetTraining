using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Array2DMultiplication
    {
        static void MainM(string[] args)
        {
            // increase this number for a bigger array
            int Length = 2;

            int[,] sampleA = new int[Length, Length];
            Console.WriteLine("Enter first matrix numbers");
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    sampleA[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            int[,] sampleB = new int[Length, Length];
            Console.WriteLine("Enter second matrix numbers");
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    sampleB[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            //Sum of matrices
            int[,] sampleC = new int[Length, Length];
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    sampleC[i, j] = sampleA[i, j] * sampleB[i, j];
                }
            }

            //Print out
            Console.WriteLine("Matrix sum - ");
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(sampleC[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
