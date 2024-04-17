using Microsoft.AspNetCore.Mvc;

namespace CarEnthusiasts.Controllers
{
    public class ErrorController : Controller
    {
        public async Task<IActionResult> Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }

            return View();
        }
    }
}
