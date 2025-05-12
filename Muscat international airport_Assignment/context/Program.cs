using Muscat_international_airport.context;

namespace Muscat_international_airport.Modle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _Context = new Application_DbContext();
            var air1 = new Airlines
            {
                id = 1,
                name = "Ahmed",
                number = 98367845,
                representative_name = "Ali"
            };
            _Context.Airlines.Add(air1);
            _Context.SaveChanges();
        
        var _Context2 = new Application_DbContext();
        var airOff = new AirportOfficer
        {
            id = 1,
            first_name = "Ahmed",
            last_name = "Alamri",
            phone=9836743,
            email= "air@gmail.com",
            position="e",
            department="secyor"

        };
        _Context2.AirportOfficer.Add(airOff);
            _Context2.SaveChanges();
        }
        }
}
