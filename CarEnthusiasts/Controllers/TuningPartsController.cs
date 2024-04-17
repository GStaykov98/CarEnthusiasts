using CarEnthusiasts.Data;
using CarEnthusiasts.Data.Contracts.TuningParts;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Controllers
{
    public class TuningPartsController : Controller
    {
        private readonly ITuningPartsService tuningService;

        public TuningPartsController(ITuningPartsService _tuningService)
        {
            tuningService = _tuningService;
        }

        public async Task<IActionResult> Home()
        {
            var categories = await tuningService.GetCategories();

            return View(categories);
        }

        public async Task<IActionResult> Category(int id)
        {
            if (!await tuningService.CategoryExist(id))
            {
                return BadRequest();
            }

            var tuningParts = await tuningService.GetPartsByCategory(id);

            return View(tuningParts);
        }

        public async Task<IActionResult> PartDetails(int id)
        {
            if (!await tuningService.PartExists(id))
            {
                return BadRequest();
            }

            var part = await tuningService.GetPartDetails(id);

            return View(part);
        }

        [HttpGet]
        public async Task<IActionResult> BuyPart(int id)
        {
            if (!await tuningService.PartExists(id))
            {
                return BadRequest();
            }

            if (!await tuningService.PartIsInStock(id))
            {
                return BadRequest();
            }

            var model = await tuningService.GetPartBuyForm(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BuyPart(BuyPartViewModel model)
        {
            if (!await tuningService.PartExists(model.Id))
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (!await tuningService.PartIsInStock(model.Id))
            {
                return BadRequest();
            }

            await tuningService.BuyPart(model.Id);

            return RedirectToAction(nameof(Home));
        }
    }
}
