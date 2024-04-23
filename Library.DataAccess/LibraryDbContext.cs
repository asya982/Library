using Library.DataAccess.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class LibraryDbContext : IdentityDbContext<User>
    {
        public LibraryDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            InitializeBookList();
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Record> Records { get; set; }

        private List<Genre> GenresList { get; } =
        [
            new Genre { Id = Guid.NewGuid(), Name = "Fantasy" },
            new Genre { Id = Guid.NewGuid(), Name = "Science Fiction" },
            new Genre { Id = Guid.NewGuid(), Name = "Mystery" },
            new Genre { Id = Guid.NewGuid(), Name = "Thriller" },
            new Genre { Id = Guid.NewGuid(), Name = "Romance" },
            new Genre { Id = Guid.NewGuid(), Name = "Horror" },
            new Genre { Id = Guid.NewGuid(), Name = "Historical Fiction" },
            new Genre { Id = Guid.NewGuid(), Name = "Adventure" },
            new Genre { Id = Guid.NewGuid(), Name = "Young Adult" },
            new Genre { Id = Guid.NewGuid(), Name = "Literary Fiction" },
            new Genre { Id = Guid.NewGuid(), Name = "Non-Fiction" },
            new Genre { Id = Guid.NewGuid(), Name = "Biography" },
            new Genre { Id = Guid.NewGuid(), Name = "Memoir" },
            new Genre { Id = Guid.NewGuid(), Name = "Self-Help" },
            new Genre { Id = Guid.NewGuid(), Name = "Cookbooks" },
            new Genre { Id = Guid.NewGuid(), Name = "Travel" },
            new Genre { Id = Guid.NewGuid(), Name = "Science" },
            new Genre { Id = Guid.NewGuid(), Name = "Fantasy" },
            new Genre { Id = Guid.NewGuid(), Name = "Graphic Novels" },
            new Genre { Id = Guid.NewGuid(), Name = "Poetry" }
        ];

        private List<Book> BookList { get; set; }

        private void InitializeBookList()
        {
            BookList = [
                new Book { Id = Guid.NewGuid(), Name = "Harry Potter and the Sorcerer's Stone", Author = "J.K. Rowling", IsAvailable = true, GenreId = GenresList[0].Id },
                new Book { Id = Guid.NewGuid(), Name = "Dune", Author = "Frank Herbert", IsAvailable = true, GenreId = GenresList[1].Id },
                new Book { Id = Guid.NewGuid(), Name = "The Da Vinci Code", Author = "Dan Brown", IsAvailable = true, GenreId = GenresList[2].Id },
                new Book { Id = Guid.NewGuid(), Name = "Gone Girl", Author = "Gillian Flynn", IsAvailable = true, GenreId = GenresList[3].Id },
                new Book { Id = Guid.NewGuid(), Name = "Pride and Prejudice", Author = "Jane Austen", IsAvailable = true, GenreId = GenresList[4].Id },
                new Book { Id = Guid.NewGuid(), Name = "The Shining", Author = "Stephen King", IsAvailable = true, GenreId = GenresList[5].Id },
                new Book { Id = Guid.NewGuid(), Name = "The Great Gatsby", Author = "F. Scott Fitzgerald", IsAvailable = true, GenreId = GenresList[6].Id },
                new Book { Id = Guid.NewGuid(), Name = "The Hobbit", Author = "J.R.R. Tolkien", IsAvailable = true, GenreId = GenresList[7].Id },
                new Book { Id = Guid.NewGuid(), Name = "The Hunger Games", Author = "Suzanne Collins", IsAvailable = true, GenreId = GenresList[8].Id },
                new Book { Id = Guid.NewGuid(), Name = "To Kill a Mockingbird", Author = "Harper Lee", IsAvailable = true, GenreId = GenresList[9].Id },
                new Book { Id = Guid.NewGuid(), Name = "Educated", Author = "Tara Westover", IsAvailable = true, GenreId = GenresList[10].Id },
                new Book { Id = Guid.NewGuid(), Name = "Becoming", Author = "Michelle Obama", IsAvailable = true, GenreId = GenresList[11].Id },
                new Book { Id = Guid.NewGuid(), Name = "The Power of Now", Author = "Eckhart Tolle", IsAvailable = true, GenreId = GenresList[12].Id },
                new Book { Id = Guid.NewGuid(), Name = "Cravings: Recipes for All the Food You Want to Eat", Author = "Chrissy Teigen", IsAvailable = true, GenreId = GenresList[13].Id },
                new Book { Id = Guid.NewGuid(), Name = "Into the Wild", Author = "Jon Krakauer", IsAvailable = true, GenreId = GenresList[14].Id },
                new Book { Id = Guid.NewGuid(), Name = "A Brief History of Time", Author = "Stephen Hawking", IsAvailable = true, GenreId = GenresList[15].Id },
                new Book { Id = Guid.NewGuid(), Name = "The Sandman", Author = "Neil Gaiman", IsAvailable = true, GenreId = GenresList[16].Id },
                new Book { Id = Guid.NewGuid(), Name = "The Last Wish", Author = "Andrzej Sapkowski", IsAvailable = true, GenreId = GenresList[17].Id },
                new Book { Id = Guid.NewGuid(), Name = "The Sun and Her Flowers", Author = "Rupi Kaur", IsAvailable = true, GenreId = GenresList[19].Id },
                new Book { Id = Guid.NewGuid(), Name = "Milk and Honey", Author = "Rupi Kaur", IsAvailable = true, GenreId = GenresList[19].Id }
        ];
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Book>()
                .HasOne(b => b.Genre)
                .WithMany(g => g.Books);

            builder.Entity<Record>()
                .HasOne(r => r.User)
                .WithMany(u => u.Records)
                .HasForeignKey(r => r.UserId);

            builder.Entity<Record>()
                .HasOne(r => r.Book)
                .WithMany(b => b.Records)
                .HasForeignKey(r => r.BookId);

            builder.Entity<Genre>().HasData(GenresList);

            builder.Entity<Book>().HasData(BookList);
        }

    }
}
