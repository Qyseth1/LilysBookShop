namespace Shop.Models
{
    public class SaleItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        // Sale
        public int SaleId { get; set; }

        public Sale Sale { get; set; } = null!;

        // Book
        public int BookId { get; set; }

        public Book Book { get; set; } = null!;
    }
}
