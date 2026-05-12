using Microsoft.AspNetCore.Mvc;

namespace Documents.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}