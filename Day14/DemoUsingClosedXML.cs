using ClosedXML.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class DemoUsingClosedXML
    {
        public static void Main()
        {
            var directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent;
            var filepath = directory + "\\excelfiles\\BookRecords.xlsx";

            var bookData = new[,]
            {
                {"BookName","ISBN","Author"},
                {"HP","749","JKR"},
                {"LOTR","465","RRT"},
                {"Tinkle","259","AMC"},
            };

            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Books");
                
                for (int row = 1; row < bookData.GetLength(0); row++)
                {
                    for (int col = 1; col < bookData.GetLength(1); col++)
                    {
                        workSheet.Cell(row + 1, col + 1).Value = bookData[row, col];
                    }
                }
                workbook.SaveAs(filepath);
            }

        }
    }
}
