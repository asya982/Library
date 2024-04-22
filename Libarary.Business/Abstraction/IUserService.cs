using Library.Business.Model;
using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstraction
{
    public interface IUserService
    {
        User GetSingleById(Guid id);

        User Signin(SigninModel model);

        User? Login(LoginModel model);

        void TakeBook(Guid userId, Book book);

        void ReturnBook(Book book);
    }
}
