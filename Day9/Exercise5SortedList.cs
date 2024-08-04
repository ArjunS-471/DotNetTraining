using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Exercise5SortedList
    {
        public static void MainSL()
        {
            SortedList<string, double> employeeSalary = new SortedList<string, double>();
            
            //SortedList Add
            employeeSalary.Add("Virat", 10000);
            employeeSalary.Add("Rohit", 11000);
            employeeSalary.Add("Dhoni", 13000);
            employeeSalary.Add("Sachin", 14000);
            employeeSalary.Add("Ganguly", 12000);

            //SortedList display
            foreach (var item in employeeSalary) 
            { 
                Console.WriteLine(item.Key + " gets salary of " + item.Value);
            }

            //SortedList remove
            Console.WriteLine("Enter name of employee to be removed - ");
            string NameToBeRemoved = Console.ReadLine();
            employeeSalary.Remove(NameToBeRemoved);

            //SortedList update
            employeeSalary["Dhoni"] = 13500;

            //SortedList count
            Console.WriteLine("Count of items in sorted list - " + employeeSalary.Count);
        }
    }
}
