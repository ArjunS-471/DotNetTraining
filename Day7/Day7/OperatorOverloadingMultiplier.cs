using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class SampleMul
    {
        int Number1, Number2;
        public SampleMul(int a, int b)
        {
            Number1 = a;
            Number2 = b;
        }

        public void Print()
        {
            Console.WriteLine("Number 1 - " + Number1 + " \t Number 2 - " + Number2);
        }

        public static SampleMul operator *(SampleMul S1, SampleMul S2)
        {
            SampleMul S3 = new SampleMul(0, 0);
            S3.Number1 = S1.Number1 * S2.Number1;
            S3.Number2 = S1.Number2 * S2.Number2;
            return S3;
        }
    }
    internal class OperatorOverloadingMul
    {
        public static void MainMul()
        {
            SampleMul s1 = new SampleMul(1, 2);
            SampleMul s2 = new SampleMul(2, 4);
            SampleMul s3 = s1 * s2;
            s3.Print();
        }
    }
}
