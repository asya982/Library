using Library.Business.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Web.Pages
{
    public class IndexModel(IUserService userService, ILogger<IndexModel> logger) : PageModel
    {
			private readonly IUserService _userService = userService;

			private readonly ILogger<IndexModel> _logger = logger;

        public void OnGet()
        {

        }
    }
}
