using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogServer.Api.DataObject
{
    public class AuthorDTO
    {
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Description { get; set; }

        public string ProfileUrl { get; set; }
    }
}
