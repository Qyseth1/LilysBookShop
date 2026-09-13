namespace Shop.Models
{
    public class ShopStock
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        // Foreign key
        public int BookId { get; set; }

        // Navigation property
        public Book Book { get; set; } = null!;
    }
}
