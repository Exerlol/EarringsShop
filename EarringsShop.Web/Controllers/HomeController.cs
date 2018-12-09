using Microsoft.AspNetCore.Mvc;

namespace EarringsShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }
    }
}