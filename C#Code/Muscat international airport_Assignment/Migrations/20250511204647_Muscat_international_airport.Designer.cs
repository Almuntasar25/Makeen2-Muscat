﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Muscat_international_airport.Modle;


#nullable disable

namespace Muscat_international_airport.Migrations
{
    [DbContext(typeof(Application_DbContext))]
    [Migration("20250511204647_Muscat_international_airport")]
    partial class Muscat_international_airport
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Muscat_international_airport.context.Airlines", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("representative_name")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Airlines");
                });

            modelBuilder.Entity("Muscat_international_airport.context.AirportOfficer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AirportOfficer");
                });

            modelBuilder.Entity("Muscat_international_airport.context.Baggage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("passenger_id")
                        .HasColumnType("int");

                    b.Property<int>("tracking_number")
                        .HasColumnType("int");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Baggage");
                });

            modelBuilder.Entity("Muscat_international_airport.context.Checkpoint", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("AirportOfficer_id")
                        .HasColumnType("int");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("passenger_capacity")
                        .HasColumnType("int");

                    b.Property<int>("terminal_id")
                        .HasColumnType("int");

                    b.Property<string>("terminal_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Checkpoint");
                });

            modelBuilder.Entity("Muscat_international_airport.context.Flights", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Gate_number")
                        .HasColumnType("int");

                    b.Property<int>("airline_id")
                        .HasColumnType("int");

                    b.Property<int>("arrival_time")
                        .HasColumnType("int");

                    b.Property<string>("departure_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("departure_time")
                        .HasColumnType("int");

                    b.Property<string>("destination_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("flight_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Muscat_international_airport.context.Gates", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("airline_id")
                        .HasColumnType("int");

                    b.Property<int>("availability_status")
                        .HasColumnType("int");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("terminal_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Gates");
                });

            modelBuilder.Entity("Muscat_international_airport.context.Terminal", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Terminals");
                });

            modelBuilder.Entity("Muscat_international_airport.context.passengers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("date_of_birth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nationality")
                        .HasColumnType("int");

                    b.Property<int>("passport_number")
                        .HasColumnType("int");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("passengers");
                });
#pragma warning restore 612, 618
        }
    }
}
