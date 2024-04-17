using CarEnthusiasts.Data;
using CarEnthusiasts.Data.Contracts.Compare;
using CarEnthusiasts.Data.Models;
using CarEnthusiasts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Controllers
{
    public class CompareController : Controller
    {
        private readonly ICompareService compareService;

        public CompareController(ICompareService service)
        {
            compareService = service;
        }

        [HttpGet]
        public async Task<IActionResult> CompareCars()
        {
            var viewModel = await compareService.GettAllCars();

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

            if (!await compareService.CarExist(firstSelectedCarId) ||
                !await compareService.CarExist(secondSelectedCarId) ||
                !await compareService.EngineExist(firstSelectedCarId, firstSelectedCarEngineId) ||
                !await compareService.EngineExist(secondSelectedCarId, secondSelectedCarEngineId))
            {
                return BadRequest();
            }

            model.FirstCarFullInformation = await compareService.GetCar(firstSelectedCarId, firstSelectedCarEngineId);

            model.SecondCarFullInformation = await compareService.GetCar(secondSelectedCarId, secondSelectedCarEngineId);

            return View(model);
        }
    }
}
