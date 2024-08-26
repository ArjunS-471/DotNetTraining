using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Linq3TransfCleanup
    {
        public class Record
        {
            public int RecordID { get; set; }
            public DateTime? Date { get; set; }
            public int Value { get; set; }
        }

        public static void Main()
        {
            // Sample data
            var records = new List<Record>
            {
                new Record { RecordID = 1, Date = new DateTime(2024, 8, 1), Value = 100 },
                new Record { RecordID = 2, Date = null, Value = 200 },
                new Record { RecordID = 2, Date = new DateTime(2024, 8, 2), Value = 200 }
            };

            // Handle missing values
            var filledRecords = records.Select(record =>
            {
                if (record.Date == null)
                {
                    record.Date = DateTime.MinValue; // or another default value
                }
                return record;
            }).ToList();

            // Remove duplicates by taking the latest date for each RecordID
            var distinctRecords = filledRecords
                .GroupBy(r => r.RecordID)
                .Select(g => g.OrderByDescending(r => r.Date).First())
                .ToList();

            foreach (var record in distinctRecords)
            {
                Console.WriteLine($"RecordID: {record.RecordID}, Date: {record.Date:yyyy/MM/dd}, Value: {record.Value}");
            }
        }
    }
}
