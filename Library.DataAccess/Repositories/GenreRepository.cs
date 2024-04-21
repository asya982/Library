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
    public class GenreRepository(LibraryDbContext libraryDbContext) : IGenreRepository
    {
        private readonly LibraryDbContext _context = libraryDbContext;
        public void Add(Genre entity)
        {
            _context.Add(entity);
        }

        public void Delete(Genre entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<Genre> GetAll()
        {
            return _context.Genres.AsNoTracking();
        }

        public Genre GetSingleById(int id)
        {
            return _context.Genres.AsNoTracking().Single(g => g.Id == id);
        }

        public void Update(Genre entity)
        {
            _context.Update(entity);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
