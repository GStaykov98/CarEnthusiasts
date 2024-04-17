using CarEnthusiasts.Data.Contracts.Compare;
using CarEnthusiasts.Models;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Data.Services.Compare
{
    public class CompareService : ICompareService
    {
        private readonly ApplicationDbContext data;

        public CompareService(ApplicationDbContext context)
        {
            data = context;
        }

        public async Task<bool> CarExist(int id)
        {
            return await data.CarModels.AnyAsync(x => x.Id == id);
        }

        public async Task<bool> EngineExist(int carId, int engineId)
        {
            return await data.CarModels
                .Where(x => x.Id == carId)
                .AnyAsync(c => c.Engines.Any(e => e.Id == engineId));
        }

        public async Task<ComparedCarViewModel> GetCar(int carId, int engineId)
        {
            var car = await data.CarModels
                .Include(e => e.Engines)
                .Where(x => x.Id == carId)
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
                    Engine = x.Engines.First(e => e.Id == engineId)
                }).FirstAsync();

            return car;
        }

        public async Task<ComparisonViewModel> GettAllCars()
        {
            var cars = new ComparisonViewModel
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

            return cars;
        }
    }
}
