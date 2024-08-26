using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FileHandling
{
    internal class Regex1
    {
        public static void MainR1() 
        {
            Console.WriteLine("Enter Email and Phone Number in following format - user@example.com and +1-555-123-4567");
            string strUserInput = Console.ReadLine();

            string strInputValidation = @"\s(and)\s";
            string strEmailPattern = @"^[a-zA-Z]+(\.[a-zA-Z]+)?\@[a-zA-Z]+\.(com)";
            string strPhonePattern = @"\+[0-9]\-[0-9]{3}\-[0-9]{3}\-[0-9]{4}";

            if(Regex.IsMatch(strUserInput, strInputValidation) )
            {
                string strEmail = strUserInput.Split(" and ", StringSplitOptions.None)[0];
                string strPhone = strUserInput.Split(" and ", StringSplitOptions.None)[1];

                if (Regex.IsMatch(strEmail, strEmailPattern))
                {
                    Console.WriteLine("For email: Validation result is True");
                }
                else
                {
                    Console.WriteLine("For email: Validation result is False");
                }

                if (Regex.IsMatch(strPhone, strPhonePattern))
                {
                    Console.WriteLine("For phone: Validation result is True");
                }
                else
                {
                    Console.WriteLine("For phone: Validation result is False");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
        }
    }
}
