using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Interfaces.LocationInterfaces
{
    public interface ILocationRepository
    {
        Task<List<Location>> GetLocationList();
        Task<Location> GetLocationByID(int id);
    }
}
