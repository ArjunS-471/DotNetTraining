using System.Text.RegularExpressions;

namespace Day12
{
    internal class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Genders { get; set; }
            public double Salary { get; set; }
        }
        static void Main1(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 101, Name = "Virat", Genders = "Male", Salary = 100000},
                new Employee(){Id = 102, Name = "Rohit", Genders = "Male", Salary = 200000},
                new Employee(){Id = 103, Name = "Alia", Genders = "Female", Salary = 300000},
                new Employee(){Id = 104, Name = "Pant", Genders = "Male", Salary = 400000},
                new Employee(){Id = 105, Name = "Jadeja", Genders = "Male", Salary = 700000},
                new Employee(){Id = 106, Name = "Rani", Genders = "Female", Salary = 805000},
                new Employee(){Id = 107, Name = "Chahal", Genders = "Male", Salary = 800000},
                new Employee(){Id = 108, Name = "Dhoni", Genders = "Male", Salary = 900000},
                new Employee(){Id = 109, Name = "Tania", Genders = "Female", Salary = 150000}
            };
            //Group by
            /*
            var res = employees.GroupBy(x => x.Genders).ToList();
            foreach(var item in res)
            {
                Console.WriteLine(item.Key + "\n");
                foreach(Employee e in item)
                {
                    Console.WriteLine(e.Name);
                }
                Console.WriteLine("==========================================================");
            }
            */

            //OrderBy
            var res1 = employees.OrderBy(x => x.Id).ToList();
            foreach (var item in res1)
            {
                Console.WriteLine(item.Id + " | " + item.Name);
            }
            Console.WriteLine("================ORDER BY ^^=============================");

            var res2 = employees.OrderByDescending(x => x.Id).ToList();
            foreach (var item in res2)
            {
                Console.WriteLine(item.Id + " | " + item.Name);
            }
            Console.WriteLine("================ORDER BY DESCENDING ^^============================");

            //ToLookUp
            var res3 = employees.ToLookup(x => x.Genders).ToList();
            foreach (var item in res3)
            {
                Console.WriteLine(item.Key + "\n");
                foreach (Employee e in item)
                {
                    Console.WriteLine(e.Name);
                }
                Console.WriteLine("=============TO LOOKUP ^^==============================");
            }
            //Average
            var res4 = employees.Average(x => x.Salary);
            Console.WriteLine(res4);
        }
    }
}