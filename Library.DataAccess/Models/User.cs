using Microsoft.AspNetCore.Identity;

namespace Library.DataAccess.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        // Navigation property for Records
        public ICollection<Record> Records { get; set; } = new List<Record>();
    }
}
