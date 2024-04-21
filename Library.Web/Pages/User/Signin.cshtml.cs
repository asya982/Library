using Library.Business.Abstraction;
using Library.Business.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library.Web.Pages.User
{
    public class SigninPageModel : PageModel
    {
        private readonly IUserService _userService;

        public SigninPageModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public SigninModel SigninModel { get; set; } = new();

        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            var user = _userService.Signin(SigninModel);

            ClaimsIdentity identity = new();
            identity.AddClaim(new Claim("id", user.Id.ToString()));
            ClaimsPrincipal principal = new(identity);
            HttpContext.User = principal;
            return Redirect("/me");
        }
    }
}
