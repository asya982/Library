using Library.Business.Abstraction;
using Library.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Pages.Main
{
    public class BookListPageModel : PageModel
    {
        private readonly IGenreService _genreService;
        private readonly IBookService _bookService;
        private readonly IUserService _userService;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public BookListPageModel(IGenreService genreService, IBookService bookService, IUserService userService, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _genreService = genreService;
            _bookService = bookService;
            _userService = userService;
            _signInManager = signInManager;
            _userManager = userManager;
            this.Books = _bookService.GetAllBooks();
            this.GenresSelectList = new(_genreService.GetGenres(), nameof(Genre.Name), nameof(Genre.Name));
        }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList GenresSelectList { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? GenreName { get; set; }

        public ICollection<Book> Books { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Error { get; set; }

        public void OnGet()
        {
            if (!string.IsNullOrEmpty(SearchString))
            {
                Books = _bookService.GetBooksByName(SearchString);
            }
            else
            {
                Books = _bookService.GetAllBooks();
            }

            if (GenreName != null)
            {
                var genre = _genreService.GetGenres().Single(g => g.Name == GenreName);
                Books = Books.Where(b => b.Genre.Name == genre.Name).ToList();
            }
        }

        public async Task<IActionResult> OnPostTakeBook(string bookId)
        {
            var book = _bookService.GetSingleById(Guid.Parse(bookId));

            var userId = (await _userManager.GetUserAsync(User)).Id;

            if (!book.IsAvailable || !_signInManager.IsSignedIn(User))
            {
                return RedirectToPage("/Main/BookList");
            }

            try
            {
                _userService.TakeBook(Guid.Parse(userId), book);
            }
            catch (InvalidOperationException ex)
            {
                Error = ex.Message;
            }
            return RedirectToPage($"/Main/BookList", new { error = Error });
        }

        public IActionResult OnPostClearFilter()
        {
            return RedirectToPage("./BookList");
        }
    }
}
