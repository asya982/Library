using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstraction
{
	public interface IGenreService
	{
		ICollection<Genre> GetGenres();
	}
}
