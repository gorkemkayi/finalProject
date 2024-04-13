using BookingApplication.Application.Interfaces.FlightInterfaces;
using BookingApplication.Domain.Entities;
using BookingApplication.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BookingApplication.Persistence.Repositories.FlightRepositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly BookingApplicationContext _context;

        public FlightRepository(BookingApplicationContext context)
        {
            _context = context;
        }

        public List<Flight> GetFlightList()
        {
            var values = _context.Flights.Include(x => x.Airline).Include(x => x.Airport).Include(x => x.FlightType).ToList();
            return values;
        }
        public Flight GetFlightById(int id)
        {
            var value = _context.Flights.Include(x => x.Airline).Include(x => x.Airport).Include(x => x.FlightType).FirstOrDefault(x => x.Id == id);
            return value;
        }

        public List<Flight> GetFeaturedFlights()
        {
            var values = _context.Flights.Include(x => x.Airline).Include(x => x.Airport).Include(x => x.FlightType).OrderByDescending(x=>x.Id).Take(5).ToList();
            return values;
        }

        public async Task<List<Flight>> GetByFilterAsync(Expression<Func<Flight, bool>> filter)
        {
            var values = await _context.Flights.Where(filter).Include(x => x.Airline).Include(x => x.Airport).Include(x => x.FlightType).ToListAsync();
            return values;
        }
    }
}
