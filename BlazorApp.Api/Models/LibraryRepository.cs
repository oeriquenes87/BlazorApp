using BlazorApp.Models;

namespace BlazorApp.Api.Models
{
    public class LibraryRepository : ILibraryRepository
    {


        public Task<Library> AddLibrary(Library library)
        {
            throw new NotImplementedException();
        }

        public void DeleteLibrary(Library library)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Library>> GetAllLibraries()
        {
            throw new NotImplementedException();
        }

        public Task<Library> GetLibraryById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Library> UpdateLibrary(Library library)
        {
            throw new NotImplementedException();
        }
    }
}
