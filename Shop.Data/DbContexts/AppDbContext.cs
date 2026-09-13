using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Borrowing> Borrowings => Set<Borrowing>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<LibraryCopy> LibraryCopies => Set<LibraryCopy>();
        public DbSet<Sale> Sales => Set<Sale>();
        public DbSet<SaleItem> SaleItems => Set<SaleItem>();
        public DbSet<ShopStock> ShopStocks => Set<ShopStock>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
