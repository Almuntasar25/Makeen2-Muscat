using System.Reflection;
using Microsoft.EntityFrameworkCore;
using online_shopping.Models;

namespace online_shopping.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Category> category { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<OrderItems> orderItems { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Reviews> reviews { get; set; }

        public DbSet<Customer> customers { get; set; }
        public DbSet<ShippingAddress> shippingAddress { get; set; }
        public DbSet<Payment_Information> payment_Information { get; set; }


    }
    

}

