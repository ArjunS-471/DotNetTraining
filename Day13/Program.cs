using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Day13
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
        public static void Main1(string[] args)
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

            //Employee emp = new Employee() { Id = 102, Name = "Rohit", Genders = "Male", Salary = 200000 };
            //XmlSerializer x = new XmlSerializer(emp.GetType());
            //x.Serialize(Console.Out, emp);

            //XmlSerializer x = new XmlSerializer(employees.GetType());

            XmlWriter textWriter = XmlWriter.Create("C:\\Users\\Administrator\\Desktop\\Course-Structure\\Labs\\Day13\\xmlfiles\\EmployeeName.xml");

            textWriter.WriteStartElement("employee");
            textWriter.WriteElementString("ID","12");
            textWriter.WriteElementString("Name", "Kapil");
            textWriter.WriteElementString("Gender", "Male");
            textWriter.WriteElementString("Salary", "150201");
            textWriter.WriteEndDocument();
            textWriter.Flush();
            textWriter.Close();
            

        }
    }
}