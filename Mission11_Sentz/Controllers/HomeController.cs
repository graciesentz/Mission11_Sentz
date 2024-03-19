using Microsoft.AspNetCore.Mvc;
using Mission11_Sentz.Models;
using Mission11_Sentz.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Sentz.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepository;
        public HomeController(IBookRepository temp)
        {
            _bookRepository = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var bookData = new BookListViewModel
            {
                Books = _bookRepository.Books
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookRepository.Books.Count()
                }
            };

            return View(bookData);
        }
    }
}
