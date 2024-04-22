using Library.DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library.Web.Areas.Identity.Pages.Account.Manage
{
    public class BecomeAdminModel : PageModel
    {
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;

        public BecomeAdminModel(SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost() 
        {
            if (!signInManager.IsSignedIn(User))
            {
                return RedirectToPage("/Identity/Account/Login");
            }

            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new("Admin"));
            }

            var user = await userManager.GetUserAsync(User);

            if (user == null) 
            {
                return RedirectToPage("/Identity/Account/Login");
            }

            await userManager.AddToRoleAsync(user, "Admin");
            await signInManager.RefreshSignInAsync(user);

            return RedirectToPage("/Index");
        }
    }
}
