using CarEnthusiasts.Data;
using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Controllers
{
    public class CompareController : Controller
    {
        private readonly ApplicationDbContext data;

        public CompareController(ApplicationDbContext context)
        {
            data = context;
        }

        [HttpGet]
        public async Task<IActionResult> CompareCars()
        {
            var viewModel = new ComparisonViewModel
            {
                Cars = await data.CarModels
                .Include(e => e.Engines)
                .Select(x => new CarsDropdownViewModel
                {
                    Id = x.Id,
                    FullName = x.Brand.Name + " - " + x.Name,
                    Engines = x.Engines.Select(e => new EnginesDropdownViewModel
                    {
                        Id = e.Id,
                        Name = e.Name
                    }).ToList()
                })
                .ToListAsync()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> ShowComparison(ComparisonViewModel model)
        {
            var firstSelectedCarValues = model.SelectedCar1Id.Split(':');
            var secondSelectedCarValues = model.SelectedCar2Id.Split(':');

            int firstSelectedCarId = 0;
            int firstSelectedCarEngineId = 0;

            int secondSelectedCarId = 0;
            int secondSelectedCarEngineId = 0;

            if (!int.TryParse(firstSelectedCarValues[0], out firstSelectedCarId) ||
                !int.TryParse(firstSelectedCarValues[1], out firstSelectedCarEngineId) ||
                !int.TryParse(secondSelectedCarValues[0], out secondSelectedCarId) ||
                !int.TryParse(secondSelectedCarValues[1], out secondSelectedCarEngineId))
            {
                return BadRequest();
            }

            if (!data.CarModels.Any(x => x.Id == firstSelectedCarId) ||
                !data.CarModels.Any(x => x.Id == secondSelectedCarId) ||
                !data.CarModels.Any(e => e.Engines.Any(i => i.Id == firstSelectedCarEngineId)) ||
                !data.CarModels.Any(x => x.Engines.Any(e => e.Id == secondSelectedCarEngineId)))
            {
                return BadRequest();
            }

            model.FirstCarFullInformation = await data.CarModels
                .Include(e => e.Engines)
                .Where(x => x.Id == firstSelectedCarId)
                .Select(x => new ComparedCarViewModel
                {
                    Brand = x.Brand.Name,
                    Model = x.Name,
                    ImageUrl = x.ImageUrl,
                    ProductionStartYear = x.ProductionStartYear,
                    ProductionEndYear = x.ProductionEndYear,
                    DriveWheel = x.DriveWheel,
                    Length = x.Length,
                    Height = x.Height,
                    Weigth = x.Weigth,
                    Width = x.Width,
                    Engine = x.Engines.First(e => e.Id == firstSelectedCarEngineId)
                }).FirstAsync();

            model.SecondCarFullInformation = await data.CarModels
                .Include(e => e.Engines)
                .Where(x => x.Id == secondSelectedCarId)
                .Select(x => new ComparedCarViewModel
                {
                    Brand = x.Brand.Name,
                    Model = x.Name,
                    ImageUrl = x.ImageUrl,
                    ProductionStartYear = x.ProductionStartYear,
                    ProductionEndYear = x.ProductionEndYear,
                    DriveWheel = x.DriveWheel,
                    Length = x.Length,
                    Height = x.Height,
                    Weigth = x.Weigth,
                    Width = x.Width,
                    Engine = x.Engines.First(e => e.Id == secondSelectedCarEngineId)
                })
                .FirstAsync();

            return View(model);
        }
    }
}
