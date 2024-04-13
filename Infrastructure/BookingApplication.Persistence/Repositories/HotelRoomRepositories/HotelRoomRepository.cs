using BookingApplication.Application.Interfaces.HotelRoomInterfaces;
using BookingApplication.Domain.Entities;
using BookingApplication.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Persistence.Repositories.HotelRoomRepositories
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly BookingApplicationContext _context;

        public HotelRoomRepository(BookingApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<HotelRoom>> GetByFilterAsync(Expression<Func<HotelRoom, bool>> filter)
        {
            var values=await _context.HotelRooms.Where(filter).Include(x=>x.Hotel).ToListAsync();
            return values;
        }
    }
}
