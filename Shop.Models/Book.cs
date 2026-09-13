namespace Shop.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string ISBN { get; set; } = "";

        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public int PublishedYear { get; set; }

        public decimal Price { get; set; }

        // Navigation properties
        public ICollection<LibraryCopy> LibraryCopies { get; set; }
            = new List<LibraryCopy>();

        public ICollection<ShopStock> ShopStocks { get; set; }
            = new List<ShopStock>();

        public ICollection<SaleItem> SaleItems { get; set; }
            = new List<SaleItem>();

        public ICollection<Author> Authors { get; set; }
            = new List<Author>();

        public ICollection<Category> Categories { get; set; }
            = new List<Category>();
    }
}
