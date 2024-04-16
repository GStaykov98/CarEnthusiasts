using CarEnthusiasts.Data.Contracts.CarInformation;
using Microsoft.AspNetCore.Mvc;

namespace CarEnthusiasts.Controllers
{
    public class CarInformationController : Controller
    {
        private readonly ICarInformationService cars;

        public CarInformationController(ICarInformationService _cars)
        {
            cars = _cars;
        }

        public async Task<IActionResult> AllCars()
        {
            var brands = await cars.GetAllBrands();

            return View(brands);
        }

        public async Task<IActionResult> AllModels(int id)
        {
            if (!await cars.BrandExists(id))
            {
                return BadRequest();
            }

            var models = await cars.GetAllModels(id);

            return View(models);
        }

        public async Task<IActionResult> ShowCarInformation(int brandId, int modelId)
        {
            if (!await cars.BrandExists(brandId))
            {
                return BadRequest();
            }

            if (!await cars.ModelExists(modelId))
            {
                return BadRequest();
            }

            var currentCar = await cars.GetFullInformation(modelId);

            return View(currentCar);
        }
    }
}
