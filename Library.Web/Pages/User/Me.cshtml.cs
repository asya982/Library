using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Library.DataAccess.Models;
using Library.Business.Abstraction;
using System.Security.Claims;

namespace Library.Web.Pages.User
{
    public class MyProfilePageModel(IUserService userService) : PageModel
    {
        private readonly IUserService _userService = userService;

		public Library.DataAccess.Models.User Me { get; set; }
        
        public void OnGet()
        {
            var userId = int.Parse(User.FindFirst("id").Value);

            Me = _userService.GetSingleById(userId);
        }
    }
}
