using MongoDB.Bson;
using System;

namespace MongoDB_CRUD.Database
{
    public abstract class Document : IDocument
    {
        public string Id { get; set; }

        public DateTime CreatedAt => DateTime.Now;
    }
}
