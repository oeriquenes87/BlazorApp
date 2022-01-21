using BlazorApp.Models;

namespace BlazorApp.Api.Models
{
    public interface ILibraryRepository
    {
        Task<Library> AddLibrary(Library library);
        Task<Library> UpdateLibrary(Library library);
        void DeleteLibrary(Library library);    

        Task<IEnumerable<Library>> GetAllLibraries();
        Task<Library> GetLibraryById(int id);   
    }
}
