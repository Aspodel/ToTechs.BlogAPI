using BlogServer.Contracts;
using BlogServer.Core.Database;
using BlogServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogServer.Repository
{
    public class BlogRepository : RepositoryBase<Blog>, IBlogRepository
    {
        public BlogRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
