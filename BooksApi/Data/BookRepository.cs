using System.Collections.Generic;
using System.Threading.Tasks;
using BooksApi.Models;
using MongoDB.Driver;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.Data {
    public class BookRepository : IBookRepository {
        private readonly IMongoCollection<Book> _books;
        public BookRepository (IBookstoreDatabaseSettings settings) {
            var client = new MongoClient (settings.ConnectionString);
            var database = client.GetDatabase (settings.DatabaseName);

            _books = database.GetCollection<Book> ("Books");
        }
        public Task<Book> Create (Book book) {
            throw new System.NotImplementedException ();
        }

        public Task<List<Book>> Get () {
            throw new System.NotImplementedException ();
            // List<Book> Books = await _books.FindAsync(book => true).ToListAsync();
            // return Books;
        }

        public Task<Book> Get (string id) {
            throw new System.NotImplementedException ();
        }

        public Task<Book> Remove (string id) {
            throw new System.NotImplementedException ();
        }

        public Task<Book> Update (string id, Book bookIn) {
            throw new System.NotImplementedException ();
        }
    }
}