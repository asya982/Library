using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Library
{
    internal class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Record> Records { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Database=Library_Project;AttachDbFilename=D:\Downloads\Library.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
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
    }

}
}
