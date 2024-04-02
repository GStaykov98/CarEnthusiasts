using CarEnthusiasts.Data;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Controllers
{
    public class CarInformationController : Controller
    {
        private readonly ApplicationDbContext data;

        public CarInformationController(ApplicationDbContext context)
        {
            data = context;
        }

        public async Task<IActionResult> AllCars()
        {
            var cars = await data.CarBrands
                .AsNoTracking()
                .OrderBy(x => x.Name)
                .Select(x => new CarBrandsViewModel(
                    x.Id,
                    x.Name,
                    x.ImageUrl))
                .ToListAsync();

            return View(cars);
        }

        public async Task<IActionResult> AllModels(int id)
        {
            if (CheckIfCarExists(id))
            {
                return BadRequest();
            }

            var models = await data.CarModels
                .AsNoTracking()
                .Where(i => i.BrandId == id)
                .OrderBy(x => x.Name)
                .Select(x => new CarModelsViewModel(
                    x.Id,
                    x.Name,
                    x.ProductionStartYear,
                    x.ProductionEndYear,
                    x.ImageUrl,
                    x.Brand))
                .ToListAsync();

            return View(models);
        }

        public async Task<IActionResult> ShowCarInformation(int brandId, int modelId)
        {
            if (CheckIfCarExists(brandId, modelId))
            {
                return BadRequest();
            }



            return View();
        }

        private bool CheckIfCarExists(int brandId)
        {
            if (data.CarBrands.Any(x => x.Id == brandId))
            {
                return true;
            }

            return false;
        }

        private bool CheckIfCarExists(int brandId, int modelId)
        {
            if (data.CarBrands.Any(x => x.Id == brandId))
            {
                var currentCar = data.CarBrands.FirstOrDefault(x => x.Id == brandId);

                if (currentCar != null && currentCar.Models.Any(x => x.Id == modelId))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
