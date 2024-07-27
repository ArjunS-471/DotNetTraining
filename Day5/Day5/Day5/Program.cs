namespace Day5
{
    internal class Program
    {
            class Employee
        {
            public int Id;
            public String EmpName;
            public String EmpEmail;

            public Employee(int id, string Name, string Email)
            {
                Id = id;
                EmpName = Name;
                EmpEmail = Email;
            }

            public void PrintEmployeeData()
            {
                Console.WriteLine(Id);
                Console.WriteLine(EmpName);
                Console.WriteLine(EmpEmail);
            }
        }

        internal class Classesdemo
        {
            public static void MainL()
            {
                Employee employee = new Employee(1, "Arjun","Arjun.471@xyz.com");
                employee.PrintEmployeeData();

            }
        }
    }

}