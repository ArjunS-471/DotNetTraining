using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class outKeyword
    {
        static void MainOut(string[] args)
        {
            int output, x = 1, y = 2;
            sumOut(x, y, out output);
            sumRef(ref x, ref y);
            Console.WriteLine(output);
        }

        public static void sumOut(int x, int y, out int result)
        {
            result = x + y;
        }

        public static void sumRef(ref int x, ref int y)
        {
            Console.WriteLine(x + y);
        }

    }
}
