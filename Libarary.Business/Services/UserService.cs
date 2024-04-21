using Library.Business.Abstraction;
using Library.Business.Model;
using Library.DataAccess.Abstraction;
using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Services
{
    public class UserService(IUserRepository userRepository, IRecordRepository recordRepository, IBookRepository bookRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;
        private readonly IRecordRepository _recordRepository = recordRepository;
        private readonly IBookRepository _bookRepository = bookRepository;

        public User GetSingleById(int id)
        {
            return _userRepository.GetSingleById(id);
        }

        public User? Login(LoginModel model)
        {
            var user = _userRepository.GetSingleByUsername(model.Username);

            if (user == null) 
            {
                return null;
            } else if (user.Password != model.Password)
            {
                return null;
            }

            return user;
        }

        public User Signin(SigninModel model)
        {
            var user = new User()
            {
                Username = model.Username,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber
            };

            _userRepository.Add(user);
            _userRepository.SaveChanges();

            return user;
        }

        public void TakeBook(User user, Book book)
        {
            if (user.Records.Count(r => r.Status == RecordStatus.Open) >= 5)
            {
                throw new InvalidOperationException("Too many books");
            } else if (user.Records.Any(r => r.CreatedAt.AddMonths(1) > DateTime.Now && r.Status == RecordStatus.Open))
            {
                throw new InvalidOperationException("Борг верни сука");
            } else  if (!book.IsAvailable)
            {
                throw new InvalidOperationException("Підожди");
            }

            var record = new Record()
            {
                BookId = book.Id,
                Status = RecordStatus.Open,
                UserId = user.Id,
                CreatedAt = DateTime.Now
            };
            book.IsAvailable = false;
            _bookRepository.Update(book);
            _recordRepository.Add(record);
            _recordRepository.SaveChanges();
        }
    }
}
