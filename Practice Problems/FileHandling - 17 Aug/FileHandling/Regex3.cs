using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FileHandling
{
    internal class Regex3
    {
        public static void MainR3()
        {
            string strReadText = File.ReadAllText(@"D:\Input\CCInfo.txt");
            string[] strarrCCLines = strReadText.Split(new[] { "\n" }, StringSplitOptions.None);

            foreach (string str in strarrCCLines)
            {
                Console.WriteLine(Regex.Replace(str, @"[0-9]{4}-[0-9]{4}-[0-9]{4}-[0-9]{4}", "****-****-****-****"));
            }
        }
    }
}
