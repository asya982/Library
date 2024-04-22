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
		}

		public DbSet<Book> Books { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Record> Records { get; set; }

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

			builder.Entity<Genre>().HasData(
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
				new Genre { Id = Guid.NewGuid(),	Name = "Memoir" },
				new Genre { Id = Guid.NewGuid(), Name = "Self-Help" },
				new Genre { Id = Guid.NewGuid(), Name = "Cookbooks" },
				new Genre { Id = Guid.NewGuid(), Name = "Travel" },
				new Genre { Id = Guid.NewGuid(), Name = "Science" },
				new Genre { Id = Guid.NewGuid(), Name = "Fantasy" },
				new Genre { Id = Guid.NewGuid(), Name = "Graphic Novels" },
				new Genre { Id = Guid.NewGuid(), Name = "Poetry" });
		}

	}
}
