﻿// <auto-generated />
using System;
using BookingApplication.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookingApplication.Persistence.Migrations
{
    [DbContext(typeof(BookingApplicationContext))]
    [Migration("20240401190548_mig14")]
    partial class mig14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookingApplication.Domain.Entities.Airline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Airlines");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.AppRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AppRoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.AppUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AppRoleId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AppRoleId");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BlogCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogCategoryId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.BlogCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Currency", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdultSeatPrice")
                        .HasColumnType("int");

                    b.Property<int>("AirlineID")
                        .HasColumnType("int");

                    b.Property<int>("AirportID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<int>("Baggage")
                        .HasColumnType("int");

                    b.Property<int>("CabinBaggage")
                        .HasColumnType("int");

                    b.Property<int>("ChildPrice")
                        .HasColumnType("int");

                    b.Property<string>("DepartureCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("FlightTypeID")
                        .HasColumnType("int");

                    b.Property<int>("InfantPrice")
                        .HasColumnType("int");

                    b.Property<string>("LandingCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirlineID");

                    b.HasIndex("AirportID");

                    b.HasIndex("FlightTypeID");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.FlightProcess", b =>
                {
                    b.Property<int>("FlightProcessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightProcessID"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("FlightId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FlightProcessID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FlightId");

                    b.ToTable("FlightProcesses");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.FlightReservation", b =>
                {
                    b.Property<int>("FlightReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightReservationID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlightID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlightReservationID");

                    b.HasIndex("FlightID");

                    b.ToTable("FlightReservations");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.FlightType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FlightTypes");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AgeRequirement")
                        .HasColumnType("int");

                    b.Property<string>("Cancellation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Checkin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Checkout")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrencyID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotemlAmentities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Policy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CurrencyID");

                    b.HasIndex("LocationID");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.HotelReservation", b =>
                {
                    b.Property<int>("HotelReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelReservationID"), 1L, 1);

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HotelRoomId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelReservationID");

                    b.HasIndex("HotelRoomId");

                    b.ToTable("HotelReservations");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.HotelRoom", b =>
                {
                    b.Property<int>("HotelRoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelRoomID"), 1L, 1);

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<string>("RoomImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomPrice")
                        .HasColumnType("int");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelRoomID");

                    b.HasIndex("HotelID");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Location", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Policy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<int>("TourAdultPrice")
                        .HasColumnType("int");

                    b.Property<int>("TourChildPrice")
                        .HasColumnType("int");

                    b.Property<int>("TourTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("TourTypeId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.TourType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TourTypes");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.AppUser", b =>
                {
                    b.HasOne("BookingApplication.Domain.Entities.AppRole", "AppRole")
                        .WithMany("AppUsers")
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppRole");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Blog", b =>
                {
                    b.HasOne("BookingApplication.Domain.Entities.BlogCategory", "BlogCategory")
                        .WithMany("Blogs")
                        .HasForeignKey("BlogCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogCategory");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Flight", b =>
                {
                    b.HasOne("BookingApplication.Domain.Entities.Airline", "Airline")
                        .WithMany("Flights")
                        .HasForeignKey("AirlineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingApplication.Domain.Entities.Airport", "Airport")
                        .WithMany("Flights")
                        .HasForeignKey("AirportID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingApplication.Domain.Entities.FlightType", "FlightType")
                        .WithMany("Flights")
                        .HasForeignKey("FlightTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airline");

                    b.Navigation("Airport");

                    b.Navigation("FlightType");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.FlightProcess", b =>
                {
                    b.HasOne("BookingApplication.Domain.Entities.Customer", "Customer")
                        .WithMany("FlightProcesses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingApplication.Domain.Entities.Flight", "Flight")
                        .WithMany("FlightProcesses")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.FlightReservation", b =>
                {
                    b.HasOne("BookingApplication.Domain.Entities.Flight", "Flight")
                        .WithMany("FlightReservations")
                        .HasForeignKey("FlightID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Hotel", b =>
                {
                    b.HasOne("BookingApplication.Domain.Entities.Currency", "Currency")
                        .WithMany("Hotels")
                        .HasForeignKey("CurrencyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingApplication.Domain.Entities.Location", "Location")
                        .WithMany("Hotels")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.HotelReservation", b =>
                {
                    b.HasOne("BookingApplication.Domain.Entities.HotelRoom", "HotelRoom")
                        .WithMany("HotelReservations")
                        .HasForeignKey("HotelRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelRoom");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.HotelRoom", b =>
                {
                    b.HasOne("BookingApplication.Domain.Entities.Hotel", "Hotel")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Tour", b =>
                {
                    b.HasOne("BookingApplication.Domain.Entities.Currency", "Currency")
                        .WithMany("Tours")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookingApplication.Domain.Entities.TourType", "TourType")
                        .WithMany("Tours")
                        .HasForeignKey("TourTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");

                    b.Navigation("TourType");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Airline", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Airport", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.AppRole", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.BlogCategory", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Currency", b =>
                {
                    b.Navigation("Hotels");

                    b.Navigation("Tours");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Customer", b =>
                {
                    b.Navigation("FlightProcesses");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Flight", b =>
                {
                    b.Navigation("FlightProcesses");

                    b.Navigation("FlightReservations");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.FlightType", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Hotel", b =>
                {
                    b.Navigation("HotelRooms");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.HotelRoom", b =>
                {
                    b.Navigation("HotelReservations");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.Location", b =>
                {
                    b.Navigation("Hotels");
                });

            modelBuilder.Entity("BookingApplication.Domain.Entities.TourType", b =>
                {
                    b.Navigation("Tours");
                });
#pragma warning restore 612, 618
        }
    }
}
