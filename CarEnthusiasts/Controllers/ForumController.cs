using Microsoft.AspNetCore.Mvc;

namespace CarEnthusiasts.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
