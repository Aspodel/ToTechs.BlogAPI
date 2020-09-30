using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogServer.Core.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DatePosted { get; set; }

        public long Like { get; set; }

        public int Status { get; set; }

        public string BlogImage { get; set; }

        public virtual ICollection<BlogAuthor> BlogAuthors { get; set; }
    }
}
