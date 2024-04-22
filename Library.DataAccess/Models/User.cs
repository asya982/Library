using Microsoft.AspNetCore.Identity;

namespace Library.DataAccess.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Navigation property for Records
        public ICollection<Record> Records { get; set; } = new List<Record>();
    }
}
