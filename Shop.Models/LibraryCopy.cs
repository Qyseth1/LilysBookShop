namespace Shop.Models
{
    public class LibraryCopy
    {
        public int Id { get; set; }

        public string InventoryNumber { get; set; } = "";

        public bool IsAvailable { get; set; } = true;

        // Foreign key
        public int BookId { get; set; }

        // Navigation property
        public Book Book { get; set; } = null!;

        // Navigation property
        public ICollection<Borrowing> Borrowings { get; set; }
            = new List<Borrowing>();
    }
}
