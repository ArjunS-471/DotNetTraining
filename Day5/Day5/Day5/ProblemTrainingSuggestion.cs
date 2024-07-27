using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Employee
    {
        public int Id;
        public string Name;
    }

    internal class ProblemTrainingSuggestion
    {
        public static Employee AddEmployee()
        {
            Employee e = new Employee();
            Console.WriteLine("Enter employee id = ");
            e.Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee name = ");
            e.Name = Console.ReadLine();
            return e;
        }

        public static Employee[] UpdateEmployee(Employee[] EmployeeList)
        {
            int Num;
            string EmpName;
            Console.WriteLine("Enter employee id to be updated = ");
            Num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter updated employee name = ");
            EmpName = Console.ReadLine();
            
            for (int i = 0; i < EmployeeList.Length; i++)
            {
                if (EmployeeList[i].Id != null)
                {
                    if (EmployeeList[i].Id == Num)
                    {
                        EmployeeList[i].Name = EmpName;
                        break;
                    }
                }
            }
            return EmployeeList;
        }

        public static Employee[] DeleteEmployee(Employee[] EmployeeList)
        {
            int Num;
            Console.WriteLine("Enter employee id to be deleted = ");
            Num = Int32.Parse(Console.ReadLine());
            
            for (int i = 0; i < EmployeeList.Length; i++)
            {
                if (EmployeeList[i].Id != null)
                {
                    if (EmployeeList[i].Id == Num)
                    {
                        EmployeeList[i].Name = null;
                        break;
                    }
                }
            }
            return EmployeeList;
        }

        public static void PrintData(Employee[] EmployeeList)
        {
            Console.WriteLine("ID | Emplpyee Name");
            for (int i = 0; i < EmployeeList.Length; i++)
            {
                if (EmployeeList[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(EmployeeList[i].Id + " " + EmployeeList[i].Name);
                }
            }
        }

        public static void Main()
        {
            Employee[] employee = new Employee[10];
            int counter = 0;
            bool circuitBreaker = true;

            while (circuitBreaker)
            {
                Console.WriteLine("\n Please enter the choice \n 1. Add Employee \n 2. Update Employee \n 3. Delete Employee \n 4. List Employee \n 5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        employee[counter] = AddEmployee();
                        counter++;
                        break;
                    case 2:
                        employee = UpdateEmployee(employee);
                        break;
                    case 3:
                        employee = DeleteEmployee(employee);
                        break;
                    case 4:
                        PrintData(employee);
                        break;
                    case 5:
                        circuitBreaker = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
