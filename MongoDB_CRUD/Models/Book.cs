using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB_CRUD.Database;

namespace MongoDB_CRUD.Models
{
    [BsonCollection("Book")]
    public class Book : Document
    {
        [BsonElement("Name")]
        public string BookName { get; set; } = null!;

        public decimal Price { get; set; }

        public string Category { get; set; } = null!;

        public string Author { get; set; } = null!;
    }
}
