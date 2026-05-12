using Microsoft.AspNetCore.Mvc;

namespace Documents.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
