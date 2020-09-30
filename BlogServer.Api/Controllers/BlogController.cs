using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlogServer.Api.DataObject;
using BlogServer.Contracts;
using BlogServer.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogServer.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BlogController : ControllerBase
    {

        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;


        public BlogController(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var blog = await _blogRepository.FindByIdAsync(id);

            if (blog is null)
                return NotFound();

            return Ok(_blogRepository.FindByIdAsync(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_blogRepository.FindAll());
        }


        [HttpPost]
        public async Task<IActionResult> CreateBlog([FromBody] BlogDTO dto)
        {
            Blog blog = new Blog()
            {
                Title = dto.Title,
                Like = 0,
                Status = 0,
                DatePosted = DateTime.UtcNow,
                BlogImage = dto.BlogImage,
                Description = dto.Description,
            };

            _blogRepository.Create(blog);

            await _blogRepository.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var blog = await _blogRepository.FindByIdAsync(id);
            if (blog is null)
                return NotFound();

            _blogRepository.Delete(blog);
            await _blogRepository.SaveChangesAsync();
            return Ok();
        }



        // Update Like
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBlog(int id, [FromBody] BlogDTO dto)
        {
            var blog = await _blogRepository.FindByIdAsync(id);
            if (blog is null)
                return NotFound();

            _mapper.Map(dto, blog);
            await _blogRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
