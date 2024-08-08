using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day11
{
    internal class Program
    {
        static void MainR(string[] args)
        {
            //b,ab,aab,
            string pattern = "a*b"; //zero or more
            string pattern1 = "a+b"; //one or more
            string pattern2 = "a?b"; //zero or one
            Regex rex = new Regex(pattern2);
            Match match = rex.Match("hgafghfabcd");
            if (match.Success)
            {
                Console.WriteLine("Match success");
            }
            else
            {
                Console.WriteLine("Match fail");
            }
            Console.WriteLine();

        }
    }
}
