using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Areas.Admin
{
    public class AdminNavPages
    {
        public static string AddBook { get; set; } = "AddBook";

        public static string ManageUserRoles { get; set; } = "ManageUserRoles";

        public static string AddBookNavClass(ViewContext viewContext) => PageNavClass(viewContext, AddBook);

        public static string ManageUserRolesNavClass(ViewContext viewContext) => PageNavClass(viewContext, ManageUserRoles);

        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}
