using Microsoft.AspNetCore.Identity;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Api.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
