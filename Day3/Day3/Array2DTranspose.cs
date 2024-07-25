using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Array2DTranspose
    {
        static void Main(string[] args)
        {
            // increase this number for a bigger array
            int Length = 3;

            int[,] sampleA = new int[Length, Length];
            Console.WriteLine("Enter first matrix numbers");
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    sampleA[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

            //Print out
            Console.WriteLine("Matrix before transpose - ");
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(sampleA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Transpose
            int[,] sampleB = new int[Length, Length];
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    sampleB[j,i] = sampleA[i, j];
                }
            }

            sampleA = sampleB;

            //Print out After Transpose
            Console.WriteLine("Matrix After transpose - ");
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(sampleA[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
