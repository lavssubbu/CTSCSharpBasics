using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
   internal abstract class Flight
    {
        public int FlightNo { get; set; }
        public string FlightName { get; set; }

        public void FlightDetails()
        {
            Console.WriteLine(FlightNo+" "+FlightName);
        }
        public abstract void FareDetails();
    }
    class FareDet : Flight
    {
        public int BasicFare { get; set; }
        public override void FareDetails()
        {
           Console.WriteLine($"{BasicFare}");
        }
    }
}
