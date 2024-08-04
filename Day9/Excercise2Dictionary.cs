using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Excercise2Dictionary
    {
        public static void MainD()
        {
            Dictionary<String, int> studentAge = new Dictionary<String, int>();

            //Dictionary add
            studentAge.Add("Rooney", 10);
            studentAge.Add("Ronaldo", 11);
            studentAge.Add("Giggs", 14);
            studentAge.Add("Scholes", 13);
            studentAge.Add("Carrick", 12);

            //Dictionary display
            foreach (var item in studentAge)
            {
                Console.WriteLine(item.Key + " aged " + item.Value);
            }

            //Dictionary remove
            studentAge.Remove("Giggs");

            //Dictionary update
            studentAge["Scholes"] = 15;

            //Dictionary Name check
            Console.WriteLine("Mention name to be checked in the Dictionary - ");
            string NameToBeChecked = Console.ReadLine();
            Boolean CheckResult = false;

            foreach (var item in studentAge)
            {
                if (studentAge.ContainsKey(NameToBeChecked))
                {
                    CheckResult = true;
                    break;
                }
            }
            if (!CheckResult)
            {
                Console.WriteLine(NameToBeChecked + " is not present in the Dictionary");
            }
            else
            {
                Console.WriteLine(NameToBeChecked + " is present in the Dictionary");
            }

            //Dictionary count
            Console.WriteLine("Total item count in dictionary - " + studentAge.Count);
        }
    }
}