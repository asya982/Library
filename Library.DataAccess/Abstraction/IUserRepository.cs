using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Abstraction
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User GetSingleByUsername(string username);
    }
}
