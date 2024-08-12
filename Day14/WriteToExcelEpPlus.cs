using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

namespace Day14
{
    internal class WriteToExcelEpPlus
    {
        public static void MainWrite()
        {
            var directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent;
            var filepath = directory + "\\excelfiles\\PersonData.xlsx";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var peopleData = new [,]
            {
                {"FirstName","LastName","Age"},
                {"Rohit","Sharma","36"},
                {"Virat","Kohli","35"},
                {"Dhoni","Thala","42"},
            };

            using (var excelPackageObject = new ExcelPackage())
            {
                var workSheet = excelPackageObject.Workbook.Worksheets.Add("Cricket");
                for (int row = 0; row < peopleData.GetLength(0); row++)
                {
                    for (int col = 0; col < peopleData.GetLength(1); col++)
                    {
                        workSheet.Cells[row + 1, col + 1].Value = peopleData[row, col];
                    }
                }
                File.WriteAllBytes(filepath, excelPackageObject.GetAsByteArray());
            }

        }
    }
}
