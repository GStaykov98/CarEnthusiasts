using Microsoft.AspNetCore.Mvc;

namespace CarEnthusiasts.Controllers
{
    public class CarInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
