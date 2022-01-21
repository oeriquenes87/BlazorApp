using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Api.Models
{
    public class BookRepository : IBookRepository
    {

        private readonly BlazorDBContext _blazorDBContext;

        public BookRepository(BlazorDBContext blazorDBContext)
        {
            _blazorDBContext = blazorDBContext;
        }

        public async Task<Book> AddBook(Book book)
        {
            var bookResult = await _blazorDBContext.AddAsync(book);
            await _blazorDBContext.SaveChangesAsync();
            return bookResult.Entity;
        }

        public async void DeleteBook(int id)
        {
            var result = await _blazorDBContext.Books.FirstOrDefaultAsync(t => t.Id == id);
            if (result != null)
            {
                _blazorDBContext.Remove(result);
                await _blazorDBContext.SaveChangesAsync();
            }
        }

        public async Task<Book> GetBook(int id)
        {
            var result = await _blazorDBContext.Books.FirstOrDefaultAsync(t=>t.Id == id);
            return result;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _blazorDBContext.Books.ToListAsync();
        }

        public async Task<Book> UpdateBook(Book book)
        {
            var result = await _blazorDBContext.Books.FirstOrDefaultAsync(t => t.Id == book.Id);
            if (result!=null)
            {
                result.Title = book.Title;
                result.PublishDate = book.PublishDate;
                await _blazorDBContext.SaveChangesAsync();
            }

            return result;
        }
    }
}
