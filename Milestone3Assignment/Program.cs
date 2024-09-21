using System.Text.RegularExpressions;

namespace Milestone3Assignment
{
    internal class Program
    {
 #region AbstractClassesAndMethods

        public abstract class Flight
        {
            public string FlightNumber { get; set; }
            public string Destination { get; set; }
            public decimal BaseFare { get; set; }

            public abstract decimal CalculateFare();
            public abstract void DisplayDetails();
        }

        public class DomesticFlight : Flight
        {
            public override decimal CalculateFare()
            {
                return BaseFare + 50;
            }
            public override void DisplayDetails()
            {
                Console.WriteLine("Domestic flight details - ");
                Console.WriteLine("Flight number - " + FlightNumber);
                Console.WriteLine("Destination - " + Destination);
                Console.WriteLine("Fare - " + CalculateFare());
            }
        }

        public class InternationalFlight : Flight
        {
           public override decimal CalculateFare()
            {
                return BaseFare + 100;
            }
            public override void DisplayDetails()
            {
                Console.WriteLine("International flight details - ");
                Console.WriteLine("Flight number - " + FlightNumber);
                Console.WriteLine("Destination - " + Destination);
                Console.WriteLine("Fare - " + CalculateFare());
            }
        }
        #endregion

 #region InterfacesInDepth

        public class Passenger
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }

        public class Booking
        {
            public int BookingID { get; set; }
            public Flight Flight { get; set; }
            public Passenger Passenger { get; set; }
        }

        public interface IBooking
        {
            void BookTicket(Flight flight, Passenger passenger);
            void CancelBooking(int bookingId);
            void GetBookingDetails(int bookingId);
        }

        //Introduction to LINQ implementation
        public class OnlineBooking : IBooking
        {
            private List<Booking> bookings = new List<Booking>();
            public void BookTicket(Flight flight, Passenger passenger)
            {
                var booking = new Booking { BookingID = bookings.Count + 1, Flight = flight, Passenger = passenger };
                bookings.Add(booking);
                Console.WriteLine("Ticket booked online");
            }
            public void CancelBooking(int bookingId)
            {
                var booking = bookings.FirstOrDefault(b => b.BookingID == bookingId);
                if(booking != null)
                {
                    bookings.Remove(booking);
                    Console.WriteLine("Booking cancelled");
                }
            }
            public Booking GetBookingDetails(int bookingId)
            {
                return bookings.FirstOrDefault(b => b.BookingID == bookingId);
            }

            void IBooking.GetBookingDetails(int bookingId)
            {
                throw new NotImplementedException();
            }
        }

        public class AgencyBooking : IBooking
        {
            private List<Booking> bookings = new List<Booking>();
            public void BookTicket(Flight flight, Passenger passenger)
            {
                var booking = new Booking { BookingID = bookings.Count + 1, Flight = flight, Passenger = passenger };
                bookings.Add(booking);
                Console.WriteLine("Ticket booked through Agency");
            }
            public void CancelBooking(int bookingId)
            {
                var booking = bookings.FirstOrDefault(b => b.BookingID == bookingId);
                if (booking != null)
                {
                    bookings.Remove(booking);
                    Console.WriteLine("Booking cancelled");
                }
            }
            public Booking GetBookingDetails(int bookingId)
            {
                return bookings.FirstOrDefault(b => b.BookingID == bookingId);
            }

            void IBooking.GetBookingDetails(int bookingId)
            {
                throw new NotImplementedException();
            }
        }

        #endregion

 #region FlightDataManagement
        public class FlightManagement
        {
            private Flight[] fixedFlights = new Flight[5];
            private List<Flight> dynamicFlights = new List<Flight>();

            public void AddFlight(Flight flight)
            {
                for (int i = 0;i<fixedFlights.Length; i++)
                {
                    if (fixedFlights[i] == null)
                    {
                        fixedFlights[i] = flight;
                        return;
                    }
                }
                dynamicFlights.Add(flight);
            }

            public void RemoveFlight(string flightNumber)
            {
                for(int i = 0;i<fixedFlights.Length; i++)
                {
                    if (fixedFlights[i].FlightNumber == flightNumber)
                    {
                        fixedFlights[i] = null;
                        return;
                    }
                }
                dynamicFlights.RemoveAll(f => f.FlightNumber == flightNumber);
            }

