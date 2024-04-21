using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Library.DataAccess.Models;
using Library.Business.Abstraction;
using System.Security.Claims;

namespace Library.Web.Pages.User
{
    public class MyProfilePageModel : PageModel
    {
        private readonly IUserService _userService;

        public MyProfilePageModel(IUserService userService)
        {
            _userService = userService;
        }

        public Library.DataAccess.Models.User Me { get; set; }
        
        public void OnGet()
        {
            var userId = int.Parse(User.FindFirstValue("id"));

            Me = _userService.GetSingleById(userId);
        }
    }
}
