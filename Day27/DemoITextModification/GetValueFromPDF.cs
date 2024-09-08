using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Canvas.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoITextModification
{
    internal class GetValueFromPDF
    {
        public static string InvoiceNumber { get; private set; }
        public static string InvoiceDate { get; private set; }

        public static void Main()
        {
            string pdfPath = "invoice.pdf";
            string invoiceNumber = ExtractInvoiceNumber(pdfPath);
            //Console.WriteLine("Invoice number - " + invoiceNumber);

            string invoiceDate = ExtractInvoiceDate(pdfPath);
            //Console.WriteLine("Invoice date - " + invoiceDate);

            string invoiceAmount = ExtractTotalAmount(pdfPath);
            //Console.WriteLine("Invoice amount - " + invoiceAmount);

            Console.WriteLine("Your Invoice number " + invoiceNumber + " amounts to " + invoiceAmount);
            Console.WriteLine();
            ExtractTableFromPDF(pdfPath);
        }

        public static string ExtractInvoiceNumber(string pdfPath)
        {
            PdfReader pdfReader = new PdfReader(pdfPath);
            PdfDocument pdfDocument = new PdfDocument(pdfReader);
            string InvoiceNumberPattern = @"Invoice Number:\s*(\S+)";
            
            int numberOfPages = pdfDocument.GetNumberOfPages();

            for (int i = 1; i <= pdfDocument.GetNumberOfPages() ; i++)
            {
                string pageText = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(i));
                //Console.WriteLine("Full text - " + pageText);
                Match match = Regex.Match(pageText, InvoiceNumberPattern);
                if (match.Success)
                {
                    InvoiceNumber = match.Groups[1].Value;
                    break;
                }
            }
            pdfDocument.Close();
            return InvoiceNumber;
        }

        public static string ExtractInvoiceDate(string pdfPath)
        {
            PdfReader pdfReader = new PdfReader(pdfPath);
            PdfDocument pdfDocument = new PdfDocument(pdfReader);
            string InvoiceDatePattern = @"Invoice Date:\s*(\S+)";

            int numberOfPages = pdfDocument.GetNumberOfPages();

            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                string pageText = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(i));
                //Console.WriteLine("Full text - " + pageText);
                Match match = Regex.Match(pageText, InvoiceDatePattern);
                if (match.Success)
                {
                    InvoiceDate = match.Groups[1].Value;
                    break;
                }
            }
            pdfDocument.Close();
            return InvoiceDate;
        }

        public static string ExtractTotalAmount(string pdfPath)
        {
            PdfReader pdfReader = new PdfReader(pdfPath);
            PdfDocument pdfDocument = new PdfDocument(pdfReader);
            string InvoiceAmount = @"Total Amount Due =\s*(\S+)";

            int numberOfPages = pdfDocument.GetNumberOfPages();

            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                string pageText = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(i));
                //Console.WriteLine("Full text - " + pageText);
                Match match = Regex.Match(pageText, InvoiceAmount);
                if (match.Success)
                {
                    InvoiceAmount = match.Groups[1].Value;
                    break;
                }
            }
            pdfDocument.Close();
            return InvoiceAmount;
        }

        public static void ExtractTableFromPDF(string pdfPath)
        {
            PdfReader pdfReader = new PdfReader(pdfPath);
            PdfDocument pdfDocument = new PdfDocument(pdfReader);

            for (int i = 1; i <= pdfDocument.GetNumberOfPages(); i++)
            {
                string pageText = PdfTextExtractor.GetTextFromPage(pdfDocument.GetPage(i));
                ExtractTable(pageText);
            }

            pdfDocument.Close();
        }

        public static void ExtractTable(string pageText)
        {
            string tablePattern = @"Product\s*\d+\s*\d+\s*\$\d+\s*\$\d+";

            MatchCollection matched = Regex.Matches(pageText, tablePattern);
            foreach (Match item in matched)
            {
                string tableRow = item.Groups[0].Value;
                string[] colums = Regex.Split(tableRow.Trim(), @"\s{2,}");
                foreach (var column in colums)
                {
                    Console.Write(column + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
