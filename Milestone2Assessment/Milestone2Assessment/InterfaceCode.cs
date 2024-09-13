using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone2Assessment
{
    //Interface
    public interface IOrderProcessor
    {
        void ProcessOrder(int orderId);
        void CancelOrder(int orderId);
    }

    //Implement 1
    public class PaymentProcessor : IOrderProcessor
    {
        public void ProcessOrder(int orderId) 
        {
            Console.WriteLine("Processing the order " + orderId);
        }

        public void CancelOrder(int orderId)
        {
            Console.WriteLine("Cancelling the order " + orderId);
        }
    }

    //Implement 2
    public class ShippingProcessor : IOrderProcessor
    {
        public void ProcessOrder(int orderId)
        {
            Console.WriteLine("Shipping the order " + orderId);
        }

        public void CancelOrder(int orderId)
        {
            Console.WriteLine("Cancelling shipping of the order " + orderId);
        }
    }

    //Demonstration
    internal class InterfaceCode
    {
        public static void Main()
        {
            IOrderProcessor paymentprocessor = new PaymentProcessor();
            IOrderProcessor shippingprocessor = new ShippingProcessor();

            int OrderId = 100;

            paymentprocessor.ProcessOrder(OrderId);
            shippingprocessor.ProcessOrder(OrderId);
            paymentprocessor.CancelOrder(OrderId);
            shippingprocessor.CancelOrder(OrderId);

        }
    }
}
