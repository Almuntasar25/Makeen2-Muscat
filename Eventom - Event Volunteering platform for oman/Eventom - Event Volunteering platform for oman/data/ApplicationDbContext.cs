using Eventom___Event_Volunteering_platform_for_oman.Models;
using Microsoft.EntityFrameworkCore;

namespace Eventom___Event_Volunteering_platform_for_oman.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Event> events { get; set; }
        public DbSet<Volunteers> volunteers { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Ratings> ratings { get; set; }
        public DbSet<ErrorViewModel> errorViewModel { get; set; }
        public DbSet<Applications> applications { get; set; }
        public DbSet<Committees> committees { get; set; }
     

    }
}
