using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    interface IWholeSeller
    {
        public void Discount();
    }
    interface IRetailer
    {
        public void Discount();
    }
    class Demo : IWholeSeller, IRetailer
    {
        void IWholeSeller.Discount() {
            Console.WriteLine("Hi i am called from DEMO IWholeseller");
        }

        void IRetailer.Discount()
        {
            Console.WriteLine("Hi i am called from DEMO IRetailer");
        }
    }
    internal class MultipleInterfaceIssue
    {
        public static void Main1()
        {
            IWholeSeller demo = new Demo();
            demo.Discount();
            IRetailer demo1 = new Demo();
            demo1.Discount();
            Console.WriteLine();
        }
    }
}
