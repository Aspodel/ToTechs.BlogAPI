using BlogServer.Contracts;
using BlogServer.Core.Database;
using BlogServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogServer.Repository
{
    public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
    {
        public AuthorRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
