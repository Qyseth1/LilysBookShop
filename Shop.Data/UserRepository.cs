using Microsoft.EntityFrameworkCore;
using Shop.Data.DbContexts;
using Shop.Models;

namespace Shop.Data
{
    public class UserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
