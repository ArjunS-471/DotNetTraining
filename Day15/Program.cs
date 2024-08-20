using System.Text.Json;
using Newtonsoft.Json;

namespace Day15
{
    public class employee
    {
        public string EmpID { get; set; }
        public int ID { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public static void WriteData(string fileName, string jsonString)
        {
            File.WriteAllText(fileName, jsonString);
        }

        public static List<employee> ReadData(string fileName)
        {
            var jsonString = File.ReadAllText(fileName);
            //var employee = JsonSerializer.Deserialize<employee>(jsonString);
            var employee = JsonConvert.DeserializeObject <List<employee>>(jsonString);
            return employee;
        }

    }
    internal class Program
    {
        static void MainJSON(string[] args)
        {
            var employee = new employee()
            {
                EmpID = "EMP123",
                ID = 123,
                Gender = "Male",
                Name = "Arjun Sudarsanan",
                Salary = 9090
            };

            List<employee> employeesList = new List<employee>{ employee, new employee
            {
                EmpID = "EMP124",
                ID = 124,
                Gender = "Male",
                Name = "Adarsh Sudarsanan",
                Salary = 10000
            } };
            //string jsonString = JsonSerializer.Serialize(employee);
            string jsonString = JsonConvert.SerializeObject(employeesList);
            string fileName = "employeeNewton.json";



            employee.WriteData(fileName, jsonString);
            var EmployeeData = employee.ReadData(fileName);
            
            foreach (var item in EmployeeData) 
            {
                Console.WriteLine("Employee Data: " + item.Name);
            }
            
        }
    }
}