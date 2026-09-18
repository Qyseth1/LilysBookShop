namespace Shop.Models
{
    public class SaleItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        // Sale
        // FK
        public int SaleId { get; set; }

        // Navigation Property
        public Sale Sale { get; set; } = null!;

        // Book
        // FK
        public int BookId { get; set; }

        // Navigation Property
        public Book Book { get; set; } = null!;
    }
}
