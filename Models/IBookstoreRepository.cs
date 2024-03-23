using mission11_pickettPLEASE.Models;

namespace mission11_pickettPLEASE.Models
{
    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
