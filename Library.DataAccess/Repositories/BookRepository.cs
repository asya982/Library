using Library.DataAccess.Abstraction;
using Library.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Repositories
{
    public class BookRepository(LibraryDbContext libraryDbContext) : IBookRepository
    {
        private readonly LibraryDbContext _context = libraryDbContext;

        public void Add(Book entity)
        {
            _context.Add(entity);
        }

        public void Delete(Book entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<Book> GetAll()
        {
            return _context.Books.Include(b => b.Genre).AsNoTracking();
        }

        public Book GetSingleById(Guid id)
        {
            return _context.Books.Include(b => b.Genre).AsNoTracking().Include(b => b.Records).AsNoTracking().Single(b => b.Id == id);
        }

        public void Update(Book entity)
        {
            _context.Update(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
