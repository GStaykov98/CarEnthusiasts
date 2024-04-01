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
                .Select(x => new CarBrandsViewModel(
                    x.Id,
                    x.Name,
                    x.ImageURL))
                .ToListAsync();

            return View(cars);
        }
    }
}
