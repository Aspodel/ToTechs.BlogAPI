using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogServer.Core.Entities
{
    public class Account : IdentityUser<int>
    {
        [Required(ErrorMessage = "Date created is required")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
