using System.Data.SqlClient;

namespace Databases
{
    //Class created for binding data as a list
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    internal class Program
    {
        //Connection
        public static SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=1D0ECADE43FD5D3\\SQLEXPRESS;Initial Catalog=MilestoneDB;Integrated Security=True");
            return con;
        }

        //Getting data from SQL DB, binding it to List, looping the list to show items
        public static void GetData(SqlConnection con)
        {
            List<Employee> employees = new List<Employee>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee employee = new Employee 
                { 
                    Id = rdr.GetInt32(0),
                    Name = rdr.GetString(1),
                    Email = rdr.GetString(2)
                };
                employees.Add(employee);
            }
            con.Close();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Id + " | " + employee.Name + " | " + employee.Email);
            }
        }

        //Getting only required data from SQL DB, and writing it out
        public static void GetSingleData(int inputId, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"select * from Users where Id = {inputId}", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee employee = new Employee
                {
                    Id = rdr.GetInt32(0),
                    Name = rdr.GetString(1),
                    Email = rdr.GetString(2)
                };
                if (inputId == employee.Id) 
                {
                    Console.WriteLine(employee.Id + " | " + employee.Name + " | " + employee.Email);
                }
            }
            con.Close();
        }

        //Adding new data to DB
        public static void InsertData(string Name, string Email, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into Users (Name, Email) Values ('{Name}', '{Email}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Updating existing data in DB
        public static void UpdateData(int ID, string Name, string Email, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"update Users set Name = '{Name}', Email = '{Email}'  where Id = {ID}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Deleting existing data in DB
        public static void DeleteData(int ID, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"Delete Users where ID = '{ID}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        static void Main(string[] args)
        {
            //Connecting to DB
            SqlConnection conn = CreateConnection();
            CreateConnection();

            //Switch to call instances of the DB activities through an interface
            bool blnContinueLoop = true;
            while (blnContinueLoop)
            {
                Console.WriteLine("Please enter a choice");
                Console.WriteLine("Enter the operation you want to perform \n 1. List Employee \n 2. Insert Employee \n 3. Update Employee \n 4. Delete Employee \n 5. List Single Employee \n 6. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Display all data available in DB table
                        GetData(conn);
                        Console.WriteLine();
                        break;
                    case 2:
                        //Adding data to DB table
                        Console.WriteLine("Please enter employee Name");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("Please enter email Id");
                        string EmailId = Console.ReadLine();
                        InsertData(employeeName, EmailId, conn);
                        Console.WriteLine("New record added succesfully");
                        Console.WriteLine();
                        break;
                    case 3:
                        //Updating existing data in DB based on ID value
                        Console.WriteLine("Please enter employee ID");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter new employee Name");
                        string newEmployeeName = Console.ReadLine();
                        Console.WriteLine("Please enter new employee Email");
                        string newEmployeeEmail = Console.ReadLine();
                        UpdateData(ID, newEmployeeName, newEmployeeEmail, conn);
                        Console.WriteLine("Existing record updated succesfully");
                        Console.WriteLine();
                        break;
                    case 4:
                        //Deleting existing row in DB based on ID value
                        Console.WriteLine("Please enter employee ID");
                        int delID = Convert.ToInt32(Console.ReadLine());
                        DeleteData(delID, conn);
                        Console.WriteLine("Existing record deleted succesfully");
                        Console.WriteLine();
                        break;
                    case 5:
                        //Getting single item from DB based on ID -- READ functionality of single row
                        Console.WriteLine("Please enter employee ID");
                        int singleID = Convert.ToInt32(Console.ReadLine());
                        GetSingleData(singleID, conn);
                        Console.WriteLine();
                        break;
                    case 6:
                        //Exiting app
                        conn.Close();
                        Console.WriteLine("Exiting app");
                        blnContinueLoop = false;
                        break;
                    default:
                        //To handle invalid entry added in switch
                        Console.WriteLine("Please enter corect choice");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}