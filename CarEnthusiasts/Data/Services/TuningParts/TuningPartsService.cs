using CarEnthusiasts.Data.Contracts.TuningParts;
using CarEnthusiasts.Models;
using Microsoft.EntityFrameworkCore;

namespace CarEnthusiasts.Data.Services.TuningParts
{
    public class TuningPartsService : ITuningPartsService
    {
        private readonly ApplicationDbContext data;

        public TuningPartsService(ApplicationDbContext context)
        {
            data = context;
        }

        public async Task BuyPart(int id)
        {
            var currentPart = await data.TuningParts.FirstAsync(x => x.Id == id);

            currentPart.Quantity--;

            await data.SaveChangesAsync();
        }

        public async Task<bool> CategoryExist(int id)
        {
            return await data.TuningPartCategories.AnyAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<TuningPartCategoryViewModel>> GetCategories()
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

            return categories;
        }

        public async Task<BuyPartViewModel> GetPartBuyForm(int id)
        {
            var part = await data.TuningParts.FirstAsync(x => x.Id == id);

            var model = new BuyPartViewModel
            {
                Id = part.Id,
                PartName = part.Name,
                Price = part.Price,
                ImageUrl = part.ImageUrl
            };

            return model;
        }

        public async Task<TuningPartDetailsIViewModel> GetPartDetails(int id)
        {
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
                .FirstAsync(x => x.Id == id);

            foreach (var z in carModel)
            {
                model.CarModels.Add(new TuningPartCarModelViewModel { BrandName = z.Brand.Name, ModelName = z.Name });
            }

            return model;
        }

        public async Task<IEnumerable<TuningPartViewModel>> GetPartsByCategory(int id)
        {
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

            return tuningParts;
        }

        public async Task<bool> PartExists(int id)
        {
            return await data.TuningParts.AnyAsync(x => x.Id == id);
        }

        public async Task<bool> PartIsInStock(int id)
        {
            var part = await data.TuningParts.FirstAsync(x => x.Id == id);

            if (part.Quantity > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
