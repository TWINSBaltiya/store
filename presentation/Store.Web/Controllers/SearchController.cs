using Microsoft.AspNetCore.Mvc;
using System;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookService bookService;

        public SearchController(BookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index(string query)
        {
            ViewBag.query = query;

            if (String.IsNullOrWhiteSpace(query))
            {
                return View("Index", new Book[0]);
            }

            var books = bookService.GetAllByQuery(query);

            return View("Index", books);
        }
    }
}