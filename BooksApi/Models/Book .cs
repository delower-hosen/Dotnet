using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BooksApi.Models
{
    public class Book 
    {
        [BsonId] //to designate this property as document's primary key
        [BsonRepresentation(BsonType.ObjectId)] //to pass parameter as type string instead of ObjectId
        public string Id { get; set; }

        [BsonElement("Name")]  //property name in  mongodb
        public string BookName { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}