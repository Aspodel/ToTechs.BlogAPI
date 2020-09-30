using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogServer.Core.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(40, ErrorMessage = "Name can't be longer than 60 character")]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Description { get; set; }

        public string ProfileUrl { get; set; }

        public ICollection<BlogAuthor> BlogAuthors { get; set; }

        public Account Account { get; set; }
    }
}
