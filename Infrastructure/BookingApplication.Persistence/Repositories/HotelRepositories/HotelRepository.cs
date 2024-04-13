using BookingApplication.Application.Interfaces.Hotelinterfaces;
using BookingApplication.Domain.Entities;
using BookingApplication.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Persistence.Repositories.HotelRepositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly BookingApplicationContext _context;

        public HotelRepository(BookingApplicationContext context)
        {
            _context = context;
        }

        public List<Hotel> GetHotelListWithCurrency()
        {
            var values = _context.Hotels.Include(x => x.Currency).Include(x=>x.Location).ToList();
            return values;
        }
        public Hotel GetHotelById(int id)
        {
            var value = _context.Hotels.Include(x => x.Currency).Include(x=>x.Location).FirstOrDefault(x => x.ID == id);
            return value;
        }

        //starsına göre en iyi 5 oteli listeler
        public List<Hotel> Get5Hotel()
        {
            var values=_context.Hotels.Include(x=>x.Currency).Include(x=>x.Location).OrderByDescending(x=>x.Stars).Take(5).ToList();
            return values;
        }

        public async Task<List<Hotel>> GetByFilterAsync(Expression<Func<Hotel, bool>> filter)
        {
            var values = await _context.Hotels.Where(filter).Include(x => x.Currency).Include(x => x.Location).ToListAsync();
            return values;
        }
    }
}
