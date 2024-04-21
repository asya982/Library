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
        User GetSingleById(int id);

        User Signin(SigninModel model);

        User? Login(LoginModel model);

        void TakeBook(User user, Book book);
    }
}
