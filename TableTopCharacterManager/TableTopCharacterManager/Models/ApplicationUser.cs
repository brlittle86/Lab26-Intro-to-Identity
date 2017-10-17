using Microsoft.AspNetCore.Identity;
using System;

namespace TableTopCharacterManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthday { get; set; }
    }
}
