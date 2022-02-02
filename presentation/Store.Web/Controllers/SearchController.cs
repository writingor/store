using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookService bookService;

        public SearchController(BookService bookService)
        {
            this.bookService = bookService;
        }
        // /search/index?query=title
        public IActionResult Index(string query)
        {
            var books = bookService.GetAllByQuery(query);
            // returns the finished page
            return View(books);
        }
    }
}
