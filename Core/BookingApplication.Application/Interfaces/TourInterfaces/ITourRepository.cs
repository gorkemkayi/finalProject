using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Interfaces.TourInterfaces
{
    public interface ITourRepository
    {
        Task<List<Tour>> GetTourList();
        Task<Tour> GetTourById(int id);
        Task<List<Tour>> GetPopularTours();
        Task<List<Tour>> GetByFilterAsync(Expression<Func<Tour,bool>>filter);
    }
}
