namespace Shop.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public DateTime SaleDate { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<SaleItem> Items { get; set; }
            = new List<SaleItem>();
    }
}
