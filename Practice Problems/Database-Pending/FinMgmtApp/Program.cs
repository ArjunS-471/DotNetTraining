using System;
using System.Data.SqlClient;

namespace FinMgmtApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = "Data Source=1D0ECADE43FD5D3\\SQLEXPRESS;Initial Catalog=Practise;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string insertQuery = "INSERT INTO Transactions (TransactionDate, Amount, Type, Description) " + "VALUES (@TransactionDate, @Amount, @Type, @Description)";

                SqlCommand sqlCommand = new SqlCommand(insertQuery, conn);
                sqlCommand.Parameters.AddWithValue("@TransactionDate", DateTime.Now);
                sqlCommand.Parameters.AddWithValue("@Amount", 150.00);
                sqlCommand.Parameters.AddWithValue("@Type", "Credit");
                sqlCommand.Parameters.AddWithValue("@Description", "Payment received");

                conn.Open();
                int output = sqlCommand.ExecuteNonQuery();
                if (output > 0)
                {
                    Console.WriteLine("Transaction inserted successfully");
                }
            }
        }
    }
}