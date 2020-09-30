using BlogServer.Contracts;
using BlogServer.Core.Database;
using BlogServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogServer.Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
