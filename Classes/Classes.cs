using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public enum RecordStatus
    {
        Open,
        Closed
    }


    internal class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }

        // Navigation property for Records
        public ICollection<Record> Records { get; set; }
    }

    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

        // Navigation property for Genre
        public Genre Genre { get; set; }

        // Navigation property for Records
        public ICollection<Record> Records { get; set; }
    }

    internal class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property for Books
        public ICollection<Book> Books { get; set; }
    }

    internal class Record
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign key to User
        public int BookId { get; set; } // Foreign key to Book
        public RecordStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property for User
        public User User { get; set; }

        // Navigation property for Book
        public Book Book { get; set; }
    }
}
