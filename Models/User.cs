using Microsoft.AspNetCore.Identity;

namespace VideoCallApp.Models
{
    public class User : IdentityUser
    {
        public bool IsActive { get; set; } = false;
    }
}

