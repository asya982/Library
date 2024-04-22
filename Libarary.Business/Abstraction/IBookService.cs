using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstraction
{
    public interface IBookService
    {
        Book GetSingleById(Guid id);

        ICollection<Book> GetBooksByName(string name);

        ICollection<Book> GetBooksByGenre(Genre genre);

        ICollection<Book> GetBooksByGenre(ICollection<Genre> genres);

        ICollection<Book> GetBooksByAuthor(string author);

        ICollection<Book> GetBooksTakenByUser(Guid userId);

        ICollection<Book> GetTaken();

        ICollection<Book> GetAllBooks();

        Book? UpdateBook(Book book);

        void DeleteBook(int id);

        Book AddBook(Book book);
    }
}
