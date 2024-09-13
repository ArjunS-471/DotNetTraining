using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Milestone2Assessment.Program;

//Polymorphism
namespace Milestone2Assessment
{
    //Order class
    public class Order
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public int PriceInt { get; set; }

        public Order(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        //Overloading
        public Order(string name, int price, int quantity)
        {
            Name = name;
            Price = Convert.ToDecimal(price);
            Quantity = quantity;
        }

        public virtual void CalculateTotal()
        {
            int Total = Convert.ToInt32(Price * Quantity);
            Console.WriteLine("Total = " + Total);
        }
    }

    //Inherited discounted class
    public class DiscountedOrder : Order
    {
        public int Discount { get; set; }

        public DiscountedOrder(string name, decimal price, int quantity, int discount) : base(name, price, quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Discount = discount;
        }
        //Method overriding
        public override void CalculateTotal()
        {
            int Total = Convert.ToInt32(Price * Quantity);
            Total = Total - (Total * Discount/100);
            Console.WriteLine("Discounted total - " + Total);
        }
    }

 
    internal class PolymorphismCode
    {
        public static void Main3()
        {
            //Normal execution
            Console.WriteLine("Normal method -----");
            Order order = new Order("Pen", 10, 10);
            order.CalculateTotal();

            DiscountedOrder disOrder = new DiscountedOrder("Pen", 10, 10, 5);
            disOrder.CalculateTotal();

            //Overloading
            Console.WriteLine("Method overloading -----");
            Order order2 = new Order("Pen", 10.5m, 10);
            order2.CalculateTotal();

            DiscountedOrder disOrder2 = new DiscountedOrder("Pen", 10.5m, 10, 5);
            disOrder2.CalculateTotal();

        }
        
    }
}
