using Library.Business.Abstraction;
using Library.DataAccess.Abstraction;
using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Services
{
	public class BookService(IBookRepository bookRepository):IBookService
	{
		private readonly IBookRepository _bookRepository = bookRepository;

		public Book AddBook(Book book)
		{
			var newBook = new Book()
			{
				Author = book.Author,
				Name = book.Name,	
				IsAvailable = true,
				Genre = book.Genre,
			};

			return newBook;
		}

		public void DeleteBook(int id)
		{
			throw new NotImplementedException();
		}

		public ICollection<Book> GetAllBooks()
		{
			throw new NotImplementedException();
		}

		public ICollection<Book> GetBooksByAuthor(string author)
		{
			throw new NotImplementedException();
		}

		public ICollection<Book> GetBooksByGenre(Genre genre)
		{
			throw new NotImplementedException();
		}

		public ICollection<Book> GetBooksByName(string name)
		{
			throw new NotImplementedException();
		}

		public Book? UpdateBook(Book book)
		{
			throw new NotImplementedException();
		}
	}
}
