using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using RestWithDB.DBConnection;
using EmployeeRecords.DBConnection;
using EmployeeRecords.ViewModel;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace RestWithDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeDBContext db = new EmployeeDBContext();

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>();
            Microsoft.Data.SqlClient.SqlDataReader srdr = db.GetData("select * from NewEmployee");
            while (srdr.Read())
            {
                employees.Add(new Employee
                {
                    Name = (string)srdr["Name"],
                    Position = (string)srdr["EmployeeName"],
                    Salary = (int)srdr["Salary"]
                });
            }
            db.CloseConnection();
            return employees;
        }
    }
}