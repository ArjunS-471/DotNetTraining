using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class NestedLoop
    {
        static void MainNL(string[] args)
        {
            string Star = "";
            for (int i = 0;i < 5;i++)
            {
                Star = "";
                for (int j = 0;j < i + 1; j++)
                {
                    Star = "*" + Star;
                }
                Console.WriteLine(Star);
                
            }
        }
    }
}
