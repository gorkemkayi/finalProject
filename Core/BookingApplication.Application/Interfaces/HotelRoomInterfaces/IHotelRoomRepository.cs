using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Interfaces.HotelRoomInterfaces
{
    public interface IHotelRoomRepository
    {
        Task<List<HotelRoom>> GetByFilterAsync(Expression<Func<HotelRoom, bool>> filter);
    }
}
