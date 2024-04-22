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
	public class BookService(IBookRepository bookRepository) : IBookService
	{
		private readonly IBookRepository _bookRepository = bookRepository;

		public Book AddBook(Book book)
		{
			book.IsAvailable = true;
			_bookRepository.Add(book);
			_bookRepository.SaveChanges();
			return book;
		}

		public void DeleteBook(int id)
		{
			throw new NotImplementedException();
		}

		public Book GetSingleById(Guid id)
		{
			return _bookRepository.GetSingleById(id);
		}

		public ICollection<Book> GetAllBooks()
		{
			return _bookRepository.GetAll().ToList();
		}

		public ICollection<Book> GetBooksByAuthor(string author)
		{
			return _bookRepository.GetAll().Where(b => b.Author.Contains(author)).ToList();
		}

		public ICollection<Book> GetBooksByGenre(Genre genre)
		{
            return _bookRepository.GetAll().Where(b => b.Genre == genre).ToList();
        }

        public ICollection<Book> GetBooksByGenre(ICollection<Genre> genres)
        {
            return _bookRepository.GetAll().Where(b => genres.Contains(b.Genre)).ToList();
        }

        public ICollection<Book> GetBooksByName(string name)
		{
			return _bookRepository.GetAll().Where(b => b.Name.Contains(name)).ToList();
		}

		public Book? UpdateBook(Book book)
		{
			_bookRepository.Update(book);
			_bookRepository.SaveChanges();
			return book;
		}
	}
}
