using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksApi.Data.Interfaces;
using BooksApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repo;
        public BooksController(IBookRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _repo.GetBooks();
            return Ok(books);
        }

        [HttpGet("{id:length(24)}", Name = "GetBook")]
        public async Task<IActionResult> GetBook(string id)
        {
            var book = await _repo.GetBook(id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public void Add(Book book)
        {
            _repo.Add(book);
        }

        //[HttpPut("{id:length(24)}")]
        //public IActionResult Update(string id, Book bookIn)
        //{
        //    var book = _bookService.Get(id);

        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    _bookService.Update(id, bookIn);

        //    return NoContent();
        //}

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = _repo.GetBook(id);

            if (book == null)
            {
                return NotFound();
            }

            _repo.Delete(id);

            return NoContent();
        }
    }
}