using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class StringVsStringBuilder
    {
        static void MainSB(string[] args)
        {
            string s = string.Empty;
            s = "CSharp";

            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            Console.WriteLine(sb.ToString());

            for (int i = 0; i < args.Length; i++) 
            {
                Console.WriteLine(s[i]);
            }
        }


    }
}
