using Library.Business.Abstraction;
using Library.Business.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Library.Web.Pages.User
{
    public class SigninPageModel : PageModel
    {
        private readonly IUserService _userService;

        public SigninPageModel(IUserService userService)
        {
            _userService = userService;
        }

        public SigninModel SigninModel { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost(SigninModel model) 
        {
            var user = _userService.Signin(model);
            ClaimsIdentity identity = new();
            identity.AddClaim(new("id", user.Id.ToString()));
            ClaimsPrincipal principal = new(identity);
            HttpContext.User = principal;
            return Redirect("/me");
        }
    }
}
