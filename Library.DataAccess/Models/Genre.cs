﻿namespace Library.DataAccess.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // Navigation property for Books
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}