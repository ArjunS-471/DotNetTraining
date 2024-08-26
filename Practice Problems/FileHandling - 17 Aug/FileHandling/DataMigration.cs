using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace FileHandling
{
    internal class DataMigration
    {
        public static void MainDB()
        {
            SqlConnection con = new SqlConnection("Data Source=1D0ECADE43FD5D3\\SQLEXPRESS;Initial Catalog=DotNet;Integrated Security=True");

            string strCSVPath = @"D:\Input\SampleCSV.csv";
            using var reader = new StreamReader(strCSVPath);
            var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture) 
            { 
                Delimiter = "|"
            };
            
            using var csv = new CsvReader(reader, config);
            var records = csv.GetRecords<dynamic>().ToList();
            
            con.Open();
            
            foreach (var item in records)
            {
                Console.WriteLine(item.Name + " | " + item.Email + " | " + item.Phone);
                SqlCommand cmd = new SqlCommand($"insert into Customers (Name, Email, Phone) Values ('{item.Name}','{item.Email}','{item.Phone}')", con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
