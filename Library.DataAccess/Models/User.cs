using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }

        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        // Navigation property for Records
        public ICollection<Record> Records { get; set; }
    }
}
