using BookingApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Persistence.Context
{
    public class BookingApplicationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-KIO0LAGV\\SQLEXPRESS;initial catalog=BookingApplicationDb;integrated security=true");
            //optionsBuilder.UseSqlServer("Server=77.245.159.27\\MSSQLSERVER2019;database=finalprojectdb;user=bitirmeadmin;password=01200910Gr!");
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightType> FlightTypes { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourType> TourTypes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<FlightReservation> FlightReservations { get; set; }
        public DbSet<FlightProcess> FlightProcesses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<HotelReservation> HotelReservations { get; set; }
        public DbSet<TourReservation> TourReservations { get; set; }

    }
}
