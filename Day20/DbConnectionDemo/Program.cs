using System.Data.SqlClient;

namespace DbConnectionDemo
{
    internal class Program
    {
        public static SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=1D0ECADE43FD5D3\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");
            return con;
        }

        public static void GetData(SqlConnection con) 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblEmployee", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr["ID"] + " | " + rdr["EmployeeName"]);
            }
            con.Close();
        }

        public static void InsertData(string EmployeeName, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into tblEmployee (EmployeeName) Values ('{EmployeeName}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void UpdateData(int empID, string EmployeeName, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"update tblEmployee set EmployeeName = '{EmployeeName}' where ID = {empID}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void DeleteData(int empID, SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"Delete tblEmployee where ID = '{empID}'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        static void Main(string[] args)
        {
            SqlConnection conn = CreateConnection();
            CreateConnection();

            bool blnContinueLoop = true;
            while (blnContinueLoop)
            {
                Console.WriteLine("Please enter a choice");
                Console.WriteLine("Enter the operation you want to perform \n 1. List Employee \n 2. Insert Employee \n 3. Update Employee \n 4. Delete Employee \n 5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GetData(conn);
                        break;
                    case 2:
                        Console.WriteLine("Please enter employee Name");
                        string employeeName = Console.ReadLine();
                        InsertData(employeeName, conn);
                        Console.WriteLine("New record added succesfully");
                        break;
                    case 3:
                        Console.WriteLine("Please enter employee ID");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter new employee Name");
                        string newEmployeeName = Console.ReadLine();
                        UpdateData(ID, newEmployeeName, conn);
                        Console.WriteLine("Existing record updated succesfully");
                        break;
                    case 4:
                        Console.WriteLine("Please enter employee ID");
                        int delID = Convert.ToInt32(Console.ReadLine());
                        DeleteData(delID, conn);
                        Console.WriteLine("Existing record deleted succesfully");
                        break;
                    case 5:
                        conn.Close();
                        Console.WriteLine("Exiting app");
                        blnContinueLoop = false;
                        break;
                    default:
                        Console.WriteLine("Please enter corect choice");
                        break;


                }
            }
            


        }
    }
}