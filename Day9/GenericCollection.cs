using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    class Employee
    {
        public int EmpID { get; set; }
        public int EmpSalary { get; set; }
        public string EmpName { get; set; }

        public void GetData()
        {
            Console.WriteLine("Please enter Employee EmpID");
            EmpID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Employee Salary");
            EmpSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter Employee Name");
            EmpName = Console.ReadLine();
        }

    }


    internal class GenericCollection
    {
        public static void MainL()
        {
            List<int> myList = new List<int>();
            /*
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            */

            //for (int i = 0; i < 10; i++)
            //{
            //    myList.Add(i);
            //}
            //foreach(var item in myList) 
            //{ 
            //Console.WriteLine(item);
            //}

            List<Employee> empList = new List<Employee>();
            for (int i = 0; i < 2; i++)
            {
                Employee obj = new Employee();
                obj.GetData();
                empList.Add(obj);
            }
            Console.WriteLine();
            foreach (var item in empList)
            {
                Console.WriteLine("Employee EmpID - " + item.EmpID);
                Console.WriteLine("Employee Name - " + item.EmpName);
                Console.WriteLine("Employee Salary - " + item.EmpSalary);
                Console.WriteLine();
            }
        }
    }
}
