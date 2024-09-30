using System;
using System.Formats.Asn1;
using System.Xml;
using System.Xml.Linq;
using CsvHelper;
using ClosedXML.Excel;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;


namespace ZomatoLikeApp
{
    public class review
    {
        public string restaurant { get; set; }
        public string reviewtext { get; set; }
        public int rating { get; set; }
    }
    public class ReviewList
    {
        public List<review> Reviews { get; set; }
    }

    public class Program
    {
        
        public static void Main(string[] args)
        {
            //1. XML Handling
            Console.WriteLine("XML Handling --------");
            var xmlFilePath = @"C:\Users\Administrator\Desktop\Course-Structure\Labs\Milestone4Assessment\ZomatoLikeApp\bin\Debug\net6.0\XMLFile.xml";
            XElement xmlDetails = XElement.Load(xmlFilePath);
            foreach(var details in xmlDetails.Elements("restaurant")) 
            {
                string name = details.Element("name")?.Value;
                string address = details.Element("address")?.Value;
                string rating = details.Element("rating")?.Value;
                Console.WriteLine(String.Format("Restaurant:{0}, Address: {1}, Rating: {2}",name,address,rating));
            }
            Console.WriteLine();

            //2. CSV Parsing
            Console.WriteLine("CSV Parsing --------");
            var csvFilePath = "C:\\Users\\Administrator\\Desktop\\Course-Structure\\Labs\\Milestone4Assessment\\ZomatoLikeApp\\bin\\Debug\\net6.0\\RestMenu.csv";
            using var reader = new StreamReader(csvFilePath);
            using var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture));
            var records = csv.GetRecords<dynamic>().ToList();
            foreach (var item in records)
            {
                Console.WriteLine("Item: " + item.Item + ", Price: " + item.Price);
            }
            Console.WriteLine();

            //3. Excel handling
            Console.WriteLine("Excel Handling --------");
            var xlsxFilepath = "C:\\Users\\Administrator\\Desktop\\Course-Structure\\Labs\\Milestone4Assessment\\ZomatoLikeApp\\bin\\Debug\\net6.0\\RestMenu.xlsx";

            //Write
            var bookData = new[,]
            {
                {"Name","Address","Rating"},
                {"Pasta House","456 Elm St","4.2"},
            };

            using (var workbook = new XLWorkbook())
            {
                var workSheet = workbook.Worksheets.Add("Restaurant");

                for (int row = 0; row < bookData.GetLength(0); row++)
                {
                    for (int col = 0; col < bookData.GetLength(1); col++)
                    {
                        workSheet.Cell(row + 1, col + 1).Value = bookData[row, col];
                    }
                }
                workbook.SaveAs(xlsxFilepath);
            }

            //Read
            using (var workbook = new XLWorkbook(xlsxFilepath))
            {
                var workSheet = workbook.Worksheet(1);
                Console.WriteLine("Read Restaurant: " + workSheet.Cell(2,1).GetValue<string>() + ", Address: " + workSheet.Cell(2, 2).GetValue<string>() + ", Rating: " + workSheet.Cell(2, 3).GetValue<string>());
                Console.WriteLine();
            }

            //4. JSON Handling
            Console.WriteLine("JSON Handling --------");
            var JsonFile = @"C:\Users\Administrator\Desktop\Course-Structure\Labs\Milestone4Assessment\ZomatoLikeApp\bin\Debug\net6.0\ReviewJson.txt";
            string jsonContent = File.ReadAllText(JsonFile);

            ReviewList reviewListData = JsonConvert.DeserializeObject<ReviewList>(jsonContent);

            foreach(var review in reviewListData.Reviews)
            {
                Console.WriteLine("Review for " + review.restaurant + ": " + review.reviewtext + ", Rating: " + review.rating);
            }
            Console.WriteLine();


            //5. REST API Implementation
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddApiVersioning(x =>
            {
                x.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                x.AssumeDefaultVersionWhenUnspecified = true;
                x.ReportApiVersions = true;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();


            //6. ServiceNowAPI call
            //7. Box API call
        }
    }
}