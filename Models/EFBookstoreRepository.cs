﻿
using mission11_pickettPLEASE.Models;

namespace mission11_pickettPLEASE.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreContext _context;
        public EFBookstoreRepository(BookstoreContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}

