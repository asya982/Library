using Library.Business.Abstraction;
using Library.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Library.Web.Areas.Admin
{
    public class BooksModel(IGenreService genreService, IBookService bookService) : PageModel
    {
        private readonly IGenreService _genreService = genreService;
        private readonly IBookService _bookService = bookService;

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            public string Name { get; set; }

            [Required]
            public string Author { get; set; }

            [Required]
            public string GenreId { get; set; }
        }

        public SelectList GenresSelectList { get; set; }

        public void OnGet()
        {
            GenresSelectList = new(_genreService.GetGenres(), nameof(Genre.Id), nameof(Genre.Name));
        }

        public void OnPost()
        {
            var genre = _genreService.GetGenres().Single(g => g.Id.ToString() == Input.GenreId);
            var book = new Book()
            {
                Id = Guid.NewGuid(),
                Name = Input.Name,
                Author = Input.Author,
                IsAvailable = true,
                GenreId = genre.Id,
            };

            _bookService.AddBook(book);
        }
    }
}
