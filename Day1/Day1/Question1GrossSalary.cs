using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Question1GrossSalary
    {
        static void MainSalary(string[] args)
        {
            Console.WriteLine("Enter basic salary");
            double Salary = Convert.ToDouble(Console.ReadLine());
            double GrossSalary = 0;
            
            if (Salary <= 10000)
            {
                GrossSalary = Salary + (Salary * 0.20) + (Salary * 0.80);
            }
            else if (Salary > 10000 && Salary <= 20000)
            {
                GrossSalary = Salary + (Salary * 0.25) + (Salary * 0.90);
            }
            else if (Salary > 20000)
            {
                GrossSalary = Salary + (Salary * 0.30) + (Salary * 0.95);
            }
            else
            {
                Console.WriteLine("Invalid salary");
            }
            Console.WriteLine("Gross salary - " + GrossSalary);
        }
    }
}
