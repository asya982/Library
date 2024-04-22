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
    public class RecordRepository(LibraryDbContext libraryDbContext) : IRecordRepository
    {
        private readonly LibraryDbContext _context = libraryDbContext;    

        public void Add(Record entity)
        {
            _context.Add(entity);
        }

        public void Delete(Record entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<Record> GetAll()
        {
            return _context.Records.AsNoTracking();
        }

        public Record GetSingleById(Guid id)
        {
            return _context.Records.AsNoTracking().Single(r => r.Id == id);
        }

        public ICollection<Record> GetByUserId(Guid id)
        {
            return _context.Records.AsNoTracking().Where(r => r.UserId == id.ToString()).ToList();
        }

        public ICollection<Record> GetByBookId(Guid bookId) 
        {
            return _context.Records.AsNoTracking().Where(r => r.BookId == bookId).ToList();
        }

        public void Update(Record entity)
        {
            _context.Update(entity);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
