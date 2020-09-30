using BlogServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogServer.Contracts
{
    public interface IBlogRepository : IRepositoryBase<Blog>
    {
    }
}
