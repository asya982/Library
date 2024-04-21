namespace Library.DataAccess.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        // Navigation property for Genre
        public Genre Genre { get; set; }

        // Navigation property for Records
        public ICollection<Record> Records { get; set; } = new List<Record>();
    }
}