using Library.Business.Abstraction;
using Library.DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Web.Areas.Admin.Pages.Manager
{
    [Authorize(Roles = "Admin")]
    public class ReturnBookModel : PageModel
    {
        private readonly IBookService _bookService;
        private readonly IUserService _userService;

        public ReturnBookModel(IBookService bookService, IUserService userService)
        {
            _bookService = bookService;
            TakenBooks = _bookService.GetTaken();
            _userService = userService;
        }

        public ICollection<Book> TakenBooks { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string bookId) 
        {
            var book = _bookService.GetSingleById(Guid.Parse(bookId));
            _userService.ReturnBook(book);
            return RedirectToPage("./ReturnBook");
        }
    }
}
