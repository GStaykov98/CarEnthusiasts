using Microsoft.AspNetCore.Mvc;

namespace CarEnthusiasts.Controllers
{
    public class TuningPartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
