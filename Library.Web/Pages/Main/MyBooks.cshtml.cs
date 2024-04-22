using Library.Business.Abstraction;
using Library.Business.Services;
using Library.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Web.Pages.Main
{
    public class MyBooksModel : PageModel
    {
        private readonly IBookService _bookService;
        private readonly UserManager<User> _userManager;

        public MyBooksModel(IBookService bookService, UserManager<User> userManager)
        {
            _bookService = bookService;
            _userManager = userManager;
        }

        public ICollection<Book> MyBooks { get; set; } = new List<Book>();

        public async Task OnGet()
        {
            var userId = (await _userManager.GetUserAsync(User)).Id;

            MyBooks = _bookService.GetBooksTakenByUser(Guid.Parse(userId));
        }
    }
}
