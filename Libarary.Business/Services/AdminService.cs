using Library.Business.Abstraction;
using Library.DataAccess.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Services
{
	public class AdminService(IBookRepository bookRepository):IAdminService
	{
		private readonly IBookRepository _bookRepository = bookRepository;


	}
}
