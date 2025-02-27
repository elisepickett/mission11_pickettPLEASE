using Microsoft.AspNetCore.Mvc;
using mission11_pickettPLEASE.Models;
using mission11_pickettPLEASE.Models.ViewModels;
using SQLitePCL;
using System.Diagnostics;

namespace mission11_pickettPLEASE.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository _repo;
        public HomeController(IBookstoreRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var blah = new BooksListViewModel
            {
                Books = _repo.Books
                            .OrderBy(x => x.Title)
                            .Skip((pageNum - 1) * pageSize)
                            .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()

                }
            };


            return View(blah);
        }

    }
}

