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
        ICollection<Book> GetBooksByName(string name);

        ICollection<Book> GetBooksByGenre(Genre genre);

        ICollection<Book> GetBooksByAuthor(string author);
    }
}
