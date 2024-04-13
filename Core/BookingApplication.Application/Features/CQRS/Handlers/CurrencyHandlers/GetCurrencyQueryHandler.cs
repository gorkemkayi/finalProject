using BookingApplication.Application.Features.CQRS.Results.CurrencyResults;
using BookingApplication.Application.Interfaces;
using BookingApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.CQRS.Handlers.CurrencyHandlers
{
    public class GetCurrencyQueryHandler
    {
        private readonly IRepository<Currency> _repository;

        public GetCurrencyQueryHandler(IRepository<Currency> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCurrencyQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCurrencyQueryResult
            {
                ID = x.ID,
                Name = x.Name,
            }).ToList();
        }
    }
}
