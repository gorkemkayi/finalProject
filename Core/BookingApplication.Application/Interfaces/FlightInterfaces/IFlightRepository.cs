using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Interfaces.FlightInterfaces
{
    public interface IFlightRepository
    {
        List<Flight> GetFlightList();
        Flight GetFlightById(int id);
        List<Flight> GetFeaturedFlights();
        Task<List<Flight>> GetByFilterAsync(Expression<Func<Flight,bool>>filter);
    }
}
