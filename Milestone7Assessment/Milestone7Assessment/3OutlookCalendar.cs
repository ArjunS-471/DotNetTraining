using System;
using System.Threading.Tasks;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.Graph;
using Microsoft.Identity.Client;

namespace Milestone7Assessment
{
    internal class _3OutlookCalendar
    {
        static void Main3(string[] args)
        {
            
            // Set up the EWS service
            var service = new ExchangeService(ExchangeVersion.Exchange2013_SP1)
            {
                Credentials = new WebCredentials("YOUR_EMAIL", "YOUR_PASSWORD"), // Use app password if 2FA is enabled
                Url = new Uri("https://outlook.office365.com/EWS/Exchange.asmx")
            };

            // Retrieve calendar events
            RetrieveCalendarEvents(service);
        }

        static void RetrieveCalendarEvents(ExchangeService service)
        {
            // Set the time window for events to retrieve
            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate.AddDays(30);

            // Create a view for the events
            var calendarView = new CalendarView(startDate, endDate);

            // Retrieve the events
            FindItemsResults<Appointment> results = service.FindAppointments(WellKnownFolderName.Calendar, calendarView);

            // Output the events
            Console.WriteLine("Upcoming Calendar Events:");
            foreach (var appointment in results)
            {
                Console.WriteLine($"Subject: {appointment.Subject}");
                Console.WriteLine($"Start: {appointment.Start}");
                Console.WriteLine($"End: {appointment.End}");
                Console.WriteLine($"Location: {appointment.Location}");
                Console.WriteLine();
            }
        }
    }
}
