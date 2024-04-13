using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Application.Features.Mediator.Commands.BlogCategoryCommands
{
    public class CreateBlogCategoryCommand : IRequest
    {
        public string Name { get; set; }
    }
}
