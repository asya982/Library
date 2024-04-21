using System;
using Library;

using (LibraryContext context = new LibraryContext())
{
    // Add a user
    var user = new User
    {
        Username = "john_doe",
        PhoneNumber = "123456789",
        IsAdmin = false
    };
    context.Users.Add(user);

    // Add a genre
    var genre = new Genre
    {
        Name = "Science Fiction"
    };
    context.Genres.Add(genre);

    // Add a book
    var book = new Book
    {
        Name = "The Hitchhiker's Guide to the Galaxy",
        Author = "Douglas Adams",
        IsAvailable = true,
    };
    context.Books.Add(book);

    // Add a record
    var record = new Record
    {
        UserId = user.Id, // Set the user ID
        BookId = book.Id, // Set the book ID
        Status = RecordStatus.Open,
        CreatedAt = DateTime.Now
    };
    context.Records.Add(record);

    // Save changes to the database
    context.SaveChanges();
}
  
