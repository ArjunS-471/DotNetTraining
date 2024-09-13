using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

//Classes and Objects
namespace Milestone2Assessment
{
    internal class Program
    {
        //Product class
        public class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public string Category { get; set; }

            public Product(string name, int price, string category)
            {
                Name = name; Price = price; Category = category;
            }

            public override string ToString()
            {
                return String.Format("Name - {0}, Price - {1}, Category - {2}", Name,Price,Category);
            }
        }

        //User class
        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }

            public User(string username, string password, string email)
            {
                Username = username;
                Password = password;
                Email = email;
            }
            public override string ToString()
            {
                return String.Format("Username - {0}, Password - {1}, Email - {2}", Username, Password, Email);
            }
        }

        //Order class
        public class Order
        {
            public List<Product> Products { get; set; }
            public int Total => Products.Sum(p=>p.Price);

            public Order()
            {
                Products = new List<Product>();
            }

            public void AddProduct(Product product)
            {
                Products.Add(product);
            }

            public override string ToString()
            {
                string OutString = string.Empty;
                foreach (Product product in Products)
                {
                    OutString = OutString + product.ToString() + "\n";
                }
                return string.Format("List of items - \n{0}With Order Total - {1}", OutString, Total);
            }
        }

        //Demonstration
        static void Main1(string[] args)
        {
            //Product class
            Console.WriteLine("Product class");
            Product product1 = new Product("Pen", 10, "Stationary");
            Product product2 = new Product("Rice", 40, "Grocery");
            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine();

            //User class
            Console.WriteLine("User class");
            User user1 = new User("Virat Kohli", "ICCTestWorldCup", "TestTrophy@notyet.com");
            User user2 = new User("Rohit Sharma", "1MoreWorldCup", "ODITrophy@notyet.com");
            Console.WriteLine(user1);
            Console.WriteLine(user2);
            Console.WriteLine();

            //Order class
            Console.WriteLine("Order class");
            Order order = new Order();
            order.AddProduct(product1);
            order.AddProduct(product2);
            Console.WriteLine(order);
        }
    }
}
