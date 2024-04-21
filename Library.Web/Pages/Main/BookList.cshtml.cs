using Library.Business.Abstraction;
using Library.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Web.Pages.Main
{
    public class BookListPageModel(IGenreService genreService) : PageModel
    {
		private readonly IGenreService _genreService = genreService;
		public ICollection<Genre> Genres;
		public void OnGet()
        {
            Genres = _genreService.GetGenres();
        }
    }
}
