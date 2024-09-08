using Microsoft.Data.SqlClient;

namespace EmployeeRecords.DBConnection
{
    public class EmployeeDBContext
    {
        SqlConnection _connection;

        public EmployeeDBContext()
        {
            _connection = new
           SqlConnection("Data Source=1D0ECADE43FD5D3\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;Trust Server Certificate=True");
        }
        public SqlDataReader GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, _connection);
            _connection.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
        public void CloseConnection()
        {
            _connection.Close();
        }
        ~EmployeeDBContext()
        {
            _connection.Close();
        }
    }
}
