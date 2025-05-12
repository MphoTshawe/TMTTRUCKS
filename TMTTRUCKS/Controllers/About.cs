using Microsoft.AspNetCore.Mvc;

namespace TMTTRUCKS.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
