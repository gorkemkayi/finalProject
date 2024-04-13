using BookingApplication.Application.Interfaces.LocationInterfaces;
using BookingApplication.Domain.Entities;
using BookingApplication.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Persistence.Repositories.LocationRepositories
{
    public class LocationRepository:ILocationRepository
    {
        private readonly BookingApplicationContext _context;

        public LocationRepository(BookingApplicationContext context)
        {
            _context = context;
        }

        public async Task<Location> GetLocationByID(int id)
        {
            return await _context.Locations.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<List<Location>> GetLocationList()
        {
            return await _context.Locations.ToListAsync();
        }
    }
}
