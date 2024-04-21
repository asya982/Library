using Library.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
	public class LibraryDbContext : DbContext
	{
		public LibraryDbContext(DbContextOptions dbContextOptions)
			: base(dbContextOptions)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Record> Records { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>()
				.HasOne(b => b.Genre)
				.WithMany(g => g.Books);

			modelBuilder.Entity<Record>()
				.HasOne(r => r.User)
				.WithMany(u => u.Records)
				.HasForeignKey(r => r.UserId);

			modelBuilder.Entity<Record>()
				.HasOne(r => r.Book)
				.WithMany(b => b.Records)
				.HasForeignKey(r => r.BookId);

			modelBuilder.Entity<Genre>().HasData(
				new Genre { Id = 1, Name = "Fantasy" },
				new Genre { Id = 2, Name = "Science Fiction" },
				new Genre { Id = 3, Name = "Mystery" },
				new Genre { Id = 4, Name = "Thriller" },
				new Genre { Id = 5, Name = "Romance" },
				new Genre { Id = 6, Name = "Horror" },
				new Genre { Id = 7, Name = "Historical Fiction" },
				new Genre { Id = 8, Name = "Adventure" },
				new Genre { Id = 9, Name = "Young Adult" },
				new Genre { Id = 10, Name = "Literary Fiction" },
				new Genre { Id = 11, Name = "Non-Fiction" },
				new Genre { Id = 12, Name = "Biography" },
				new Genre { Id = 13, Name = "Memoir" },
				new Genre { Id = 14, Name = "Self-Help" },
				new Genre { Id = 15, Name = "Cookbooks" },
				new Genre { Id = 16, Name = "Travel" },
				new Genre { Id = 17, Name = "Science" },
				new Genre { Id = 18, Name = "Fantasy" },
				new Genre { Id = 19, Name = "Graphic Novels" },
				new Genre { Id = 20, Name = "Poetry" });
		}

	}
}
