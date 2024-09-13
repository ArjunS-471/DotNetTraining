using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Milestone2Assessment.InheritanceCode;

//Inheritance
namespace Milestone2Assessment
{
    internal class InheritanceCode
    {
        //Base class
        public class Person
        {
            public string Name { get; set; }
            public string Email { get; set; }

            public Person(string name, string email)
            {
                Name = name;
                Email = email;
            }

            public void ShowDetails(Person person)
            {
                Console.WriteLine("Name of the person is {0} and email ID is {1}", person.Name, person.Email);
            }
        }

        //Inheritance 1
        public class  Customer : Person
        {
            public int ID { get; set; }
            public string Category { get; set; }

            public Customer(string name, string email, int id, string category) : base(name, email)
            {
                ID = id;
                Category = category;
            }

            public void ShowDetails()
            {
                Console.WriteLine("Customer details - ");
                Console.WriteLine("Name of the person is {0} and email ID is {1}, ID is {2}, Category is (3)", Name, Email, ID, Category);
            }
        }

        //Inheritance 2
        public class Admin : Person
        {
            public int ID { get; set; }
            public string Category { get; set; }

            public Admin(string name, string email, int id, string category) : base(name, email)
            {
                ID = id;
                Category = category;
            }

            public void ShowDetails()
            {
                Console.WriteLine("Admin details - ");
                Console.WriteLine("Name of the person is {0} and email ID is {1}, ID is {2}, Category is (3)", Name, Email, ID, Category);
            }
        }

        //Demonstration
        public static void Main2()
        {
            Customer customer = new Customer("Virat Kohli", "TestTrophy@notyet.com",18, "Former captain");
            Admin admin = new Admin("Rohit Sharma", "ODITrophy@notyet.com", 45, "Captain");

            customer.ShowDetails();
            admin.ShowDetails();
        }
    }
}
