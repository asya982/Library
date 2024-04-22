namespace Library.DataAccess.Models
{
    public enum RecordStatus
    {
        Open,
        Closed
    }

    public class Record
    {
        public Guid Id { get; set; }
        public string UserId { get; set; } // Foreign key to User
        public Guid BookId { get; set; } // Foreign key to Book
        public RecordStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property for User
        public User User { get; set; }

        // Navigation property for Book
        public Book Book { get; set; }
    }
}