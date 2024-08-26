using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;


class Program
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public Address Address { get; set; }
        public List<string> Projects { get; set; }
    }

    public class EmployeeData
    {
        public List<Employee> Employees { get; set; }
    }
    static void MainJSON()
    {
        var filePath = @"D:\Input\Employees.json";

        // Load JSON data
        var json = File.ReadAllText(filePath);
        var employeeData = JsonConvert.DeserializeObject<EmployeeData>(json);

        // Add employee
        var newEmployee = new Employee
        {
            ID = "E003",
            Name = "Alice Johnson",
            Department = "IT",
            Address = new Address
            {
                Street = "789 Oak St",
                City = "Springfield",
                State = "IL",
                Zip = "62703"
            },
            Projects = new List<string> { "Project D" }
        };
        employeeData.Employees.Add(newEmployee);

        // Update the address of employee E001
        var employeeE001 = employeeData.Employees.FirstOrDefault(e => e.ID == "E001");
        if (employeeE001 != null)
        {
            employeeE001.Address.Street = "321 Maple St";
            employeeE001.Address.Zip = "62701";
        }

        // Remove employees with fewer than 2 projects
        employeeData.Employees = employeeData.Employees
            .Where(e => e.Projects.Count >= 2)
            .ToList();

        // Add a new project to all employees' project lists and sort
        foreach (var employee in employeeData.Employees)
        {
            if (!employee.Projects.Contains("Project E"))
            {
                employee.Projects.Add("Project E");
            }
            employee.Projects = employee.Projects.OrderBy(p => p).ToList();
        }

        // Save the updated JSON data
        var updatedJson = JsonConvert.SerializeObject(employeeData, Formatting.Indented);
        File.WriteAllText(filePath, updatedJson);

        Console.WriteLine("JSON file updated.");
    }
}