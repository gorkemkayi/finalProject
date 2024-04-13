using BookingApplication.Application.Interfaces.TourInterfaces;
using BookingApplication.Domain.Entities;
using BookingApplication.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Persistence.Repositories.TourRepositories
{
    public class TourRepository : ITourRepository
    {
        private readonly BookingApplicationContext _context;

        public TourRepository(BookingApplicationContext context)
        {
            _context = context;
        }       

        public async Task<List<Tour>> GetPopularTours()
        {
            var values=_context.Tours.Include(x=>x.Currency).Include(x=>x.TourType).OrderByDescending(x=>x.Rating).Take(5).ToList();
            return values;
        }

        public async Task<Tour> GetTourById(int id)
        {
            return await _context.Tours.Include(x => x.Currency).Include(x => x.TourType).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Tour>> GetTourList()
        {
            return await _context.Tours.Include(x => x.Currency).Include(x => x.TourType).ToListAsync();
        }
        public async Task<List<Tour>> GetByFilterAsync(Expression<Func<Tour, bool>> filter)
        {
            var values = await _context.Tours.Where(filter).Include(x => x.Currency).Include(x => x.TourType).ToListAsync();
            return values;
        }
    }
}
