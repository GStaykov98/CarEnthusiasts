using CarEnthusiasts.Data;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Controllers
{
    public class TuningPartsController : Controller
    {
        private readonly ApplicationDbContext data;

        public TuningPartsController(ApplicationDbContext context)
        {
            data = context;
        }

        public async Task<IActionResult> Home()
        {
            var categories = await data.TuningPartCategories
                .OrderBy(x => x.Name)
                .Select(x => new TuningPartCategoryViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageUrl = x.ImageUrl
                })
                .ToListAsync();

            return View(categories);
        }

        public async Task<IActionResult> Category(int id)
        {
            if (data.TuningPartCategories.FirstOrDefault(x => x.Id == id) is null)
            {
                return BadRequest();
            }

            var tuningParts = await data.TuningParts
                .Where(x => x.CategoryId == id)
                .OrderBy(x => x.Name)
                .Select(x => new TuningPartViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageUrl = x.ImageUrl,
                    Price = x.Price,
                    Quantity = x.Quantity
                })
                .ToListAsync();

            return View(tuningParts);
        }

        public async Task<IActionResult> PartDetails(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }

            var carModel = data.CarModels
                .Include(x => x.Brand)
                .Include(z => z.TuningPartsCarModels.Where(y => y.TuningPartId == id))
                .Where(x => x.TuningPartsCarModels.Any(z => z.TuningPartId == id))
                .ToList();

            var model = await data.TuningParts
                .Include(x => x.TuningPartsCarModels)
                .Select(x => new TuningPartDetailsIViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description,
                    TuningPartsCarModels = x.TuningPartsCarModels,
                    Category = x.Category
                })
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model is null)
            {
                return BadRequest();
            }

            foreach (var z in carModel)
            {
                model.CarModels.Add(new TuningPartCarModelViewModel { BrandName = z.Brand.Name, ModelName = z.Name });
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> BuyPart(int id)
        {
            var part = await data.TuningParts.FindAsync(id);

            if (part is null)
            {
                return BadRequest();
            }

            var model = new BuyPartViewModel
            {
                Id = part.Id,
                PartName = part.Name,
                Price = part.Price,
                ImageUrl = part.ImageUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BuyPart(BuyPartViewModel model)
        {
            var currentPart = await data.TuningParts.FindAsync(model.Id);

            if (currentPart is null ||
                !ModelState.IsValid ||
                currentPart.Quantity == 0)
            {
                return BadRequest();
            }

            currentPart.Quantity--;

            await data.SaveChangesAsync();

            return RedirectToAction(nameof(Home));
        }
    }
}
