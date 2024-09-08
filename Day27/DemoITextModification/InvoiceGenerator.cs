using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.Text;
using iText.Layout;
using iText.Layout.Properties;
using iText.Layout.Element;
using iText.Kernel.Geom;
using iText.Kernel.Colors;

namespace DemoITextModification
{
    internal class InvoiceGenerator
    {
        static void MainIG(string[] args)
        {

            string outputpdfPath = "Invoice.pdf";

            PdfWriter pdfWriter = new PdfWriter(outputpdfPath);
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            Document document = new Document(pdfDocument);
            string waterMarkText = "PAID";
            document.Add(new Paragraph("INVOICE").SetTextAlignment(TextAlignment.CENTER).SetFontSize(24).SetBold());

            //Company details
            document.Add(new Paragraph("Company Name: ABC E-Commenrce Ltd. \n Address: TVM 695583").SetFontSize(12).SetMarginBottom(10));
            document.Add(new Paragraph("Customer Name: Wayne Rooney \n Address: Manchester 123456").SetFontSize(12).SetMarginBottom(20));
            //Invoice details
            document.Add(new Paragraph("Invoice Number: INV4321 \n Invoice Date: " + System.DateTime.Now.ToString("MM/dd/yyyy")).SetFontSize(12).SetMarginBottom(20));

            Table table = new Table(new float[] { 4, 1, 2, 2 });// Column width
            table.SetWidth(UnitValue.CreatePercentValue(100));

            table.AddHeaderCell(new Cell().Add(new Paragraph("Item Description").SetBold()));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Quantity").SetBold()));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Price Per Item").SetBold()));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Total").SetBold()));

            table.AddCell(new Cell().Add(new Paragraph("Product 1")));
            table.AddCell(new Cell().Add(new Paragraph("2")));
            table.AddCell(new Cell().Add(new Paragraph("$20")));
            table.AddCell(new Cell().Add(new Paragraph("$40")));

            table.AddCell(new Cell().Add(new Paragraph("Product 2")));
            table.AddCell(new Cell().Add(new Paragraph("3")));
            table.AddCell(new Cell().Add(new Paragraph("$25")));
            table.AddCell(new Cell().Add(new Paragraph("$45")));

            table.AddCell(new Cell().Add(new Paragraph("Product 3")));
            table.AddCell(new Cell().Add(new Paragraph("4")));
            table.AddCell(new Cell().Add(new Paragraph("$30")));
            table.AddCell(new Cell().Add(new Paragraph("$50")));
            document.Add(table);

            document.Add(new Paragraph("\n Total Amount Due = $40").SetFontSize(14).SetBold().SetTextAlignment(TextAlignment.RIGHT).SetMarginTop(20));
            
            document.Close();

            AddPaidWaterMark();
        }

        public static void AddPaidWaterMark()
        {
            string inputpdfPath = "Invoice.pdf";
            string outputpdfPath = "Invoice_watermark.pdf";

            PdfReader pdfReader = new PdfReader(inputpdfPath, new ReaderProperties().SetPassword(Encoding.UTF8.GetBytes("owner123")));
            PdfWriter pdfWriter = new PdfWriter(outputpdfPath);
            PdfDocument pdfDocument = new PdfDocument(pdfReader, pdfWriter);

            int numberOfPages = pdfDocument.GetNumberOfPages();

            for (int i = 1; i <= numberOfPages; i++)
            {
                PdfPage page = pdfDocument.GetPage(i);
                Rectangle pageSize = page.GetPageSize();

                PdfCanvas canvas = new PdfCanvas(page);
                canvas.SaveState();
                canvas.SetFillColor(ColorConstants.LIGHT_GRAY);

                canvas.BeginText().SetFontAndSize(PdfFontFactory.CreateFont(StandardFonts.HELVETICA), 60).
                    SetTextMatrix(30,30).MoveText(page.GetPageSize().GetWidth()/4, page.GetPageSize().GetHeight()/2).ShowText("PAID").EndText();

            }
            pdfDocument.Close();
        }
    }
}
