using BookingApplication.Application.Features.CQRS.Queries.CurrencyQueries;
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
    public class GetCurrencyByIdQueryHandler
    {
        private readonly IRepository<Currency> _repository;

        public GetCurrencyByIdQueryHandler(IRepository<Currency> repository)
        {
            _repository = repository;
        }

        public async Task<GetCurrencyByIdQueryResult> Handle(GetCurrencyByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetCurrencyByIdQueryResult
            {
                ID = value.ID,
                Name = value.Name,
            };
        }
    }
}
