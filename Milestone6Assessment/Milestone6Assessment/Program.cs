using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Text;

namespace Milestone6Assessment
{
    //Part 1 - Intro to iTextSharp for PDF Manipulation
    internal class Program
    {
        static void Main1(string[] args)
        {
            string pdfPath = "SalesReport.pdf";

            using (FileStream fs = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // Initialize PdfWriter with encryption
                WriterProperties writerProps = new WriterProperties()
                    .SetStandardEncryption(
                        Encoding.UTF8.GetBytes("user123"),
                        Encoding.UTF8.GetBytes("owner123"),
                        EncryptionConstants.ALLOW_PRINTING | EncryptionConstants.ALLOW_COPY,
                        EncryptionConstants.ENCRYPTION_AES_256
                    );

                // Initialize a new PdfDocument
                PdfWriter writer = new PdfWriter(fs, writerProps);
                PdfDocument pdfDocument = new PdfDocument(writer);

                // Initialize a Document for layout
                Document document = new Document(pdfDocument);

                // Add title
                document.Add(new Paragraph("Monthly Sales Report").SetFontSize(18).SetBold());
                // Add text
                document.Add(new Paragraph("Total Sales: $10,000"));

                // Add image
                Image img = new Image(ImageDataFactory.Create(@"C:\images\sales_chart.png"));
                img.SetMaxWidth(200);
                img.SetMaxHeight(200);
                document.Add(img);

                document.Close();
            }

            Console.WriteLine("PDF is created!!");
        }
    }
}