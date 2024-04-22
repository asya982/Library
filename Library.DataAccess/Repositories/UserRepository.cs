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
    public class UserRepository(LibraryDbContext libraryDbContext) : IUserRepository
    {
        private readonly LibraryDbContext _context = libraryDbContext;

        public void Add(User entity)
        {
            _context.Users.Add(entity);
        }

        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.AsNoTracking();
        }

        public User GetSingleById(Guid id)
        {
            return _context.Users.Include(u => u.Records).AsNoTracking().Single(u => u.Id == id.ToString());
        }

        public User GetSingleByUsername(string username) 
        {
            return _context.Users.Include(u => u.Records).AsNoTracking().Single(u => u.UserName == username);
        }

        public void Update(User entity)
        {
            _context.Update(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
