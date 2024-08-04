using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Exercise1List
    {
        public static void MainL()
        {
            List<int> intList = new List<int>();
            
            //Adding items
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);
            intList.Add(5);

            //Displaying items
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

            //Removing item
            intList.RemoveAt(2);

            //Inserting new item
            intList.Insert(2, 6);
            
            //Count display
            Console.WriteLine("Total items in the list - " + intList.Count);

            //Sort
            intList.Sort();

            //Displaying again
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
