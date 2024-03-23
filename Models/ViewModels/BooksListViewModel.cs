using mission11_pickettPLEASE.Models;
using mission11_pickettPLEASE.Models.ViewModels;

namespace mission11_pickettPLEASE.Models.ViewModels
{
    public class BooksListViewModel
    {
        public required IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();

    }
}

