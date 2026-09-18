namespace Shop.Models
{
    public class Borrowing
    {
        public int Id { get; set; }

        public DateTime BorrowedAt { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ReturnedAt { get; set; }

        // User
        // FK User.Id
        public int UserId { get; set; }

        // Navigation Property
        public User User { get; set; } = null!;

        // Library copy
        //FK LibraryCopy.Id
        public int LibraryCopyId { get; set; }

        // Navigation Property
        public LibraryCopy LibraryCopy { get; set; } = null!;
    }
}
