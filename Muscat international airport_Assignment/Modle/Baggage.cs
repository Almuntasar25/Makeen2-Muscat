using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.context
{
public class Baggage
    {
       
        public int id { get; set; }
        public int tracking_number { get; set; }
        public int weight { get; set; }
        public int passenger_id { get; set; }
    }
}
