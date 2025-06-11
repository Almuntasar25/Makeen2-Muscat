using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muscat_international_airport.context;

namespace Muscat_international_airport.Modle
{
	public class Application_DbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=Airport;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}

		public DbSet<Airlines>Airlines { get; set; }
        DbSet<Flights> Flights { get; set; }
        DbSet<Gates> Gates { get; set; }
        DbSet<passengers> passengers { get; set; }
        DbSet<Terminal> Terminals { get; set; }
        DbSet<Baggage> Baggage { get; set; }
        DbSet<Checkpoint> Checkpoint { get; set; }
        public DbSet<AirportOfficer> AirportOfficer { get; set; }
    }
}
