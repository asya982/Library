using Library.Business.Abstraction;
using Library.Business.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Library.Web.Pages.User
{
    public class LoginPageModel(IUserService userService) : PageModel
    {
		private readonly IUserService _userService = userService;

		[BindProperty]
		public LoginModel LoginModel { get; set; } = new();
		public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
			var user = _userService.Login(LoginModel);
		
			return Redirect("/me");
		}
    }
}
