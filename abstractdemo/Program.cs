using System;

namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flight ft = new FareDet() { FlightNo = 123, FlightName = "AirIndia", BasicFare = 8000 };

            FareDet faredt = new FareDet() { FlightNo = 123, FlightName = "AirIndia", BasicFare = 8000 };

            faredt.FlightDetails();
            faredt.FareDetails();
        }
    }
}
