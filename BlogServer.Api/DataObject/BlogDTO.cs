using BlogServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogServer.Api.DataObject
{
    public class BlogDTO
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public long Like { get; set; }

        public int Status { get; set; }

        public string BlogImage { get; set; }

        public ICollection<BlogAuthor> BlogAuthors { get; set; }
    }
}
