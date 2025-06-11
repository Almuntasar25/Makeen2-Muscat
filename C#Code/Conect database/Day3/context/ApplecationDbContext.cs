using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeAcademyShope.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace CodeAcademyShope.context
{
     class ApplecationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DBCompany;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.HasDiscount)
                .HasDefaultValue(false)
                .IsRequired(false);

            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .IsRequired(false)
                .HasMaxLength(50);

        }


            public DbSet <Product> products { get; set; }
        public DbSet <Category> category { get; set; }
    }

    }

