using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Linq2ReportingSystem
    {
        public class Sales
        {
            public int ProductID;
            public DateTime SalesDate;
            public int Amount;
        }

        public static void MainL2()
        {
            List<Sales> SalesTable = new List<Sales>();
            SalesTable.Add(new Sales { ProductID = 1, SalesDate = new DateTime(2024, 08, 01), Amount = 300 });
            SalesTable.Add(new Sales { ProductID = 2, SalesDate = new DateTime(2024, 08, 02), Amount = 450 });

            DateTime startDate = new DateTime(2024, 8, 1);
            DateTime endDate = new DateTime(2024, 8, 31);

            var dateRangeFilter = from sales in SalesTable where sales.SalesDate >= startDate && sales.SalesDate <= endDate select sales;

            Console.WriteLine("Filtered by date range");
            foreach (Sales sales in dateRangeFilter)
            {
                Console.WriteLine("Product ID: " + sales.ProductID + ", Amount: " + sales.Amount);
            }

            var amountFilter = from sales in SalesTable orderby sales.Amount descending select sales;

            Console.WriteLine("Sorted by amount");
            foreach (Sales sales in amountFilter)
            {
                Console.WriteLine("Product ID: " + sales.ProductID + ", Amount: " + sales.Amount);
            }

        }
    }
}
