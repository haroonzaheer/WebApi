using Microsoft.AspNetCore.Mvc;

namespace AspNetFirstWebApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
