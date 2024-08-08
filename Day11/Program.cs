using System.Text.RegularExpressions;

namespace Day11
{
    internal class Program1
    {
        static void MainP(string[] args)
        {
            string pattern = "^[0-9]{4}$";
            Regex rex = new Regex(pattern);
            string x = "1234";
            if (rex.IsMatch(x))
            {
                Console.WriteLine("Is a number");
            }
            else
            {
                Console.WriteLine("Not a number");
            }
            Console.WriteLine();

        }
    }
}