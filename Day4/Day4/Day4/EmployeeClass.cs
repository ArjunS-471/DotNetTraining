using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class EmployeeClass
    {
        class Employee
        {
            public int EmpID;
            public String Name;
            public int EmpSal;
            public String Gender;

            public void PrintData(Employee employee)
            {
                Console.WriteLine("Employee ID - " + employee.EmpID);
                Console.WriteLine("Employee Name - " + employee.Name);
                Console.WriteLine("Employee Salary - " + employee.EmpSal);
                Console.WriteLine("Employee Gender - " + employee.Gender);
            }

            public Employee GetData()
            {
                Employee employee = new Employee();

                Console.WriteLine("Enter employee ID");
                employee.EmpID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Enter employee salary");
                employee.EmpSal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee gender");
                employee.Gender = Console.ReadLine();

                return employee;

            }
        }

        internal class Classesdemo
        {
            public static void Main()
            {
                Employee employee = new Employee();
                
                employee = employee.GetData();
                employee.PrintData(employee);

            }
        }
    }
}
