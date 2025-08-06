using Microsoft.AspNetCore.Mvc;

namespace Aku_Software_Blog.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
