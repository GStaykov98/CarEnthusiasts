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

        public async Task<IActionResult> PartDetail(int id)
        {
            var currentPart = await data.TuningParts.FindAsync(id);

            if (currentPart == null)
            {
                return BadRequest();
            }



            return View();
        }
    }
}
