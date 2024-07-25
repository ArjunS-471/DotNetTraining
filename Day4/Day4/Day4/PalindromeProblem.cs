using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class PalindromeProblem
    {
        static void MainPalindrome(string[] args)
        {
            Console.WriteLine("Enter string");
            string userString = Console.ReadLine();
            userString = userString.ToUpper().Trim();

            bool PalindromeCheck = true;

            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] != userString[userString.Length - i - 1])
                {
                    PalindromeCheck = false;
                    break;
                }
            }

            if (PalindromeCheck)
            {
                Console.WriteLine("Provided string is a Palindrome");
            }
            else
            {
                Console.WriteLine("Provided string is not a Palindrome");
            }
        }
    }
}
