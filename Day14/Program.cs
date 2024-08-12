using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using System.Reflection.PortableExecutable;


namespace Day14
{
    internal class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        static void Main1(string[] args)
        {
            var directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent;
            var filepath = directory + "\\csvfiles\\books.csv";

            List<Person> peopleList = new List<Person>
            {
                new Person{FirstName = "Vikash", LastName = "Verma", Age = 40},
                new Person{FirstName = "Satish", LastName = "Sharma", Age = 70}
            };

            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };
            using var writer = new StreamWriter(filepath);
            using var csv = new CsvWriter(writer, csvConfig);
            {
                csv.WriteRecords(peopleList);
            }
        }
    }
}