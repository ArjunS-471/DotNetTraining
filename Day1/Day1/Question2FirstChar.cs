using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Question2FirstChar
    {
        static void MainFirstChar(string[] args)
        {
            Console.WriteLine("Enter text");
            String SampleText = Console.ReadLine();

            SampleText = SampleText.Substring(0, 1).Trim() + SampleText + SampleText.Substring(0, 1).Trim();

            Console.WriteLine(SampleText);
        }
    }
}
