namespace MK3_Task3
{
    internal class Program
    {

        public class Airplane
        {
            public string StartCity, FinishCity;
            public DateTimeOffset StartDate, FinishDate; //datetimeoffset
            public Airplane() { }
            public Airplane(string startCity, string finishCity, DateTimeOffset startDate, DateTimeOffset finishDate)
            {
                StartCity = startCity;
                FinishCity = finishCity;
                StartDate = startDate;
                FinishDate = finishDate;
            }

            public Airplane(string startCity, string finishCity) : this(startCity, finishCity, DateTimeOffset.MinValue, DateTimeOffset.MinValue)
            {
            }

            public Airplane(DateTimeOffset startDate, DateTimeOffset finishDate) : this("Germany", "Ukraine", startDate, finishDate)
            {
            }
            public Airplane(Airplane otherAirplane)
            {
                StartCity = otherAirplane.StartCity;
                FinishCity = otherAirplane.FinishCity;
                StartDate = otherAirplane.StartDate;
                FinishDate = otherAirplane.FinishDate;
            }

            public int GetTotalTime()
            {
                TimeSpan duration = FinishDate - StartDate;
                return (int)duration.TotalMinutes;
            }

            public bool IsArrivingToday()
            {
                return StartDate.Date == FinishDate.Date;
            }
        }

        static void PrintFlight(Airplane flight)
        {
            Console.WriteLine($"Flignt from {flight.StartCity} to {flight.FinishCity}");
            Console.WriteLine($"Total time(minutes): {flight.GetTotalTime()}");
            Console.WriteLine($"Arriving today? {flight.IsArrivingToday()}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Airplane flight1 = new Airplane("Frankfurt Hanh", "Tenerife", 
                new DateTimeOffset(2025, 9, 28, 8, 0, 0, TimeSpan.FromHours(+2)), new DateTimeOffset(2025, 10, 5, 18, 15, 0, TimeSpan.FromHours(+1)));
            
            Airplane flight2 = new Airplane("Warsaw", "Amsterdam");

            Airplane flight3 = new Airplane(flight1);

            Airplane flight4 = new Airplane(new DateTimeOffset(2026, 3, 1, 9, 15, 0, TimeSpan.FromHours(+2)),
                new DateTimeOffset(2026, 3, 1, 19, 0, 0, TimeSpan.FromHours(+1)));
            PrintFlight(flight1);
            PrintFlight(flight2);
            PrintFlight(flight3);
            PrintFlight(flight4);
        }
    }
}
