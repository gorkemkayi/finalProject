using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Commands.BlogCategoryCommands
{
    public class RemoveBlogCategoryCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveBlogCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
