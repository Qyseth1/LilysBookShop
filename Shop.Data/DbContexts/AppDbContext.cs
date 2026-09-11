using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
