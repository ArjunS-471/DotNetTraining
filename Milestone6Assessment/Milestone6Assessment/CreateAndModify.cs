using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Text;
using CsvHelper;

namespace Milestone6Assessment
{
    internal class CreateAndModify
    {
        static void Main2(string[] args)
        {
            //CSV READING PART TO TABLE
            var filePath = "TableData.csv";
            //Defining StreamReader and CSVReader
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture));

            //Initialising PDF
            string pdfPath = "SummaryReport.pdf";

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

                // Add a sample paragraph
                document.Add(new Paragraph("Summary Table").SetFontSize(18).SetBold());
                document.Add(new Paragraph(" "));

                //Initialising Table and its headings
                Table table = new Table(UnitValue.CreatePercentArray(2)).UseAllAvailableWidth(); // 2 columns with eaqual width
                table.AddHeaderCell(new Cell().Add(new Paragraph("Name").SetBackgroundColor(ColorConstants.LIGHT_GRAY)).SetBold().SetFontSize(14));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Amount").SetBackgroundColor(ColorConstants.LIGHT_GRAY)).SetBold().SetFontSize(14));
                
                //Getting data from CSV into a Variable
                var records = csv.GetRecords<dynamic>().ToList();
                foreach (var item in records)
                {
                    table.AddCell(item.Name).SetFontSize(14);
                    table.AddCell(item.Amount).SetFontSize(14);
                }

                //Adding table
                document.Add(table);
                document.Close();
            }

            Console.WriteLine("Table PDF is created!!");
        }
    }
}
