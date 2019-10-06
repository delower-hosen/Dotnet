using System.Collections.Generic;
using System.Threading.Tasks;
using BooksApi.Models;

namespace BooksApi.Data
{
    public interface IBookRepository
    {
        Task<List<Book>> Get();
        Task<Book> Get(string id);
        Task<Book> Create(Book book);
        Task<Book> Update(string id, Book bookIn);
        Task<Book> Remove(string id);
    }
}