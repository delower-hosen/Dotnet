using BooksApi.Data.Interfaces;
using BooksApi.DatabaseSettings;
using BooksApi.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksApi.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly IMongoCollection<Book> _books;
        public BookRepository(IBookstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _books = database.GetCollection<Book>("Books");
        }

        public void Add(Book book)
        {
            _books.InsertOne(book);
        }

        public void Delete(string id)
        {
            _books.DeleteOne(id);
        }

        public async Task<Book> GetBook(string id)
        {
            var book = await _books.Find(u => u.Id == id).FirstOrDefaultAsync();
            return book;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            var books = await _books.Find(book => true).ToListAsync();
            return books;
        }

        public Task<Book> Update(string id, Book bookIn)
        {
            throw new NotImplementedException();
        }
    }
}
