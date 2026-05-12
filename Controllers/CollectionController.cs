using Microsoft.AspNetCore.Mvc;

namespace Documents.Controllers
{
    public class CollectionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
