using Library.Business.Abstraction;
using Library.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Pages.Main
{
    public class BookListPageModel(IGenreService genreService, IBookService bookService, IUserService userService, UserManager<User> userManager) : PageModel
    {
        private readonly IGenreService _genreService = genreService;
        private readonly IBookService _bookService = bookService;
        private readonly IUserService _userService = userService;
        private readonly UserManager<User> _userManager = userManager;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList GenresSelectList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenreId { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

        public void OnGet()
        {
            GenresSelectList = new(_genreService.GetGenres(), nameof(Genre.Id), nameof(Genre.Name));

            if (!string.IsNullOrEmpty(SearchString))
            {
                Books = _bookService.GetBooksByName(SearchString);
            }
            else
            {
                Books = _bookService.GetAllBooks();
            }

            if (MovieGenreId != null)
            {
                var genre = _genreService.GetGenres().SingleOrDefault(g => g.Id.ToString() == MovieGenreId);
                Books = Books.Where(b => b.Genre == genre).ToList();
            }
        }

        public async Task<IActionResult> OnPostTakeBook(string bookId)
        {
            var book = _bookService.GetSingleById(Guid.Parse(bookId));

            var user = await _userManager.GetUserAsync(User);


            if (!book.IsAvailable || user == null)
            {
                return Page();
            }

            _userService.TakeBook(user, book);
            return Page();
        }
    }
}
