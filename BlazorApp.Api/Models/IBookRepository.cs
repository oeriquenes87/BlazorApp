using BlazorApp.Models;

namespace BlazorApp.Api.Models
{
    public interface IBookRepository
    {
        Task<Book> GetBook(int id);
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> AddBook(Book book);
        Task<Book> UpdateBook(Book book);
        void DeleteBook(int id);

    }
}
