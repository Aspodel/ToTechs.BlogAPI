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
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;


        public AuthorController(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var blog = await _authorRepository.FindByIdAsync(id);

            if (blog is null)
                return NotFound();

            return Ok(_authorRepository.FindByIdAsync(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_authorRepository.FindAll());
        }


        [HttpPost]
        public async Task<IActionResult> CreateAuthor([FromBody] AuthorDTO dto)
        {
            var author = _mapper.Map<Author>(dto);

            _authorRepository.Create(author);

            await _authorRepository.SaveChangesAsync();

            return Ok(_mapper.Map<AuthorDTO>(author));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var blog = await _authorRepository.FindByIdAsync(id);
            if (blog is null)
                return NotFound();

            _authorRepository.Delete(blog);
            await _authorRepository.SaveChangesAsync();
            return Ok();
        }



        // Update Like
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBlog(int id, [FromBody] BlogDTO dto)
        {
            var blog = await _authorRepository.FindByIdAsync(id);
            if (blog is null)
                return NotFound();

            _mapper.Map(dto, blog);
            await _authorRepository.SaveChangesAsync();

            return NoContent();
        }
    }
}
