using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace XMLProblems
{
    internal class ExcelCLoseXML
    {
        public static void Main()
        {
            var workbook = new XLWorkbook(@"D:\Input\SalesData.xlsx");
            var sheet1 = workbook.Worksheet("Q1");
            var sheet2 = workbook.Worksheet("Q2");

            var sheet1Data = sheet1.RangeUsed().AsTable().Rows().ToList();
            var sheet2Data = sheet2.RangeUsed().AsTable().Rows().ToList();

            var output = workbook.AddWorksheet("Output");

            output.Cell(1, 1).Value = "Product";
            output.Cell(1, 2).Value = "Total Sales";
            output.Cell(1, 3).Value = "Average Sales";
            output.Cell(1, 4).Value = "Growth Rate";
            output.Cell(1, 5).Value = "Total Costs";
            output.Cell(1, 6).Value = "Total Discounts";
            output.Cell(1, 7).Value = "Net Profit";

            int row = 2;

            foreach(var sheet1Row in sheet1Data)
            {
                var product = sheet1Row.Cell(1).GetValue<string>();
                var sheet1Sales = sheet1Row.Cell(2).GetValue<int>();
                var sheet1Discount = sheet1Row.Cell(3).GetValue<int>();
                var sheet1Cost = sheet1Row.Cell(4).GetValue<int>();

                var sheet2Row = sheet2Data.FirstOrDefault(r => r.Cell(1).GetValue<string>() == product);
                if(sheet2Row != null)
                {
                    var sheet2Sales = sheet2Row.Cell(2).GetValue<int>();
                    var sheet2Discount = sheet2Row.Cell(3).GetValue<int>();
                    var sheet2Cost = sheet2Row.Cell(4).GetValue<int>();

                    var totalSales = sheet1Sales + sheet2Sales;
                    var totalDiscount = sheet1Discount + sheet2Discount;
                    var totalCost = sheet1Cost + sheet2Cost;

                    var averageSales = (sheet1Sales + sheet2Sales) / 2;
                    var growthRate = ((sheet2Sales - sheet1Sales) / totalSales) * 100;
                    var netProfit = totalSales - totalDiscount - totalCost;

                    output.Cell(row, 1).Value = product;
                    output.Cell(row, 2).Value = totalSales;
                    output.Cell(row, 3).Value = averageSales;
                    output.Cell(row, 4).Value = growthRate;
                    output.Cell(row, 5).Value = totalCost;
                    output.Cell(row, 6).Value = totalDiscount;
                    output.Cell(row, 7).Value = netProfit;

                    row++;
                }
            }

            workbook.Save();
        }
    }
}
