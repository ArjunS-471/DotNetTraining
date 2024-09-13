using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Milestone2Assessment
{
    //Product class
    public class Product
    {
        //Private fields
        private string _Name;
        private int _Price;
        
        //Public properties
        public string Name { get { return _Name; } private set { _Name = value; } }
        public int Price { get { return _Price; } private set { _Price = value; } }
        
        //Constructors
        public Product(string name, int price)
        {
            Name = name; Price = price;
        }

        //Method to update price
        public void UpdatePrice(string name, int price)
        {
            Name = name; Price = price;
        }
    }

    //User class
    public class User
    {
        //Private fields
        private string _Username;
        private string _Email;

        //Public properties
        public string Username { get { return _Username; } private set { _Username = value; } }
        public string Email { get { return _Email; } private set { _Email = value; } }

        //Constructor
        public User(string username, string email)
        {
            Username = username; Email = email;
        }

        //Method to update details
        public void UpdateDetails(string username, string email)
        {
            Username = username; Email = email;
        }
    }
    internal class EncapsulationCode
    {
        //Demonstration
        public static void Main4()
        {
            //Product
            Console.WriteLine("Product class");
            Product product = new Product("Pen", 10);
            Console.WriteLine("Initial - " + product.Name + ", " + product.Price) ;
            product.UpdatePrice("Book", 20);
            Console.WriteLine("Updated - " + product.Name + ", " + product.Price);
            Console.WriteLine();

            //User
            Console.WriteLine("User class");
            User user = new User("Kohli", "TestTrophy@notyet.com");
            Console.WriteLine("Initial - " + user.Username + ", " + user.Email);
            user.UpdateDetails("Rohit", "ODITrophy@notyet.com");
            Console.WriteLine("Updated - " + user.Username + ", " + user.Email);
        }
    }
}
