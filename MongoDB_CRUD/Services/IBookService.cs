using MongoDB_CRUD.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MongoDB_CRUD.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllAsync();
        Task<Book> GetByIdAsync(string id);
        Task<Book> CreateAsync(Book book);
        Task UpdateAsync(string id, Book updatedBook);
        Task DeleteAsync(string id);
    }
}
