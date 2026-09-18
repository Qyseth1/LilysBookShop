namespace Shop.Models
{
    public class Author
    { 
        // Ids are Primary keys
        public int Id { get; set; }

        public string Name { get; set; } = "";

        // Navigation Property
        // (Navigation properties are properties that allow you to move from one entity to related entities.)
        public ICollection<Book> Books { get; set; }
            = new List<Book>();
    }
}
