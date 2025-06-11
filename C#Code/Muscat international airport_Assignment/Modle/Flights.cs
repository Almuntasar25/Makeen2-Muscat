using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.context
{
    internal class Flights
    {
        

        public int id { get; set; }
        public string departure_city { get; set; }
        public string destination_city { get; set; }
        public int departure_time { get; set; }
        public int arrival_time { get; set; }
        public string flight_status { get; set; }
        public int airline_id { get; set; }
        public int Gate_number { get; set; }
    }
}