using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muscat_international_airport.context
{
    public class passengers
    {
     

        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string date_of_birth { get; set; }
        public int nationality { get; set; }
        public int passport_number { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
    }
}


