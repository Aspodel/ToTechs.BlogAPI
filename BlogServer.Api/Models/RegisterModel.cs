using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogServer.Api.Models
{
    public class RegisterModel
    {
        //public DateTime DateCreated { get; set; }

        //public string Role { get; set; }

        public int AuthorId { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
