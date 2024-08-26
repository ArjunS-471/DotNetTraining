using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace XMLProblems
{
    public class Shipment
    {
        public int ShipmentID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public double Weight { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
    }

    internal class CSVParse
    {
        static void MainCSV()
        {
            var csvFilePath = @"D:\Input\TestCSV.csv";
            var shipments = ParseCsv(csvFilePath);

            // Calculate total weight
            double totalWeight = shipments.Sum(s => s.Weight);
            Console.WriteLine($"Total Weight: {totalWeight}");

            // Calculate average weight
            double averageWeight = shipments.Average(s => s.Weight);
            Console.WriteLine($"Average Weight: {averageWeight}");

            // Determine the highest weight shipment
            var highestWeightShipment = shipments.OrderByDescending(s => s.Weight).First();
            Console.WriteLine($"Highest Weight Shipment Details:\n" +
                              $"ShipmentID: {highestWeightShipment.ShipmentID}\n" +
                              $"Origin: {highestWeightShipment.Origin}\n" +
                              $"Destination: {highestWeightShipment.Destination}\n" +
                              $"Weight: {highestWeightShipment.Weight}\n" +
                              $"Date: {highestWeightShipment.Date.ToShortDateString()}\n" +
                              $"Status: {highestWeightShipment.Status}");

            // Calculate percentage of on-time deliveries
            int totalShipments = shipments.Count;
            int onTimeShipments = shipments.Count(s => s.Status == "On Time");
            double percentageOnTime = (onTimeShipments / (double)totalShipments) * 100;
            Console.WriteLine($"Percentage of On-Time Deliveries: {percentageOnTime:F2}%");
        }

        static List<Shipment> ParseCsv(string filePath)
        {
            var shipments = new List<Shipment>();

            // Read all lines from the file
            var lines = File.ReadAllLines(filePath);

            // Skip the header line
            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');

                // Parse each line into a Shipment object
                var shipment = new Shipment
                {
                    ShipmentID = int.Parse(values[0]),
                    Origin = values[1],
                    Destination = values[2],
                    Weight = double.Parse(values[3]),
                    Date = DateTime.ParseExact(values[4], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Status = values[5]
                };

                shipments.Add(shipment);
            }

            return shipments;
        }
    }
}
