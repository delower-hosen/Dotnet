using BooksApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Data.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBook(string id);
        void Add(Book book);
        void Delete(string id);
        Task<Book> Update(string id, Book bookIn);
    }
}
