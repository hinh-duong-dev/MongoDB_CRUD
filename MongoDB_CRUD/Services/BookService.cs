using MongoDB_CRUD.Models;
using MongoDB_CRUD.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDB_CRUD.Services
{
    public class BookService : IBookService
    {
        private readonly IMongoRepository<Book> _bookRepository;

        public BookService(IMongoRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> CreateAsync(Book book)
        {
            await _bookRepository.InsertOneAsync(book);
            return book;
        }

        public Task DeleteAsync(string id)
        {
            return _bookRepository.DeleteOneAsync(c => c.Id == id);
        }

        public Task<List<Book>> GetAllAsync()
        {
            return _bookRepository.GetAllAsync();
        }

        public Task<Book> GetByIdAsync(string id)
        {
            return _bookRepository.FindByIdAsync(id);
        }

        public Task UpdateAsync(string id, Book updatedBook)
        {
            return _bookRepository.UpdateOneAsync(id, updatedBook);
        }
    }
}
