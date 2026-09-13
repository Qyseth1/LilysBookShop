namespace Shop.Models
{
    public class Borrowing
    {
        public int Id { get; set; }

        public DateTime BorrowedAt { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnedAt { get; set; }

        // User
        public int UserId { get; set; }

        public User User { get; set; } = null!;

        // Library copy
        public int LibraryCopyId { get; set; }

        public LibraryCopy LibraryCopy { get; set; } = null!;
    }
}
