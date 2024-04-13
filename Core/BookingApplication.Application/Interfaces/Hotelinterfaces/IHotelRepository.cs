using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Interfaces.Hotelinterfaces
{
    public interface IHotelRepository
    {
        List<Hotel> GetHotelListWithCurrency();
        Hotel GetHotelById(int id);
        List<Hotel> Get5Hotel();
        Task<List<Hotel>> GetByFilterAsync(Expression<Func<Hotel, bool>> filter);
    }
}
