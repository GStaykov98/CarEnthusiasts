using CarEnthusiasts.Models;

namespace CarEnthusiasts.Data.Contracts.CarInformation
{
    public interface ICarInformationService
    {
        Task<IEnumerable<CarBrandsViewModel>> GetAllBrands();
        Task<bool> BrandExists(int id);
        Task<bool> ModelExists(int id);
        Task<IEnumerable<CarModelsViewModel>> GetAllModels(int id);
        Task<CarFullInformationViewModel> GetFullInformation(int id);
    }
}
