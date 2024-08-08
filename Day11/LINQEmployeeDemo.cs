using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary {  get; set; }
        public int DeptID { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
    internal class LINQEmployeeDemo
    {
        public static void Main()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id = "EMP1", Name = "Rooney", Salary = 80000, DeptID = 1});
            list.Add(new Employee() { Id = "EMP2", Name = "Ronaldo", Salary = 90000, DeptID = 1});
            list.Add(new Employee() { Id = "EMP3", Name = "Giggs", Salary = 40000, DeptID = 2});
            list.Add(new Employee() { Id = "EMP4", Name = "Scholes", Salary = 30000, DeptID = 3});
            list.Add(new Employee() { Id = "EMP5", Name = "Carrick", Salary = 10000, DeptID = 1});

            List<Department> listDepartment = new List<Department>();
            listDepartment.Add(new Department { Id = 1, DepartmentName = "IT" });
            listDepartment.Add(new Department { Id = 2, DepartmentName = "Admin" });
            listDepartment.Add(new Department { Id = 3, DepartmentName = "Sales" });
            listDepartment.Add(new Department { Id = 4, DepartmentName = "Security" });

            var result = from lisItem in list where lisItem.Salary > 10000 select lisItem; // Salary greater than 10000
            foreach (var item in result)
            {
                Console.WriteLine(item.Id +"   " + item.Name);
            }

            Console.WriteLine("===============================================================================================");

            var result2 = (from listItem in list join dept in listDepartment
                           on listItem.DeptID equals dept.Id where listItem.DeptID == 1
                           select new {ID = listItem.Id, Name = listItem.Name, DepartmentName = dept.DepartmentName}).ToList(); //Joining the 2 lists with common column DeptID and where DeptID = 1
            foreach (var item in result2)
            {
                Console.WriteLine(item.ID + " | " + item.Name + " | " + item.DepartmentName);
            }

        }
    }
}
