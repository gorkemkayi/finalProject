using BookingApplication.Application.Interfaces.AppUserInterfaces;
using BookingApplication.Domain.Entities;
using BookingApplication.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Persistence.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly BookingApplicationContext _context;

        public AppUserRepository(BookingApplicationContext context)
        {
            _context = context;
        }

        public Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
