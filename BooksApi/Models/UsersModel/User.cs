using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BooksApi.Models.UsersModel
{
    public class User
    {
        [BsonId] //to designate this property as document's primary key
        [BsonRepresentation(BsonType.ObjectId)] //to pass parameter as type string instead of ObjectId
        public string Id { get; set; }

        [BsonElement("Name")]  //property name in  mongodb
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string DoB { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsVerified { get; set; }
    }
}