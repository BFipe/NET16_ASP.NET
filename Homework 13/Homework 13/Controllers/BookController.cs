using Homework_13.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework_13.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            BookViewModel book = new BookViewModel("Azbuka", "Ilya", 54);
            return View(book);
        }
    }
}
