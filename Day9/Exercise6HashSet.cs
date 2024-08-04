using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Exercise6HashSet
    {
        public static void MainHS()
        {
            HashSet<int> unique = new HashSet<int>();
            
            //Adding 10 DIFFERENT integers, AND SOME duplicates
            unique.Add(1);
            unique.Add(2);
            unique.Add(3);
            unique.Add(4);
            unique.Add(1);
            unique.Add(5);
            unique.Add(6);
            unique.Add(3);
            unique.Add(7);
            unique.Add(8);
            unique.Add(1);
            unique.Add(9);
            unique.Add(10);

            //HashSet display
            foreach(int item in unique)
            {
                Console.WriteLine(item);
            }

            //HashSet delete
            Console.WriteLine("Enter a value to be deleted - ");
            int userInt = Int32.Parse(Console.ReadLine());
            unique.Remove(userInt);

            //HashSet contains check
            Console.WriteLine("Enter a value to be checked if present - ");
            userInt = Int32.Parse(Console.ReadLine());
            if (unique.Contains(userInt)) 
            {
                Console.WriteLine("Value is present");
            }
            else 
            {
                Console.WriteLine("Value not present");
            }
        }
    }
}
