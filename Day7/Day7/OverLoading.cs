using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class OverLoadingDemo
    {
        public void Sum()
        {
            Console.WriteLine(1 + 2);
        }
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sum(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public void Sum(string a, string b)
        {
            Console.WriteLine(a + b);
        }
    }
    internal class OverLoading
    {
        public static void MainO()
        {
            OverLoadingDemo overloadingDemo = new OverLoadingDemo();
            overloadingDemo.Sum();
            overloadingDemo.Sum(1,2);
            overloadingDemo.Sum(1,2,3);
            overloadingDemo.Sum("1","2");

        }
    }
}
