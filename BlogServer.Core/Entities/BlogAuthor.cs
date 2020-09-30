using System;
using System.Collections.Generic;
using System.Text;

namespace BlogServer.Core.Entities
{
    public class BlogAuthor
    {
        public int id { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