            public void DisplayAllFlights()
            {
                foreach(var flight in fixedFlights.Where(f=>f != null)) 
                { 
                    flight.DisplayDetails();
                }
                foreach(var flight in dynamicFlights)
                {
                    flight.DisplayDetails();
                }
            }

            //LINQ Operations
            public IEnumerable<Flight> GetFlightsByDestination(string Destination)
            {
                return fixedFlights.Concat(dynamicFlights).Where(f => f.Destination.Equals(Destination, StringComparison.OrdinalIgnoreCase));
            }

            public IEnumerable<Flight> GetFlightsSortedByFare()
            {
                return fixedFlights.Concat(dynamicFlights).Where(f=> f != null).OrderBy(f => f.CalculateFare());
            }

            public IEnumerable<IGrouping<string, Flight>> GetFlightsByCategory()
            {
                return fixedFlights.Concat(dynamicFlights).GroupBy(f => f is DomesticFlight ? "Domestic" : "International");
            }
        }
        #endregion

 #region CSVFile
        //CSV file
        public class FlightFileManager
        {
            public void ReadFlightsFromCsv(string filePath, FlightManagement flightManagement)
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    Flight flight;
                    if (parts[0].StartsWith("FL"))
                    {
                        flight = new DomesticFlight { FlightNumber = parts[0], Destination = parts[1], BaseFare = decimal.Parse(parts[2]) };
                    }
                    else
                    {
                        flight = new InternationalFlight { FlightNumber = parts[0], Destination = parts[1], BaseFare = decimal.Parse(parts[2]) };
                    }
                    flightManagement.AddFlight(flight);
                }
            }
            public void WriteFlightsToCsv(string filePath, FlightManagement flightManagement)
            {
                using (var writer = new StreamWriter(filePath))
                {
                    foreach(var flight in flightManagement.GetFlightsSortedByFare())
                    {
                        Console.WriteLine("Number - " + flight.FlightNumber);
                        Console.WriteLine("Destination - " + flight.Destination);
                        Console.WriteLine("Destination - " + flight.BaseFare);
                        writer.WriteLine($"{flight.FlightNumber}, {flight.Destination}, {flight.BaseFare}");
                    }
                }
            }
        }
        #endregion

 #region Regex
        //Regex validation
        public class InputValidator
        {
            public static bool ValidateFlightNumber(string flightNumber)
            {
                return Regex.IsMatch(flightNumber, @"^FL\d{4}$");
            }
            public static bool ValidateEmail(string email)
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            }
            public static bool ValidatePhoneNumber(string phone)
            {
                return Regex.IsMatch(phone, @"^\+?\d{10,15)$");
            }
        }
        #endregion

        //Demonstration of possible use case
        public static void Main(string[] args)
        {
            //Add flight details
            var flightManagement = new FlightManagement();
            flightManagement.AddFlight(new DomesticFlight { FlightNumber = "FL1001", Destination = "New Delhi", BaseFare = 100 });
            flightManagement.AddFlight(new InternationalFlight { FlightNumber = "FL2001", Destination = "London", BaseFare = 1000 });
            Console.WriteLine("Added flight details");
            Console.WriteLine("");
            
            //Add passenger details
            Console.WriteLine("Getting flight details - ");
            var passenger = new Passenger { Name = "Virat Kohli", Email = "virat.kohli@abc.com", Phone = "+12345678910" };
            IBooking onlineBooking = new OnlineBooking();
            onlineBooking.BookTicket(flightManagement.GetFlightsByDestination("New Delhi").First(), passenger);
            Console.WriteLine("");

            //Displaying flight details
            Console.WriteLine("Displaying flight details - ");
            flightManagement.DisplayAllFlights();
            Console.WriteLine("");

            //CSV Operations
            var fileManager = new FlightFileManager();
            fileManager.WriteFlightsToCsv("flights.csv", flightManagement);
            Console.WriteLine("Written to CSV");
            fileManager.ReadFlightsFromCsv("flights.csv", flightManagement);
            Console.WriteLine("Read CSV");
            Console.WriteLine("");

            //Cancelling flight
            Console.WriteLine("Cancelling flight - ");
            flightManagement.RemoveFlight("FL2001");

            //Displaying flight details again
            Console.WriteLine("Displaying flight details - ");
            flightManagement.DisplayAllFlights();
            Console.WriteLine("");
        }
    }
}
