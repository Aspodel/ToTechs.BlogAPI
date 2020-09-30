using AutoMapper;
using BlogServer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogServer.Api.DataObject
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Blog, BlogDTO>();
            CreateMap<BlogDTO, Blog>()
                .ForMember(d => d.BlogId, o => o.Ignore());

            CreateMap<Author, AuthorDTO>();
            CreateMap<AuthorDTO, Author>()
                .ForMember(d => d.AuthorId, o => o.Ignore())
                .ForMember(d => d.BlogAuthors, o => o.Ignore())
                .ForMember(d => d.Account, o => o.Ignore());
        }
    }
}
