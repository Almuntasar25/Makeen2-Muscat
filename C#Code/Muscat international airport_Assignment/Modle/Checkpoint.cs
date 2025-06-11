using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.context
{
    public class Checkpoint
    {
       

        public int id { get; set; }
        public int passenger_capacity { get; set; }
        public string location { get; set; }
        public int terminal_id { get; set; }
        public string terminal_name { get; set; }
        public int AirportOfficer_id { get; set; }
    }
}
