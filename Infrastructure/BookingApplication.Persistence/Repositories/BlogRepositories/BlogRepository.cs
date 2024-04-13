using BookingApplication.Application.Interfaces.BlogInterfaces;
using BookingApplication.Domain.Entities;
using BookingApplication.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApplication.Persistence.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BookingApplicationContext _context;

        public BlogRepository(BookingApplicationContext context)
        {
            _context = context;
        }

        public async Task<Blog> GetBlogById(int id)
        {

            return await _context.Blogs.Include(x => x.BlogCategory).FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task<List<Blog>> GetBlogList()
        {
            return await _context.Blogs.Include(x => x.BlogCategory).ToListAsync();
        }


    }
}
