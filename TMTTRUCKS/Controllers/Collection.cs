using Microsoft.AspNetCore.Mvc;

namespace TMTTRUCKS.Controllers
{
    public class Collection : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
