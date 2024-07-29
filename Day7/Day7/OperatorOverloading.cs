using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Sample
    {
        int Number1, Number2;
        public Sample(int a, int b) 
        { 
            Number1 = a;
            Number2 = b;
        }

        public void Print()
        {
            Console.WriteLine("Number 1 - " + Number1 + " \t Number 2 - " + Number2);
        }

        public static Sample operator +(Sample S1, Sample S2)
        {
            Sample S3 = new Sample(0, 0);
            S3.Number1 = S1.Number1 + S2.Number1;
            S3.Number2 = S1.Number2 + S2.Number2;
            return S3;
        }
    }
    internal class OperatorOverloading
    {
        public static void MainSum()
        {
            Sample s1 = new Sample(1, 2);
            Sample s2 = new Sample(2, 4);
            Sample s3 = s1 + s2;
            s3.Print();
        }
    }
}
