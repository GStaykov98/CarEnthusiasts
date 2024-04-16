using CarEnthusiasts.Data.Contracts.CarInformation;
using CarEnthusiasts.Models;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Data.Services.CarInformation
{
    public class CarInformationService : ICarInformationService
    {
        private readonly ApplicationDbContext data;

        public CarInformationService(ApplicationDbContext context)
        {
            data = context;
        }
        public async Task<IEnumerable<CarBrandsViewModel>> GetAllBrands()
        {
            var cars = await data.CarBrands
                .AsNoTracking()
                .OrderBy(x => x.Name)
                .Select(x => new CarBrandsViewModel(
                    x.Id,
                    x.Name,
                    x.ImageUrl))
                .ToListAsync();

            return cars;
        }

        public async Task<bool> BrandExists(int id)
        {
            return await data.CarBrands.AnyAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<CarModelsViewModel>> GetAllModels(int id)
        {
            var models = await data.CarModels
                .AsNoTracking()
                .Where(i => i.BrandId == id)
                .OrderBy(x => x.Name)
                .Select(x => new CarModelsViewModel
                {
                    Id = x.Id,
                    Brand = x.Brand,
                    Name = x.Name,
                    ImageUrl = x.ImageUrl,
                    ProductionStartYear = x.ProductionStartYear,
                    ProductionEndYear = x.ProductionEndYear
                })
                .ToListAsync();

            return models;
        }

        public async Task<bool> ModelExists(int id)
        {
            return await data.CarModels.AnyAsync(x => x.Id == id);
        }

        public async Task<CarFullInformationViewModel> GetFullInformation(int id)
        {
            var currentCar = await data.CarModels
                .Where(x => x.Id == id)
                .AsNoTracking()
                .Select(x => new CarFullInformationViewModel
                {
                    Id = x.Id,
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
                    Engines = x.Engines.Select(e => new CarEnginesViewModel
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Acceleration = e.Acceleration,
                        TopSpeed = e.TopSpeed,
                        Aspiration = e.Aspiration,
                        Displacement = e.Displacement,
                        Gearbox = e.Gearbox,
                        HorsePower = e.HorsePower,
                        Torque = e.Torque,
                        Type = e.Type
                    }).ToList()

                }).FirstAsync();

            return currentCar;
        }
    }
}
