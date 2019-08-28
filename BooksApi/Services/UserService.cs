using System;
using System.Collections.Generic;
using BooksApi.Models.UsersModel;
using MongoDB.Driver;

namespace BooksApi.Services
{
    public class UserService
    {

        private readonly IMongoCollection<User> _users;

        public UserService(IUserstoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _users = database.GetCollection<User>(settings.UsersCollectionName);
        }

        public List<User> Get() =>
            _users.Find(user => true).ToList();

        // public Book Get(string id) =>
        //     _books.Find<Book>(book => book.Id == id).FirstOrDefault();

        public User Create(User user)
        {
            Console.WriteLine(user.Password);
            _users.InsertOne(user);
            return user;
        }

        // public void Update(string id, Book bookIn) =>
        //     _books.ReplaceOne(book => book.Id == id, bookIn);

        // public void Remove(Book bookIn) =>
        //     _books.DeleteOne(book => book.Id == bookIn.Id);

        // public void Remove(string id) =>
        //     _books.DeleteOne(book => book.Id == id);
    }
}