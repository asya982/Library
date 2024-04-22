using Library.Business.Abstraction;
using Library.DataAccess.Abstraction;
using Library.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Services
{
	public class GenreService(IGenreRepository genreRepository) : IGenreService
	{
		private readonly IGenreRepository _genreRepository = genreRepository;
		public ICollection<Genre> GetGenres()
		{
			return _genreRepository.GetAll().ToList();
		}

        public Genre GetSingleById(Guid id)
        {
            return _genreRepository.GetSingleById(id);
        }
    }
}
