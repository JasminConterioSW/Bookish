using Bookish.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bookish.WebAuth.Controllers
{
    public class CatalogueController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BookService _bookService;

        public CatalogueController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _bookService = new BookService();
        }

        public IActionResult Index()
        {
            var books = _bookService.GetAllUniqueBooks();
            return View(books);
        }
    }
}