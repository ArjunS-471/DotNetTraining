using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    internal class LINQDemo
    {
        public static void MainL1()
        {
            string[] language = { "c#", "Java", "C++", "Ruby", "C", "perl" };
            var result = from lang in language where lang.Contains('C') select lang;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



        }
    }
}
