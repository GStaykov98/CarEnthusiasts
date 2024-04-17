using CarEnthusiasts.Models;

namespace CarEnthusiasts.Data.Contracts.TuningParts
{
    public interface ITuningPartsService
    {
        Task<IEnumerable<TuningPartCategoryViewModel>> GetCategories();
        Task<bool> CategoryExist(int id);
        Task<bool> PartExists(int id);
        Task<IEnumerable<TuningPartViewModel>> GetPartsByCategory(int id);
        Task<TuningPartDetailsIViewModel> GetPartDetails(int id);
        Task<BuyPartViewModel> GetPartBuyForm(int id);
        Task<bool> PartIsInStock(int id);
        Task BuyPart(int id);
    }
}
