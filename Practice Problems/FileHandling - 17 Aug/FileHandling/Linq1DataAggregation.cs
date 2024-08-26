using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Linq1DataAggregation
    {
        public class Sales
        {
            public int CustomerID;
            public string PurchaseAmount;
        }

        public class SupportTickets
        {
            public int CustomerID;
            public int TicketCount;
        }

        public class Output
        {
            public int CustomerID;
            public string TotalPurchase;
            public int TicketCount;
        }

        public static void MainL1()
        {
            List<Sales> SalesTable = new List<Sales>();
            SalesTable.Add(new Sales { CustomerID = 101, PurchaseAmount = "200$" });
            SalesTable.Add(new Sales { CustomerID = 102, PurchaseAmount = "150$" });

            List<SupportTickets> SupportTicketTable = new List<SupportTickets> 
            { 
                new SupportTickets {CustomerID = 101, TicketCount = 3},
                new SupportTickets {CustomerID = 103, TicketCount = 1}
            };

            var Output = from Sales in SalesTable
                         join SupportTicket in SupportTicketTable on Sales.CustomerID equals SupportTicket.CustomerID into salesTickets
                         from SupportTicket in salesTickets.DefaultIfEmpty()
                         select new Output
                         {
                             CustomerID = Sales.CustomerID,
                             TotalPurchase = Sales.PurchaseAmount,
                             TicketCount = SupportTicket != null ? SupportTicket.TicketCount : 0
                         }
                         .Union(from SupportTicket1 in SupportTicketTable
                                join Sales in SalesTable on SupportTicket1.CustomerID equals Sales.CustomerID into ticketSales
                                from Sales in ticketSales.DefaultIfEmpty()
                                select new Output
                                {
                                    CustomerID = SupportTicket1.CustomerID,
                                    TotalPurchase = Sales != null ? Sales.PurchaseAmount : 0,
                                    TicketCount = SupportTicket1.TicketCount
                                });

            foreach (var item in Output)
            {
                Console.WriteLine(item.CustomerID + ", " + item.TotalPurchase + ", " + item.TicketCount);
            }
        }



    }
}
