using Microsoft.AspNetCore.Identity;

namespace CrudAuth.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
    }
}
